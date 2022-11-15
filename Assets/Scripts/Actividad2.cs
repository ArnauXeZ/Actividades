using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad2 : MonoBehaviour
{
    public string nombre = "Arnau";
    public string ciudad = "Mallorca";
    public void Start()
    {
        Debug.Log($"Hola {nombre} bienvenido a {ciudad}");
    }
}
