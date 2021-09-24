using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_Shield : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            AK_PlayerHealth playerHealth = collision.GetComponent<AK_PlayerHealth>();
            playerHealth.GainHP();
            Destroy(gameObject);
        }
    }
}
