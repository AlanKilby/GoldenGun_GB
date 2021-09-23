using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerAnimations : MonoBehaviour
{
    public SpriteRenderer playerSpriteRend;

    AK_PlayerMovement playerMovement;

    private void Start()
    {
        playerSpriteRend = gameObject.GetComponent<SpriteRenderer>();
        playerMovement = gameObject.GetComponent<AK_PlayerMovement>();
    }


    private void Update()
    {
        if(playerMovement.horizontalMovement < 0)
        {
            playerSpriteRend.flipX = true;
        }
        else if (playerMovement.horizontalMovement > 0)
        {
            playerSpriteRend.flipX = false;
        }
    }
}
