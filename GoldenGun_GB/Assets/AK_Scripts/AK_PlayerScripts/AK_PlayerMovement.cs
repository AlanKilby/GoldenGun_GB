using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;
    

    public float playerSpeed;
    public float jumpForce;

    float horizontalMovement;

    public bool isGrounded;

    public Transform groundCheck;

    public LayerMask groundLayer;
    int groundLayerInt;

    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        groundLayerInt = groundLayer.value;
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,0.45f, groundLayerInt);
        

        horizontalMovement = Input.GetAxisRaw("Horizontal") * playerSpeed;

        //isGrounded = groundCheck.isGrounded;
        

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            PlayerJump();
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

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheck.position, 0.45f);
    }
}
