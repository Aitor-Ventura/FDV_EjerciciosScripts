using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public Vector3 goal;
    public float speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, goal, speed * Time.deltaTime);
    }
}
