using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWalk : MonoBehaviour
{
    public AudioClip walkingAudio;
    
    void Start()
    {
        // AudioSource audio = GetComponent<AudioSource>();
        // audio.Play();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = walkingAudio;
            audio.Play();
        }
        else if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = walkingAudio;
            audio.Stop();
        }
    }
}
