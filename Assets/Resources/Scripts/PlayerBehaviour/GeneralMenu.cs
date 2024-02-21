using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralMenu : MonoBehaviour
{
    private static GeneralMenu instance;


    [Header("Audio Handler")]
    [SerializeField] Slider musicVolumeSlider;
    [SerializeField] InputField musicVolumeInputField;
    [SerializeField] Slider vfxVolumeSlider;
    [SerializeField] InputField vfxVolumeInputField;
    [SerializeField] Slider ambiantVolumeSlider;
    [SerializeField] InputField ambiantVolumeInputField;

    [Header("Canvas")]
    [SerializeField] GameObject generalMenuCanvas;

    [Header("Audio VFX")]
    [SerializeField] AudioClip openGeneralMenuAudio;
    [SerializeField] AudioClip closeGeneralMenuAudio;

    public bool isOpenMenu {  get; private set; }

    private void Awake()
    {
        if (instance == null ) { instance = this; }

        generalMenuCanvas = gameObject.transform.Find("GeneralMenu").gameObject;
        generalMenuCanvas.SetActive(false);
    }

    public void ChangeMusicVolumeSliding()
    {
        AudioManager.GetInstance().ChangeMusiqueVolume(musicVolumeSlider.value);
        float newVal = musicVolumeSlider.value * 100;
        musicVolumeInputField.text = newVal.ToString();
    }

    public void ChangeMusicVolumeAsInput()
    {
        float newVolume = float.Parse(musicVolumeInputField.text) / 100;
        AudioManager.GetInstance().ChangeMusiqueVolume(newVolume);
        musicVolumeSlider.value = newVolume;
    }

    public void ChangeVFXVolumeSliding()
    {
        AudioManager.GetInstance().ChangeVFXVolume(vfxVolumeSlider.value);
        float newVal = vfxVolumeSlider.value * 100;
        vfxVolumeInputField.text = newVal.ToString();
    }

    public void ChangeVFXVolumeAsInput()
    {
        float newVolume = float.Parse(vfxVolumeInputField.text) / 100;
        AudioManager.GetInstance().ChangeVFXVolume(newVolume);
        vfxVolumeSlider.value = newVolume;
    }

    public void ChangeAmbiantVolumeSliding()
    {
        AudioManager.GetInstance().ChangeAmbiantVolume(ambiantVolumeSlider.value);
        float newVal = ambiantVolumeSlider.value * 100;
        ambiantVolumeInputField.text = newVal.ToString();
    }

    public void ChangeAmbiantVolumeAsInput()
    {
        float newVolume = float.Parse(ambiantVolumeInputField.text) / 100;
        AudioManager.GetInstance().ChangeAmbiantVolume(newVolume);
        ambiantVolumeSlider.value = newVolume;
    }

    public void OpenMenu(bool _isOpenMenu)
    {
        generalMenuCanvas.SetActive(_isOpenMenu);
        isOpenMenu = _isOpenMenu;
        StartCoroutine(PlayVFXSound());
    }

    public void ButtonQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public static GeneralMenu GetInstance()
    {
        return instance;
    }

    IEnumerator PlayVFXSound()
    {
        yield return new WaitForEndOfFrame();
        if (isOpenMenu)
            AudioManager.GetInstance().PlayVFXSound(openGeneralMenuAudio);
        else AudioManager.GetInstance().PlayVFXSound(closeGeneralMenuAudio);
    }
}
