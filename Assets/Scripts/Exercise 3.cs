using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public int numero = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (numero % 2 == 0)
        {
            Debug.Log("IL NUMERO É PARI");
        }
        else
        {
            Debug.Log("IL MUMERO É DISPARI");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
