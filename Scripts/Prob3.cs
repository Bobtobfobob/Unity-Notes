using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Prob3 : MonoBehaviour
{
    public TMP_InputField Inp;
    // Start is called before the first frame update
    public void EvenOrOdd()
    {
        int inp = int.Parse(Inp.text);
        if (inp % 2 == 0)
        {
            Debug.Log("even");
        }
        else
        {
            Debug.Log("odd");
        }
    }
}
