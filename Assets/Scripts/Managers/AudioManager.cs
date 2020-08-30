using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AudioManager: MonoBehaviour
{

    private static AudioManager instance;
    public static AudioManager Instance 
    { 
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<AudioManager>();
                if(instance == null)
                {
                    instance = new GameObject("AudioManager", typeof(AudioManager)).GetComponent<AudioManager>();
                }
            }

            return instance;
        }
        private set
        {
            instance = value;
        }
    }


    [System.Serializable]
    public class SoundFiles
    {
        public AudioType audioType;
        public AudioClip soundClip;
        [Range(0.1f, 1.0f)]
        public float volumeLevel;
        public bool loop;
    }
    
    public enum AudioType
    {
        Background,
        Pause,
        End,
        Click1,
        Click2,
        Click3

    }

    public SoundFiles[] soundCollection;
    public Dictionary<AudioType, AudioSource> soundMap = new Dictionary<AudioType, AudioSource>();

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        foreach (SoundFiles file in soundCollection)
        {
            if (!soundMap.ContainsKey(file.audioType))
            {
                AudioSource newAudioSource = gameObject.AddComponent<AudioSource>();
                newAudioSource.clip = file.soundClip;
                newAudioSource.volume = file.volumeLevel;
                newAudioSource.loop = file.loop;
                soundMap.Add(file.audioType, newAudioSource);
            }

        }
    }


    public void PlayAudio(AudioType type)
    {
        AudioSource soundToPlay = soundMap[type];
        if(soundToPlay != null)
        {
            soundToPlay.Play();
        }

    }

    
    public void StopAudio(AudioType type)
    {
        AudioSource soundToPlay = soundMap[type];
        if (soundToPlay != null)
        {
            soundToPlay.Stop();
        }
    }

}
