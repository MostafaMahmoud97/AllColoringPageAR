using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioFactsScript : MonoBehaviour
{

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] clips;

    private int currentIndex = 0;

    public void playAudio(int index)
    {
        if (audioSource.isPlaying && currentIndex == index)
        {
            audioSource.Stop();
        }else if(audioSource.isPlaying)
        {
            audioSource.Stop();
            audioSource.clip = clips[index];
            audioSource.Play();
        }
        else
        {
            audioSource.clip = clips[index];
            audioSource.Play();
        }

        currentIndex = index;
    }
}
