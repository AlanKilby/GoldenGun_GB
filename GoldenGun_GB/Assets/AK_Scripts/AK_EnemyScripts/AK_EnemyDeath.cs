using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_EnemyDeath : MonoBehaviour
{
    public GameObject tombstone;
    public GameObject deathAnimObj;

    AK_EnemyHealth enemyHP;
    private void Start()
    {
        enemyHP = GetComponent<AK_EnemyHealth>();
    }
    private void Update()
    {
        if(enemyHP.enemyHP <= 0)
        {
            EnemyDeath();
        }
    }

    public void EnemyDeath()
    {
        Instantiate(tombstone,new Vector2(transform.position.x, transform.position.y+1), Quaternion.identity);
        Instantiate(deathAnimObj,transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
