using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigWaves : MonoBehaviour
{
    public int numberOfPoints = 100;
    public float amplitude = 1f;
    public float frequency = 1f;
    // Start is called before the first frame update
    void Start()
    {
        LineRenderer linerender = gameObject.AddComponent<LineRenderer>();
        linerender.positionCount = numberOfPoints;
        linerender.startWidth = 0.1f;
        linerender.endWidth = 0.1f;
        float angleStep = 2f * Mathf.PI / numberOfPoints;
        for (int i = 0; i < numberOfPoints; i++)
        {
            float x = angleStep * i;
            float y = amplitude * Mathf.Tan(frequency * x);
            linerender.SetPosition(i, new Vector3(x, y, 0f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
