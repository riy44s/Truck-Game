using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{

    public Debris debris;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Truck"))
        {
            debris.isCollideWithTarget = true;
            debris.isTruckOnTarget = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Truck"))
        {
            debris.isCollideWithTarget = false;
        }
    }
}
