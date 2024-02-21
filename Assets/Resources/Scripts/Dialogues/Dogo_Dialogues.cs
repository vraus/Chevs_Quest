using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogo_Dialogues : MonoBehaviour
{
    [SerializeField] TextAsset inkJSON_noPotion;
    [SerializeField] TextAsset inkJSON_Potion;

    private void OnMouseDown()
    {
        if (!AnswerBoxManager.GetInstance().talking && !PlayerStats.GetInstance().hasPotion && !GeneralMenu.GetInstance().isOpenMenu) 
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON_noPotion, gameObject.name);
        if (!AnswerBoxManager.GetInstance().talking && PlayerStats.GetInstance().hasPotion && !GeneralMenu.GetInstance().isOpenMenu) 
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON_Potion, gameObject.name);
    }
}
