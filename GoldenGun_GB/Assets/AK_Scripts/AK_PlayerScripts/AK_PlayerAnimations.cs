using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerAnimations : MonoBehaviour
{
    // PLAYER ANIMATIONS

    public string PLAYER_IDLE;
    public string PLAYER_MOVING;
    public string PLAYER_JUMPING;
    public string PLAYER_FALLING;
    public string PLAYER_SHOOTING;

    Animator animator;

    string currentState;

    SpriteRenderer playerSpriteRend;

    AK_PlayerMovement playerMovement;

    private void Start()
    {
        playerSpriteRend = gameObject.GetComponent<SpriteRenderer>();
        playerMovement = gameObject.GetComponent<AK_PlayerMovement>();
        animator = GetComponent<Animator>();
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

    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        animator.Play(newState);

        currentState = newState;
    }
}
