﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AK_PlayerDeath : MonoBehaviour
{

    public GameObject tombstone;

    public GameObject playAgain;

    public bool isDead;

    AK_PlayerMovement playerMov;

    SpriteRenderer playerSR;

    private void Awake()
    {
        isDead = false;
        playerSR = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        playerMov = GetComponent<AK_PlayerMovement>();
    }
    public void PlayerDeath()
    {
        playerSR.sprite = null;

        Instantiate(tombstone, transform.position, Quaternion.identity);
        Instantiate(playAgain, transform.position, Quaternion.identity);

        playerMov.playerRB.bodyType = RigidbodyType2D.Static;
        playerMov.canMove = false;

        isDead = true;

    }
}
