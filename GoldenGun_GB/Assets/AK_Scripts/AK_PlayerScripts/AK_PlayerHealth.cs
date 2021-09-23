using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerHealth : MonoBehaviour
{

    public int playerHP;

    public int maxHP;


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
