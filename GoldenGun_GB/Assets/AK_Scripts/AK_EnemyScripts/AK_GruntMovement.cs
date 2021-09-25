using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_GruntMovement : MonoBehaviour
{
    public bool movesRight;
    Rigidbody2D gruntRB;
    SpriteRenderer gruntSpriteRend;
    public float gruntMovementSpeed;

    private void Start()
    {
        gruntRB = GetComponent<Rigidbody2D>();
        gruntSpriteRend = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {

        if (movesRight)
        {
            gruntRB.velocity = new Vector2(gruntMovementSpeed, gruntRB.velocity.y);
            gruntSpriteRend.flipX = true;
        }
        else if (!movesRight)
        {
            gruntRB.velocity = new Vector2(-gruntMovementSpeed, gruntRB.velocity.y);
            gruntSpriteRend.flipX = false;
        }  
    }


    public void TurnBack()
    {
        if (movesRight)
        {
            movesRight = false;
        }
        else if (!movesRight)
        {
            movesRight = true;
        }
    }
}
