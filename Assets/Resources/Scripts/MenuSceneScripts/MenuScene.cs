using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    private void Update()
    {
        if (GeneralMenu.GetInstance().isOpenMenu && Input.GetKeyDown(KeyCode.Escape))
            GeneralMenu.GetInstance().OpenMenu(!GeneralMenu.GetInstance().isOpenMenu);
    }

    public void BtnPlayClick() => StartCoroutine(LoadPlayScene());

    IEnumerator LoadPlayScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(1);
    }

    public void BtnOptionClick() => GeneralMenu.GetInstance().OpenMenu(!GeneralMenu.GetInstance().isOpenMenu);

    public void BtnQuitClick() {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
