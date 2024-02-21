using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurer2_Dialogue : MonoBehaviour
{
    [SerializeField] TextAsset inkJSON_notAngry;
    [SerializeField] TextAsset inkJSON_Angry;

    private void OnMouseDown()
    {
        if (!AnswerBoxManager.GetInstance().talking && !PlayerStats.GetInstance().hasAdv2Angry)
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON_notAngry, gameObject.name);
        else if (!AnswerBoxManager.GetInstance().talking && PlayerStats.GetInstance().hasAdv2Angry)
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON_Angry, gameObject.name);
    }
}
