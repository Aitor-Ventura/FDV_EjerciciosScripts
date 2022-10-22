using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    public Vector3 goal;
    public float speed;

    private void Update()
    {
        Vector3 direction = goal - transform.position;
        transform.Translate(direction.normalized * (speed * Time.deltaTime));
    }
}