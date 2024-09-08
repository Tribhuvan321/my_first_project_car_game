using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    private Transform initialPos;
    private Transform finalPos;
    float Difference;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        finalPos = gameObject.GetComponent<Transform>();
        Difference = Vector3.Distance(finalPos.position,initialPos.position);

        if (Difference == 1)
        {
            GameManager.inst.IncrementScore();
        }
    }
}

