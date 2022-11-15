using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad3 : MonoBehaviour
{
    public int edad = 19;
    public string nombre = "Arnau";
    public void Start()
    {
        Debug.Log($"Hola {nombre}, tienes {edad} años?");
    }
}
