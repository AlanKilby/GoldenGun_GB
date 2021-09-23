using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_Bullet : MonoBehaviour
{
    public float bulletSpeed;

    Rigidbody2D bulletRB;


    private void Start()
    {
        bulletRB = gameObject.GetComponent<Rigidbody2D>();

        bulletRB.velocity = new Vector2(bulletSpeed, 0f);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
