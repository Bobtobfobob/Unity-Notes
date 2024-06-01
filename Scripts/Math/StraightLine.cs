using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightLine : MonoBehaviour
{
    public int NumOfPoints = 100;
    public float startPoint = -5f;
    public float endPoint = 5;
    public float slope = 100f;
    public float yIntercept = 0f;
    // Start is called before the first frame update
    void Start()
    {
        LineRenderer linerender = gameObject.AddComponent<LineRenderer>();
        linerender.positionCount = NumOfPoints;
        linerender.startWidth = 1;
        linerender.endWidth = -100;

        float step = (endPoint - startPoint) / (NumOfPoints - 1);
        for(int i = 0; i < NumOfPoints; i++)
        {
            float x = startPoint + step * i;
            float y = calculateLineY(x);
            linerender.SetPosition(i, new Vector3(x, y, 0f));
        }
        
    }
    float calculateLineY(float x)
    {
        return (slope * x + yIntercept);
    }
}
