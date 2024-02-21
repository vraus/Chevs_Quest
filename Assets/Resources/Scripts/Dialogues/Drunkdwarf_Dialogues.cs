using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drunkdwarf_Dialogues : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON_startpoint;
    [SerializeField] private TextAsset inkJSON_endpoint;

    private void OnMouseDown()
    {
        if (!AnswerBoxManager.GetInstance().talking && !PlayerStats.GetInstance().hasBeer && !GeneralMenu.GetInstance().isOpenMenu) 
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON_startpoint, gameObject.name);
        if (!AnswerBoxManager.GetInstance().talking && PlayerStats.GetInstance().hasBeer && !GeneralMenu.GetInstance().isOpenMenu) 
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON_endpoint, gameObject.name);
    }
}
