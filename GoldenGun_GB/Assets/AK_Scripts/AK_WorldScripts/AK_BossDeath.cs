using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_BossDeath : MonoBehaviour
{
    public bool isPlayer;
    public GameObject bigTombstone;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            
            collision.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            Instantiate(bigTombstone, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if(collision.gameObject.layer == LayerMask.NameToLayer("Boss"))
        {
            
            collision.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            Instantiate(bigTombstone, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
