using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_AmmoPack : MonoBehaviour
{
    public int ammoQuantity;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            AK_PlayerShooting playerShooting = collision.gameObject.GetComponent<AK_PlayerShooting>();

            if (playerShooting.ammoCounter < playerShooting.maxAmmo)
            {
                playerShooting.ammoCounter += ammoQuantity;
                Destroy(gameObject);
            }
        }
    }
}
