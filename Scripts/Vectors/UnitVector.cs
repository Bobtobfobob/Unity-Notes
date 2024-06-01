using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitVector : MonoBehaviour
{
    public Vector3 vector = new Vector3(1, 1, 0);
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
        Vector3 normVector = vector.normalized;

        GameObject NormVectorObject = new GameObject("NormVector");
        LineRenderer NormLineRender = NormVectorObject.AddComponent<LineRenderer>();
        NormLineRender.positionCount = NumOfPoints;
        NormLineRender.startWidth = lineWidth;
        NormLineRender.endWidth = lineWidth;
        NormLineRender.SetPosition(0, Vector3.zero);
        NormLineRender.SetPosition(1, normVector);

        float magnitude = normVector.magnitude;
        Debug.Log("Magnitude:" + magnitude);
        Debug.Log("Vector Format: V = " + normVector.x + "i + " + normVector.y + "j");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
