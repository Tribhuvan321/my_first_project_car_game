using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invincibility : MonoBehaviour
{
    public GameObject[] player;
    public GameObject selfDestruct;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Car White")
        {
            Debug.Log("Trigger should turn on");
            for (int i = 0; i < 6; i++)
            {
                player[i].GetComponent<Collider>().isTrigger = true;
            }
            Destroy(selfDestruct);
            
        }
        
    }
    
}
