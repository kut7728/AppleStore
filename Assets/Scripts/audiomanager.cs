using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    AudioSource m_MyAudioSource;


    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {   
            PlayAudio();
        }
        if(Input.GetKeyDown(KeyCode.A))
        {   
            StopAudio();
        }
    }

    void PlayAudio()
    {
        m_MyAudioSource.Play();
    }
    void StopAudio()
    {
        m_MyAudioSource.Stop();
    }
}
