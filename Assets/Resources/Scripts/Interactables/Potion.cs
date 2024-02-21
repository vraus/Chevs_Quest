using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{

    [SerializeField] TextAsset inkJSON;

    private void OnMouseOver()
    {
        if (!PlayerStats.GetInstance().hasPotion && !GeneralMenu.GetInstance().isOpenMenu)
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

    private void OnMouseExit()
    {
        if (!PlayerStats.GetInstance().hasPotion && !GeneralMenu.GetInstance().isOpenMenu) 
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    private void OnMouseDown()
    {
        if (!PlayerStats.GetInstance().hasPotion && !AnswerBoxManager.GetInstance().talking && !GeneralMenu.GetInstance().isOpenMenu)
        {
            PlayerStats.GetInstance().ChangePotionStatus();
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON, gameObject.name);
        }
    }
}
