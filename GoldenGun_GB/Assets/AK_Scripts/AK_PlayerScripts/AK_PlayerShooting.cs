using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerShooting : MonoBehaviour
{
    public int ammoCounter;
    public int maxAmmo;

    public GameObject bulletRight;
    public GameObject bulletLeft;

    public Transform shootingPointRight;
    public Transform shootingPointLeft;

    public void PlayerShoot(bool _isLookingRight)
    {
        if(ammoCounter > 0)
        {
            if (_isLookingRight)
            {
                Instantiate(bulletRight, shootingPointRight.position, Quaternion.identity);
                ammoCounter--;
            }
            else if (!_isLookingRight)
            {
                Instantiate(bulletLeft, shootingPointLeft.position, Quaternion.identity);
                ammoCounter--;
            }

        }
    }
}
