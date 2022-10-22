using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Script6 : MonoBehaviour
{
    public Vector3 goal;
    public float speed;
    public float accuracy = 0.01f;

    private void Start()
    {
        transform.LookAt(goal);
    }
    
    private void Update()
    {
        Vector3 direction = goal - transform.position;
        Debug.DrawRay(transform.position, direction, Color.red);
        if (direction.magnitude > accuracy)
        {
            transform.Translate(direction.normalized * (speed * Time.deltaTime), Space.World);
        }
    }
}