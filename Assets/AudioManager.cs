using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-------Audio Source-------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [Header("-------Audio clip---------")]


    public AudioClip backGround;
    public AudioClip fly;
    public AudioClip obstacleTouch;
    public AudioClip rewardTouch;
    public AudioClip getPoint;

    private void Start()
    {
        musicSource.clip = backGround;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

}
