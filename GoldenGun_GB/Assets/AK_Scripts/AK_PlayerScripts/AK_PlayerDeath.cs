using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AK_PlayerDeath : MonoBehaviour
{

    public GameObject tombstone;
    

    public void PlayerDeath()
    {
        Instantiate(tombstone, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
