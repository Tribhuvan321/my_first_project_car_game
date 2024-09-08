using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinishPoint : MonoBehaviour
{

    GroundTile groundtile;

    private void Start()
    {
        groundtile = GameObject.FindObjectOfType<GroundTile>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "GroundTile0")
        {
            // Kill the player
            Destroy(gameObject);
        }
    }

    private void Update()
    {

    }
}