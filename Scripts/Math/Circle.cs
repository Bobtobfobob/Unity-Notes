using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public int NumOfPoints = 400;
    // Start is called before the first frame update
    void Start()
    {
        LineRenderer linerender = gameObject.AddComponent<LineRenderer>();
        linerender.positionCount = NumOfPoints;
        linerender.startWidth = 0.1f;
        linerender.endWidth = 0.1f;
        float angleStep = 2f * Mathf.PI / NumOfPoints;
        for (int i = 0; i < NumOfPoints; i++)
        {
            float angle = angleStep * i;
            float x = Mathf.Cos(angle);
            float y = Mathf.Sin(angle);
            linerender.SetPosition(i, new Vector3(x, y, 0f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
