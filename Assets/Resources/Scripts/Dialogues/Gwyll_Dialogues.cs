using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gwyll_Dialogues : MonoBehaviour
{
    [SerializeField] TextAsset inkJSON;

    private void OnMouseDown()
    {
        if (!AnswerBoxManager.GetInstance().talking && !GeneralMenu.GetInstance().isOpenMenu) 
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON, gameObject.name);
    }
}
