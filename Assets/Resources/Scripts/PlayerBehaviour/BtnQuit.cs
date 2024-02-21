using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnQuit : MonoBehaviour
{
    public void BtnQuitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
