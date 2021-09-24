using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_GruntZoneLimit : MonoBehaviour
{
    public GameObject gruntGO;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AK_GruntMovement gruntMovement = gruntGO.GetComponent<AK_GruntMovement>();
        gruntMovement.TurnBack();
    }
}
