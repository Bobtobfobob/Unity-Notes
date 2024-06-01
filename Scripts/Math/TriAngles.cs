using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriAngles : MonoBehaviour
{
    public Vector2 PointA = new Vector2(0, -4);
    public Vector2 PointB = new Vector2(4, -4);
    public Vector2 PointC = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        Vector2 sideAB = PointA - PointB;
        Vector2 sideBC = PointB - PointC;
        Vector2 sideCA = PointC - PointA;

        float LengthAB = sideAB.magnitude;
        float LengthBC = sideBC.magnitude;
        float LengthCA = sideCA.magnitude;
        float angleA = Mathf.Acos(Vector2.Dot(sideBC.normalized, -sideCA.normalized)) * Mathf.Rad2Deg;
        float angleB = Mathf.Acos(Vector2.Dot(sideBC.normalized, -sideAB.normalized)) * Mathf.Rad2Deg;
        float angleC = Mathf.Acos(Vector2.Dot(sideBC.normalized, -sideBC.normalized)) * Mathf.Rad2Deg;
        Debug.Log("Angle A: " + angleA);
        Debug.Log("Angle B: " + angleB);
        Debug.Log("Angle C: " + angleC);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
