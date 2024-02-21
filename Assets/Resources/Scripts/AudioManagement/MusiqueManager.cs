using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusiqueManager : MonoBehaviour
{
    private AudioSource audioSource;

    [Header("Music Clip")]
    [SerializeField] AudioClip backgroundMusic;
    [SerializeField] AudioClip bardsSong;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayDefault()
    {
        audioSource.clip = backgroundMusic;
        audioSource.Play();
    }

    public void PlayBardSong()
    {
        audioSource.clip = bardsSong;
        audioSource.Play();
    }
}
