using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectAdd : MonoBehaviour
{
    public Vector3 vector1Start = new Vector3(0, 0, 0);
    public Vector3 vector1End = new Vector3(1, 1, 0);
    public Vector3 vector2Start = new Vector3(0, 0, 0);
    public Vector3 vector2End = new Vector3(2, -1, 0);
    public float lineWidth = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject vector1Object = new GameObject("Vector1");
        LineRenderer vector1Renderer = vector1Object.AddComponent<LineRenderer>();
        GameObject vector2Object = new GameObject("Vector2");
        LineRenderer vector2Renderer = vector2Object.AddComponent<LineRenderer>();
        //V1
        vector1Renderer.positionCount = 2;
        vector1Renderer.startWidth = lineWidth;
        vector1Renderer.endWidth = lineWidth;
        vector1Renderer.SetPosition(0, vector1Start);
        vector1Renderer.SetPosition(1, vector1End);
        //V2
        vector2Renderer.positionCount = 2;
        vector2Renderer.startWidth = lineWidth;
        vector2Renderer.endWidth = lineWidth;
        vector2Renderer.SetPosition(0, vector2Start);
        vector2Renderer.SetPosition(1, vector2End);

        Vector3 resultVector = vector1End - vector1Start + vector2End - vector2Start;
        GameObject resultObject = new GameObject("ResultObject");
        LineRenderer resultRenderer = resultObject.AddComponent<LineRenderer>();
        resultRenderer.positionCount = 2;
        resultRenderer.startWidth = lineWidth;
        resultRenderer.endWidth = lineWidth;
        resultRenderer.SetPosition(0, vector1Start);
        resultRenderer.SetPosition(1, resultVector);

        float magnitude = resultVector.magnitude;
        Debug.Log("Magnitude:" + magnitude);
        Debug.Log("Vector Format: V = " + resultVector.x + "i + " + resultVector.y + "j");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
