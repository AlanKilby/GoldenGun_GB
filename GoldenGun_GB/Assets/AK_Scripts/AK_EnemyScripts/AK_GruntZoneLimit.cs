using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_GruntZoneLimit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            AK_GruntMovement gruntMovement = collision.gameObject.GetComponent<AK_GruntMovement>();
            gruntMovement.TurnBack();
        }
    }
}
