using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (!PlayerStats.GetInstance().hasBeer && !GeneralMenu.GetInstance().isOpenMenu)
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

    private void OnMouseExit()
    {
        if (!GeneralMenu.GetInstance().isOpenMenu)
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    private void OnMouseDown()
    {
        if (!PlayerStats.GetInstance().hasBeer && !GeneralMenu.GetInstance().isOpenMenu)
            PlayerStats.GetInstance().ChangeHasBeerStatus();
    }
}
