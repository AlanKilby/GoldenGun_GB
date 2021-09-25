using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_SeekerDamage : MonoBehaviour
{

    public AK_SeekerEnemy seeker;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            AK_PlayerHealth playerHealth = collision.gameObject.GetComponent<AK_PlayerHealth>();
            seeker.homing = false;
            playerHealth.LoseHP();
        }
    }
}
