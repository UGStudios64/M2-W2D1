using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    [SerializeField] int straightNumber;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(straightNumber);
        Debug.Log(++straightNumber);
        Debug.Log(++straightNumber);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
