using Ink.Parsed;
using Ink.Runtime;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerBoxManager : MonoBehaviour
{
    private static AnswerBoxManager instance;
    private string _caller;

    private bool dwarfTip;
    private bool firstAdv2_encounter;
    private bool letterTip;
    private bool gwyllTip;
    private bool boardTip;

    private int choiceSum;

    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePrefab;
    [SerializeField] private UnityEngine.UI.Text dialogueTxt;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private UnityEngine.UI.Text[] choicesText;

    [Header("Sound Sources")]
    private AudioManager audioManager;

    private Ink.Runtime.Story currentStory;
    public bool talking { get; private set; }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Debug.LogWarning("Instance already created");

        dwarfTip = false;
        firstAdv2_encounter = false;
        letterTip = false;
        boardTip = false;
        gwyllTip = false;
        choiceSum = 0;

        dialoguePrefab.SetActive(false);
        audioManager = AudioManager.GetInstance();
    }

    private void Start()
    {
        talking = false;

        choicesText = new UnityEngine.UI.Text[choices.Length];
        int index = 0;
        foreach(GameObject choice in choices) choicesText[index++] = choice.GetComponentInChildren<UnityEngine.UI.Text>();

    }

    private void Update()
    {
        if (!talking) return;

        if (Input.GetKeyUp(KeyCode.Space)) ContinueStory();
    }

    private void DisplayChoices()
    {
        List<Ink.Runtime.Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices were given than the UI can support. Number of choices given" + currentChoices.Count);
        }

        int index = 0;
        foreach(Ink.Runtime.Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index++].text = choice.text;
        }

        for (int i = index; i < choices.Length; i++) choices[i].gameObject.SetActive(false);
    }

    private IEnumerator ExitDialogueMode()
    {
        if (_caller == "Bard") audioManager.ChangeMusicToDefault();
        yield return new WaitForSeconds(0.1f);
        talking = false;
        dialoguePrefab.SetActive(false);
        dialogueTxt.text = "";
        if (_caller == "Gwyll" && !gwyllTip) CheckGwyllTip();
        else if (_caller == "Letter" && !letterTip)
        {
            letterTip = true;
            PlayerStats.GetInstance().AddTip();
            PlayerStats.GetInstance().HasLetterTip();
        }
        else if (_caller == "Board" && !boardTip)
        {
            boardTip = true;
            PlayerStats.GetInstance().AddTip();
            PlayerStats.GetInstance().HasBoardTip();
        }
        else if (_caller == "Barkeep" && PlayerStats.GetInstance().tips == 4)
        {
            SceneManager.LoadScene(2);
        }

    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            dialogueTxt.text = currentStory.Continue();
            DisplayChoices();
        }
        else
        {
            StartCoroutine(ExitDialogueMode());
        }
    }
    
    private void CheckGwyllTip()
    {
        if(choiceSum == 2 || choiceSum >= 4)
        {
            gwyllTip = true;
            PlayerStats.GetInstance().AddTip();
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON, string caller)
    {
        _caller = caller;
        if (caller == "Adventurer2") firstAdv2_encounter = false;
        if (caller == "Bard") audioManager.ChangeMusicToBardSong();

        currentStory = new Ink.Runtime.Story(inkJSON.text);
        talking = true;
        dialoguePrefab.SetActive(true);

        ContinueStory();
    }

    public void MakeChoice(int choiceIndex)
    {
        if (_caller == "Drunkdwarf" && !dwarfTip)
        {
            PlayerStats.GetInstance().AddTip();
            dwarfTip = true;
        } else if (_caller == "Adventurer2" && !firstAdv2_encounter)
        {
            if (choiceIndex == 1)
                PlayerStats.GetInstance().ChangeAdv2Status();
            firstAdv2_encounter = true;
        }
        currentStory.ChooseChoiceIndex(choiceIndex);
        choiceSum += choiceIndex;

        ContinueStory();
    }
        
    public static AnswerBoxManager GetInstance()
    {
        return instance;
    }
}
