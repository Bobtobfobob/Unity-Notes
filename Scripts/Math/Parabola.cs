using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parabola : MonoBehaviour
{
    public int NumOfPoints = 100;
    public float startPoint = -5f;
    public float endPoint = 5;
    public float a = 1f;
    public float b = 0f;
    public float c = 5f;


    // Start is called before the first frame update
    void Start()
    {
        LineRenderer linerender = gameObject.AddComponent<LineRenderer>();
        linerender.positionCount = NumOfPoints;
        linerender.startWidth = 0.1f;
        linerender.endWidth = 0.1f;
        float step = (endPoint - startPoint) / (NumOfPoints - 1);
        for (int i = 0; i < NumOfPoints; i++)
        {
            float x = startPoint + step * i;
            float y = calculateParaY(x);
            linerender.SetPosition(i, new Vector3(x, y, 0f));
        }
    }

    // Update is called once per frame
    float calculateParaY(float x) 
    {
        return a * x * x + b * x + c;
    }
}
