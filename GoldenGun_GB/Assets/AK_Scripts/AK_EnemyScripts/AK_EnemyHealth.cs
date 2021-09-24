using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_EnemyHealth : MonoBehaviour
{
    public int enemyHP;

    AK_EnemyDeath enemyDeathScript;


    private void Start()
    {
        enemyDeathScript = GetComponent<AK_EnemyDeath>();
    }


    private void Update()
    {
        if(enemyHP <= 0)
        {
            enemyDeathScript.EnemyDeath();
        }
    }

    public void LoseHP()
    {
        if(enemyHP > 0)
        {
            enemyHP--;
        }
    }
}
