using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTria : MonoBehaviour
{
    public Vector2 pointA = new Vector2(0, 5);
    public Vector2 pointB = new Vector2(3, 1);
    public Vector2 pointC = new Vector2(3, 5);
    // Start is called before the first frame update
    void Start()
    {
        Debug.DrawLine(pointA, pointB, Color.green, Mathf.Infinity);
        Debug.DrawLine(pointB, pointC, Color.red, Mathf.Infinity);
        Debug.DrawLine(pointC, pointA, Color.blue, Mathf.Infinity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
