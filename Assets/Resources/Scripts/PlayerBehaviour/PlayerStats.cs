using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int tips { get; private set; }
    public bool hasBeer {  get; private set; }
    public bool hasPotion { get; private set; }
    public bool hasAdv2Angry { get; private set; }
    public bool hasBoardTip { get; private set; }
    public bool hasLetterTip { get; private set; }
    private static PlayerStats instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else Debug.LogWarning("Already a player instance");

        hasBeer = false;
        hasPotion = false;
        hasBoardTip = false;
        hasLetterTip = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            GeneralMenuOpen(!GeneralMenu.GetInstance().isOpenMenu);
    }

    private void Start()
    {
        tips = 0;
    }

    private void GeneralMenuOpen(bool isOpenMenu)
    {
        GeneralMenu.GetInstance().OpenMenu(isOpenMenu);
    }

    public static PlayerStats GetInstance()
    {
        return instance;
    }

    public void AddTip() { 
        if (tips<4)
            tips++; 
    }

    public void ChangePotionStatus() => hasPotion = true;

    public void ChangeHasBeerStatus() => hasBeer = !hasBeer;

    public void ChangeAdv2Status() => hasAdv2Angry = true;
    public void HasLetterTip() => hasLetterTip = true;
    public void HasBoardTip() => hasBoardTip = true;

}
