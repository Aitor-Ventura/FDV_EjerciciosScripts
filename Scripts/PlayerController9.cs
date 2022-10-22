using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerController9 : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    
    private void Update()
    {
        Movement();
        Rotation();
    }

    private void Rotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rotate(transform.position, -Vector3.up, rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Rotate(transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    private void Rotate(Vector3 vector, Vector3 sign, float rotateSpeed)
    {
        transform.RotateAround(vector, sign, rotateSpeed);
    }
    
    private void Movement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IncreaseSpeed();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Move(Vector3.left, (speed * Time.deltaTime));
        } 
        else if (Input.GetKey(KeyCode.D))
        {
            Move(Vector3.right, (speed * Time.deltaTime));
        } 
        else if (Input.GetKey(KeyCode.W))
        {
            Move(Vector3.forward, (speed * Time.deltaTime));
        } 
        else if (Input.GetKey(KeyCode.S))
        {
            Move(Vector3.back, (speed * Time.deltaTime));
        }
    }

    private void Move(Vector3 vector, float moveSpeed)
    {
        transform.Translate(vector * moveSpeed);
    }

    private void IncreaseSpeed()
    {
        speed *= 2;
    }
}