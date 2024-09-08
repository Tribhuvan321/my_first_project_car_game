using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public float currentTime =0;
    public float startingTime = 30;

    public TMP_Text CountdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime <= 3)
        {
            CountdownText.color = Color.red;
        }
        if (currentTime > 0)
        {
            CountdownText.text = currentTime.ToString("0");
            currentTime -= 1 * Time.deltaTime;
        }

    }
    






}
