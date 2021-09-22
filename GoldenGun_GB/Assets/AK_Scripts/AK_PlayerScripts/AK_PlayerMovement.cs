using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;
    

    public float playerSpeed;
    float horizontalMovement;

    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();   
    }
    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal") * playerSpeed;

        MovePlayer(horizontalMovement);
    }

    void MovePlayer(float _horizontalMovement)
    {
        playerRB.velocity = new Vector2(_horizontalMovement, playerRB.velocity.y);
    }
}
