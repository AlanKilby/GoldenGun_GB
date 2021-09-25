using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_Tombstone : MonoBehaviour
{
    public Sprite[] tombstones;

    public AudioClip tombstoneSound;

    AudioSource tombAudioSource;

    SpriteRenderer tombstoneSpriteRend;

    public void Awake()
    {
        tombstoneSpriteRend = GetComponent<SpriteRenderer>();
        tombstoneSpriteRend.sprite = tombstones[Random.Range(0, tombstones.Length)];
    }
    private void Start()
    {
        tombAudioSource = GetComponent<AudioSource>();
    }

}
