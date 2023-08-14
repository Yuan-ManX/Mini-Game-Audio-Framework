using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class AudioType
{
    [HideInInspector]
    public AudioClip audioClip;
    public AudioListener audioListener;
    public AudioSource audioSource;
    public AudioMixerGroup audioMixerGroup;

    public string Name;

    [Range(0f, 1f)]
    public float Volume;

    [Range (0.1f, 1f)]
    public float Pitch;

    public bool Loop;
}
