using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawVect : MonoBehaviour
{
    public float lineWidth = 0.1f;
    public int NumOfPoints = 4;
    public Vector3 startPos = new Vector3(1, 1, 0);
    public Vector3 endPos = new Vector3(-1, -1, 0);
    // Start is called before the first frame update
    void Start()
    {
        LineRenderer linerender = gameObject.AddComponent<LineRenderer>();
        linerender.positionCount = NumOfPoints;
        linerender.startWidth = lineWidth;
        linerender.endWidth = lineWidth;
        linerender.SetPosition(0, startPos);
        linerender.SetPosition(1, endPos);

        float magnitude = (endPos - startPos).magnitude;
        Debug.Log("Magnitude:" + magnitude);
        Debug.Log("Vector Format: V = " + (endPos.x - startPos.x) + "i + " + (endPos.y - startPos.y) + "j");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
