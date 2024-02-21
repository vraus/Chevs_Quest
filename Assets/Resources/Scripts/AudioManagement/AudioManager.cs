using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    [Header("Audio Sources")]
    [SerializeField] GameObject musiqueSource_go;
    AudioSource musiqueSource;
    MusiqueManager musiqueManager;
    [SerializeField] AudioSource ambiantSource;
    [SerializeField] GameObject vfxSource_go;
    AudioSource vfxSource;

    private void Awake()
    {
        if (instance == null) instance = this;
        musiqueSource = musiqueSource_go.GetComponent<AudioSource>();
        vfxSource = vfxSource_go.GetComponent<AudioSource>();
        musiqueManager = musiqueSource_go.GetComponent<MusiqueManager>();
    }

    public void ChangeMusiqueVolume(float volume)
    {
        musiqueSource.volume = volume;
    }

    public void ChangeAmbiantVolume(float volume)
    {
        ambiantSource.volume = volume;
    }

    public void ChangeVFXVolume(float volume)
    {
        vfxSource.volume = volume;
    }

    public void ChangeMusicToDefault() => musiqueManager.PlayDefault();

    public void ChangeMusicToBardSong() => musiqueManager.PlayBardSong();

    public void PlayVFXSound(AudioClip clip) => vfxSource.PlayOneShot(clip);

    public static AudioManager GetInstance() { return instance; }

    public GameObject GetMusiqueSource() { return musiqueSource_go; }

}
