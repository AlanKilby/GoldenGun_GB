using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_GroundCheck : MonoBehaviour
{
    public bool isGrounded;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            isGrounded = true;

        else
            isGrounded = false;
    }

}
