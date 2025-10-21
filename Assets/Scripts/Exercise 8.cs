using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise8 : MonoBehaviour
{
    [SerializeField] int grade;

    // Start is called before the first frame update
    void Start()
    {
        if(grade <= 4)
        {
            Debug.Log("F");
        }
        else if (grade == 5)
        {
            Debug.Log("D");
        }
        else if (grade == 6)
        {
            Debug.Log("C");
        }
        else if (grade <= 8)
        {
            Debug.Log("B");
        }
        else if (grade == 9)
        {
            Debug.Log("A");
        }
        else if (grade == 10)
        {
            Debug.Log("A+");
        }
        else
        {
            Debug.Log("YOU ARE OUT OF SCALE");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
