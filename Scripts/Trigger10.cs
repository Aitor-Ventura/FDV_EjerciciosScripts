using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Trigger10 : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    
    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerController10.score += 1;
        Debug.Log("¡Cachín! Puntuación del jugador es ahora: " + PlayerController10.score);
        Debug.Log("He colisionado con: " + gameObject.name);
        _meshRenderer.materials[0].color = Color.red;
    }
}