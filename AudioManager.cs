using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioType[] AudioType;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyObject(gameObject);
            return;
        }
            
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        foreach (AudioType type in AudioType)
        {
            type.audioSource = gameObject.AddComponent<AudioSource>();
            type.audioSource.name = type.Name;
            type.audioSource.volume = type.Volume;
            type.audioSource.pitch = type.Pitch;
            type.audioSource.loop = type.Loop;

            if (type.audioMixerGroup != null)
            {
                type.audioSource.outputAudioMixerGroup = type.audioMixerGroup;
            }

        }
        
    }

    public void Play(string name)
    {
        foreach (AudioType type in AudioType)
        {
            if (type.Name == name)
            {
                type.audioSource.Play();
                return;
            }
        }

        Debug.LogWarning("没有找到"+name+"音频！");
    }

    public void Pause(string name)
    {
        foreach (AudioType type in AudioType)
        {
            if (type.Name == name)
            {
                type.audioSource.Pause();
                return;
            }
        }

        Debug.LogWarning("没有找到" + name + "音频！");
    }

    public void Stop(string name)
    {
        foreach (AudioType type in AudioType)
        {
            if (type.Name == name)
            {
                type.audioSource.Stop();
                return;
            }
        }

        Debug.LogWarning("没有找到" + name + "音频！");
    }
    

}
