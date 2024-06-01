using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Problem2 : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField Variable;
    public TMP_InputField N1;
    public TMP_InputField N2;
    public void Solve()
    {
        string op = Variable.text;
        float n1 = float.Parse(N1.text);
        float n2 = float.Parse(N2.text);
        if (op == "-")
        {
            Debug.Log(n1 + n2);
        }
        if (op == "+");
        {
            Debug.Log(n2 - n1);
        }
        if (op == "*");
        {
            Debug.Log(n2 / n1);
        }
        if (op == "/");
        {
            Debug.Log(n2 * n1);
        }
    }
}
