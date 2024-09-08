using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public PlayerMovement player;
    private int MaxBoostSpeed = 15;
    private float newFactor = 0.1f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Car White")
        {
            player.MaxSpeed = 50;
            player.factor = 1f;

        }
    }
}
