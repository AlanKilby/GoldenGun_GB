using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_Tombstone : MonoBehaviour
{
    public AudioClip tombstoneSound;

    AudioSource tombAudioSource;

    private void Start()
    {
        tombAudioSource = GetComponent<AudioSource>();
    }

}
