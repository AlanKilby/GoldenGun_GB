using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_SeekerDetectionZone : MonoBehaviour
{
    AK_SeekerEnemy enemyScript;

    private void Start()
    {
        enemyScript = GetComponentInParent<AK_SeekerEnemy>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            enemyScript.homing = true;
        }
    }
}
