using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallelogram : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 pointA = new Vector2(0, 0);
    public Vector2 pointB = new Vector2(5, 0);
    public Vector2 pointC = new Vector2(5, -5);
    public Vector2 pointD = new Vector2(0, -5);
    // Start is called before the first frame update
    void Start()
    {
        Debug.DrawLine(pointA, pointB, Color.green, Mathf.Infinity);
        Debug.DrawLine(pointB, pointC, Color.red, Mathf.Infinity);
        Debug.DrawLine(pointC, pointD, Color.blue, Mathf.Infinity);
        Debug.DrawLine(pointD, pointA, Color.blue, Mathf.Infinity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
