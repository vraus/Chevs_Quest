using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingPoint : MonoBehaviour
{
    [SerializeField] TextAsset inkJSON;
    public bool startOnAwake;

    private void Start()
    {
        StartCoroutine(StartDialogue());
    }

    private IEnumerator StartDialogue() 
    {
        yield return new WaitForEndOfFrame();
        if (inkJSON != null && startOnAwake)
        {
            if (!AnswerBoxManager.GetInstance().talking && !GeneralMenu.GetInstance().isOpenMenu)
            {
                AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON, gameObject.name);
            }
        }
    }
}
