using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            AK_EnemyHealth enemyHP = collision.gameObject.GetComponent<AK_EnemyHealth>();

            enemyHP.LoseHP();

            AK_PlayerShooting playerShooting = GameObject.FindGameObjectWithTag("Player").GetComponent<AK_PlayerShooting>();

            if (playerShooting.ammoCounter < playerShooting.maxAmmo)
                playerShooting.ammoCounter += 1;

            Destroy(gameObject);
        }
    }
}
