using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance{get; private set; }

    private AudioSource source;
    void Awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);   //Keep this object even when we go to the new scene

        if(instance==null)
        {
            instance = this;  DontDestroyOnLoad(gameObject);
        }
        else if(instance !=null && instance != this)   //Destroy duplicate gameobjects
        {
            Destroy(gameObject);
        }
    }

   
    public void PlaySound(AudioClip _sound)
    {
        source.PlayOneShot(_sound);
    }


    public void StopSound(AudioClip _sound)
    {
        source.Stop();
    }
}
