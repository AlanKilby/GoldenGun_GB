using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public AK_PlayerAnimations playerAnimations;

    [HideInInspector]
    public float horizontalMovement;

    AK_PlayerShooting playerShoot;
    
    // Player Stats
    public float playerSpeed;
    public float jumpForce;
    
    public bool isLookingRight;

    public bool isGrounded;

    public Transform groundCheck;

    public LayerMask groundLayer;
    int groundLayerInt;

    public bool canMove;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerShoot = GetComponent<AK_PlayerShooting>();
        groundLayerInt = groundLayer.value;
        isLookingRight = true;
        canMove = true;
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,0.6f, groundLayerInt);
        

        horizontalMovement = Input.GetAxisRaw("Horizontal") * playerSpeed;

        LookDirection();
        

        if (Input.GetButtonDown("Jump") && isGrounded == true && canMove)
        {
            PlayerJump();
        }

        if (Input.GetButtonDown("Shoot") && canMove)
        {
            if (playerShoot.ammoCounter != 0)
                playerAnimations.ChangeAnimationState(playerAnimations.PLAYER_SHOOTING);

            playerShoot.PlayerShoot(isLookingRight);     
        }

        if(canMove)
            MovePlayer(horizontalMovement);

        if (!isGrounded)
        {
            playerAnimations.ChangeAnimationState(playerAnimations.PLAYER_FALLING);
        }
        
        if(isGrounded && horizontalMovement == 0)
        {
            playerAnimations.ChangeAnimationState(playerAnimations.PLAYER_IDLE);
        }
    }

    void MovePlayer(float _horizontalMovement)
    {
        playerRB.velocity = new Vector2(_horizontalMovement, playerRB.velocity.y);

        if(horizontalMovement != 0 && isGrounded)
            playerAnimations.ChangeAnimationState(playerAnimations.PLAYER_MOVING);

    }

    void PlayerJump()
    {
        playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);

        playerAnimations.ChangeAnimationState(playerAnimations.PLAYER_JUMPING);
    }

    void LookDirection()
    {
        if(horizontalMovement > 0)
        {
            isLookingRight = true;
        }
        else if(horizontalMovement < 0)
        {
            isLookingRight = false;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheck.position, 0.6f);
    }
}
