using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 5;
        int b = 7;
        int c = 9;
        int d = 3;

        Debug.Log("Addition: " + (a + b + c + d)); // Addition
        Debug.Log("Multiply: " + (a * b * c * d)); // Multiply
        Debug.Log("Median: " + ((a + b + c + d) / 4)); // Median

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
