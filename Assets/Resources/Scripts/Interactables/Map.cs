using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    [SerializeField] GameObject triangle1;
    [SerializeField] GameObject triangle2;

    [SerializeField] TextAsset inkJSON;

    private void OnMouseOver()
    {
        if (!GeneralMenu.GetInstance().isOpenMenu)
        {            
            triangle1.GetComponent<SpriteRenderer>().enabled = true;
            triangle2.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    private void OnMouseExit()
    {
        if (!GeneralMenu.GetInstance().isOpenMenu)
        {
            triangle1.GetComponent<SpriteRenderer>().enabled = false;
            triangle2.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    private void OnMouseDown()
    {
        if (!AnswerBoxManager.GetInstance().talking && !GeneralMenu.GetInstance().isOpenMenu)
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON, gameObject.name);
    }
}
