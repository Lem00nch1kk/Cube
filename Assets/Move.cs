using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Move : MonoBehaviour
{
    TMP_InputField Speed, Timee;
    void Start()
    {
        Speed = GameObject.FindGameObjectWithTag("Speed").GetComponent<TMP_InputField>();
        Timee = GameObject.FindGameObjectWithTag("Time").GetComponent<TMP_InputField>();
        StartCoroutine(Moving());
        StartCoroutine(Timer());
    }

    IEnumerator Moving()
    {
        Vector3 pos, newPos;
        while (true)
        {
            pos = transform.position;
            newPos = new Vector3(pos.y, pos.x, pos.z + 0.01f);
            transform.position = Vector3.MoveTowards(pos, newPos, Time.deltaTime * float.Parse(Speed.text));
            yield return null;
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSecondsRealtime(float.Parse(Timee.text));
        StopCoroutine(Moving());
        Destroy(gameObject);
    }
}
