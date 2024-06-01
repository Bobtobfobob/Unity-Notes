using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RightTri : MonoBehaviour
{
    public TMP_InputField A;
    public TMP_InputField B;
    // Start is called before the first frame update
    public void Funky()
    {
        float a = float.Parse(A.text);
        float b = float.Parse(B.text);
        Debug.Log(Mathf.Sqrt((a * a) + (b * b)));
    }
}
