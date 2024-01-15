using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Correcting : MonoBehaviour
{
    public void Correct()
    {
        var line = GetComponent<TMP_InputField>().text; 
        if ((line[line.Length - 1] < '0') | (line[line.Length - 1] > '9') )
            GetComponent<TMP_InputField>().text = line.Split(line[line.Length - 1])[0];

    }
}
