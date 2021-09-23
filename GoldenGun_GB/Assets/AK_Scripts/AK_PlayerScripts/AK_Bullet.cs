using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_Bullet : MonoBehaviour
{
    public float bulletSpeed;

    Transform bulletTransform;


    private void Start()
    {
        bulletTransform = gameObject.GetComponent<Transform>();

    }

    private void Update()
    {
        bulletTransform.position += Vector3.right * bulletSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            Destroy(gameObject);
        }
    }


}
