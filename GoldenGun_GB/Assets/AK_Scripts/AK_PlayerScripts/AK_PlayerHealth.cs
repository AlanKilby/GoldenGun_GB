using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerHealth : MonoBehaviour
{

    public int playerHP;

    public int maxHP;

    AK_PlayerDeath playerDeath;

    private void Start()
    {
        playerDeath = GetComponent<AK_PlayerDeath>();
    }

    private void Update()
    {
        if(playerHP <= 0 && !playerDeath.isDead)
        {
            playerDeath.PlayerDeath();  
        }
    }

    public void LoseHP()
    {
        if(playerHP > 0)
        {
            playerHP--;
        }
    }

    public void GainHP()
    {
        if(playerHP < maxHP)
        {
            playerHP++;
        }
    }
}
