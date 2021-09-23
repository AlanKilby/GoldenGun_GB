using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_ShooterEnemy : MonoBehaviour
{
    SpriteRenderer enemySpriteRenderer;

    public float timeBetweenShots;
    float timeHolder;

    public bool isShootingRight;

    public GameObject enemyBulletRight;
    public GameObject enemyBulletLeft;

    public Transform shootingPointRight;
    public Transform shootingPointLeft;

    private void Start()
    {
        enemySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        if (!isShootingRight)
        {
            enemySpriteRenderer.flipX = true;
        }
    }

    private void Update()
    {
        if(timeHolder <= 0)
        {
            EnemyShooting(isShootingRight);
            timeHolder = timeBetweenShots;
        }
        else
        {
            timeHolder -= Time.deltaTime;
        }

    }

    public void EnemyShooting(bool _isLookingRight)
    {
        if (_isLookingRight)
        {
            Instantiate(enemyBulletRight, shootingPointRight.position, Quaternion.identity);
        }
        else if (!_isLookingRight)
        {
            Instantiate(enemyBulletLeft, shootingPointLeft.position, Quaternion.identity);
        }
    }
}
