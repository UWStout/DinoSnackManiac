﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AudioController : MonoBehaviour
{
    public AudioSource loopMusic;
    public AudioClip comboMusic;
    private AudioSource introMusic;
    void Start()
    {
        introMusic = GetComponent<AudioSource>();
        introMusic.Play(0);
        loopMusic.PlayDelayed(introMusic.clip.length);
    }
}