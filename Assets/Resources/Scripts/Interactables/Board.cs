using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Board : MonoBehaviour
{
    [SerializeField] TextAsset inkJSON;
    private void OnMouseOver()
    {
        if (!GeneralMenu.GetInstance().isOpenMenu)
            gameObject.GetComponent<SpriteShapeRenderer>().enabled = true;
    }

    private void OnMouseExit()
    {
        if (!GeneralMenu.GetInstance().isOpenMenu)
            gameObject.GetComponent <SpriteShapeRenderer>().enabled = false;
    }

    private void OnMouseDown()
    {
        if (!AnswerBoxManager.GetInstance().talking && !PlayerStats.GetInstance().hasBoardTip && !GeneralMenu.GetInstance().isOpenMenu)
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON, gameObject.name);
    }
}
