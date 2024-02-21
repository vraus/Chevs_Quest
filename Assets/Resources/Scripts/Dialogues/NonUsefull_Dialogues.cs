using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class NonUsefull_Dialogues : MonoBehaviour
{
    [SerializeField] TextAsset inkJSON;

    private void OnMouseDown()
    {
        if (!AnswerBoxManager.GetInstance().talking && !GeneralMenu.GetInstance().isOpenMenu) 
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON, gameObject.name);
    }
}
