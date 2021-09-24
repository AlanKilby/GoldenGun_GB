using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_UIManager : MonoBehaviour
{

    public GameObject bullet;

    public GameObject heart;

    public GameObject shield;

    AK_PlayerShooting playerShooting;
    AK_PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<AK_PlayerHealth>();
        playerShooting = GameObject.FindGameObjectWithTag("Player").GetComponent<AK_PlayerShooting>();
        shield.SetActive(false);
    }

    private void Update()
    {
        if(playerShooting.ammoCounter <= 0)
        {
            bullet.SetActive(false);
        }
        else if(playerShooting.ammoCounter > 0)
        {
            bullet.SetActive(true);
        }

        if(playerHealth.playerHP > 0)
        {
            heart.SetActive(true);

        }
        else
        {
            heart.SetActive(false);
        }

        if (playerHealth.playerHP > 1)
        {
            shield.SetActive(true);
        }
        else if(playerHealth.playerHP < 2)
        {
            shield.SetActive(false);
        }
    }
}
