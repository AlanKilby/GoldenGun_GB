using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_EnemyBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            AK_PlayerHealth playerHealth = collision.gameObject.GetComponent<AK_PlayerHealth>();

            playerHealth.LoseHP();

            Destroy(gameObject);
        }
    }
}
