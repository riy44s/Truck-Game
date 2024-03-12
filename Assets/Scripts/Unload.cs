using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unload : MonoBehaviour
{

    public Debris debris;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Truck"))
        {
            debris.isCollideWithWasteCan = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Truck"))
        {
            debris.isCollideWithWasteCan = false;
        }
    }
}
