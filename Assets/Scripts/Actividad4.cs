using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad4 : MonoBehaviour
{
    private int edad;
    public int nacimiento = 2003;
    public int actualidad = 2022;
    public void Start()
    {
        edad = actualidad - nacimiento;
        Debug.Log($"Si estamos en el año {actualidad} y tu naciste el {nacimiento} tienes {edad} años");
    }
}
