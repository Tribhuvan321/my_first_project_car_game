using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Checkpoint : MonoBehaviour
{
    Timer timer;
    PlayerMovement playermove;
    // to be done at the start of the game
    private void Start()
    {
        timer = GameObject.FindObjectOfType<Timer>();
        playermove = GameObject.FindObjectOfType<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().name == "Car White")
        {
            Debug.Log("Trigger!");
            timer.currentTime = timer.startingTime;
        }
    }
    private void Update()
    {
        if(timer.currentTime <= 0)
        {
            playermove.Die();
        }
    }


}
