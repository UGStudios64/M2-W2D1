using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    [SerializeField] int number1;
    [SerializeField] int number2;

    // Start is called before the first frame update
    void Start()
    {
        if (number1 < number2)
        {
            Debug.Log(number1 + " IT'S THE SMALLEST");
        }
        else if (number1 < number2)
        {
            Debug.Log(number2 + " IT'S THE SMALLEST");
        }
        else
        {
            Debug.Log("THEY ARE THE SAME NUMBER!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
