using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barkeep_Dialogues : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON_startPoint;
    [SerializeField] private TextAsset inkJSON_endPoint;

    private void OnMouseDown()
    {
        if (!AnswerBoxManager.GetInstance().talking && PlayerStats.GetInstance().tips != 4 && !GeneralMenu.GetInstance().isOpenMenu) 
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON_startPoint, gameObject.name);
        else if (!AnswerBoxManager.GetInstance().talking && PlayerStats.GetInstance().tips == 4 && !GeneralMenu.GetInstance().isOpenMenu) 
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON_endPoint, gameObject.name);
    }

}
