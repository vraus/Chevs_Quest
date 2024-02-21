using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    [SerializeField] TextAsset inkJSON;

    private SpriteRenderer spriteRenderer;
    Color initial = Color.white;
    Color over = new Color(115, 54, 54, 0.5f);

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = initial;
    }

    private void OnMouseOver()
    {
        if (!PlayerStats.GetInstance().hasLetterTip && !GeneralMenu.GetInstance().isOpenMenu)
            spriteRenderer.color = over;
    }

    private void OnMouseExit()
    {
        if (!PlayerStats.GetInstance().hasLetterTip && !GeneralMenu.GetInstance().isOpenMenu)
            spriteRenderer.color = initial;
    }

    private void OnMouseDown()
    {
        if (!AnswerBoxManager.GetInstance().talking && !PlayerStats.GetInstance().hasLetterTip && !GeneralMenu.GetInstance().isOpenMenu)
        {
            AnswerBoxManager.GetInstance().EnterDialogueMode(inkJSON, gameObject.name);
            spriteRenderer.color = initial;
        }
    }
}
