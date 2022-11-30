using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// By: Nicolas Assakura Miyazaki

public class PlayerAudioManager : MonoBehaviour
{
    [SerializeField]
    private List<AudioClip> audioClips;
    [SerializeField]
    private AudioSource audioSource;

    public void PlayClip(int index)
    {
        audioSource.PlayOneShot(audioClips[index]);
    }
}
