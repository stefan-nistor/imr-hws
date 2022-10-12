using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    private int counter = 0;
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Target")
        {
            counter++;
            Console.WriteLine($"Target Hit! Count: {counter}");
        }   
    }
}
