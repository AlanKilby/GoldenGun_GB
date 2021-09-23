using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;

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

    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        playerShoot = gameObject.GetComponent<AK_PlayerShooting>();
        groundLayerInt = groundLayer.value;
        isLookingRight = true;
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,0.45f, groundLayerInt);
        

        horizontalMovement = Input.GetAxisRaw("Horizontal") * playerSpeed;

        LookDirection();
        

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            PlayerJump();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            playerShoot.PlayerShoot(isLookingRight);
        }

        MovePlayer(horizontalMovement);
        
    }

    void MovePlayer(float _horizontalMovement)
    {
        playerRB.velocity = new Vector2(_horizontalMovement, playerRB.velocity.y);

    }

    void PlayerJump()
    {
        playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
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
        Gizmos.DrawWireSphere(groundCheck.position, 0.45f);
    }
}
