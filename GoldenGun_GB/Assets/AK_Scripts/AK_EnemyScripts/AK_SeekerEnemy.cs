using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_SeekerEnemy : MonoBehaviour
{
    public Transform target;

    public float homingTime;
    public bool homing;
    public float speed;
    public float rotateSpeed;

    Rigidbody2D enemyRB;

    public AK_SeekerAnimation seekerAnim;

    public SpriteRenderer spriteRend;

    private void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        homing = false;
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {

        if (!homing)
        {
            seekerAnim.ChangeAnimationState(seekerAnim.SEEKER_IDLE);
        }

        if(homing == true && homingTime > 0)
        {
            homingTime -= Time.deltaTime;

            Vector2 direction = ((Vector2)target.position - enemyRB.position).normalized;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotateToTarget = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotateToTarget, Time.deltaTime * rotateSpeed);

            enemyRB.velocity = new Vector2(direction.x * speed, direction.y * speed);

            seekerAnim.ChangeAnimationState(seekerAnim.SEEKER_ATTACK);

            if(direction.x > 0)
            {
                spriteRend.flipX = true;
            }
            else
            {
                spriteRend.flipX = false;
            }
        }
    }

    
}
