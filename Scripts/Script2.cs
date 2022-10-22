using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public Vector3 goal;
    public float speed;

    private void Update()
    {
        transform.Translate(goal.normalized * (speed * Time.deltaTime));
    }
}