using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Create_Cubes : MonoBehaviour
{
    public TMP_InputField Distance;
    public GameObject Cube;
    void Start()
    {
        StartCoroutine(Creating());
    }

    IEnumerator Creating()
    {
        while (true)
        {
            var cube = Instantiate(Cube, transform, false);
            yield return new WaitForSecondsRealtime(float.Parse(Distance.text));
        }
    }
}
