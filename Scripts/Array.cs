using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        bool exist = false;
        int search = 5;
        int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9 };
        for (int i = 0; i < Array.Length; i++)
        {
            Debug.Log(Array[i]);
        }
        for (int a = 0; a < Array.Length; a++)
        {
           if(search == Array[a])
            {
                exist = true;
            }
        }
        if (exist)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
