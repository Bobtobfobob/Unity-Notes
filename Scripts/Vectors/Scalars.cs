using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalars : MonoBehaviour
{
    public Vector3 vector = new Vector3(1, 1, 0);
    public float scalar = 40f;
    public float lineWidth = 0.1f;
    public int NumOfPoints = 2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject vectorObject = new GameObject("Vector");
        LineRenderer linerender = vectorObject.AddComponent<LineRenderer>();
        linerender.positionCount = NumOfPoints;
        linerender.startWidth = lineWidth;
        linerender.endWidth = lineWidth;
        linerender.SetPosition(0, Vector3.zero);
        linerender.SetPosition(1, vector);

        Vector3 scaledVector = vector * scalar;
        GameObject scaledVectorObject = new GameObject("ScaledVector");
        LineRenderer scaledVectorRender = scaledVectorObject.AddComponent<LineRenderer>();
        linerender.positionCount = NumOfPoints;
        linerender.startWidth = lineWidth;
        linerender.endWidth = lineWidth;
        linerender.SetPosition(0, Vector3.zero);
        linerender.SetPosition(1, scaledVector);

        float magnitude = scaledVector.magnitude;
        Debug.Log("Magnitude:" + magnitude);
        Debug.Log("Vector Format: V = " +scaledVector.x + "i + " + scaledVector.y + "j");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
