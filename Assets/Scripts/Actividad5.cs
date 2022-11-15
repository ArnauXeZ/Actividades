using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad5 : MonoBehaviour
{
    public int n1 = 9;
    public int n2 = 7;
    public void Start()
    {
        if (n1 > n2)
        {
            Debug.Log($"{n1} es el mas grane");
        }
        if (n2 > n1)
        {
            Debug.Log($"{n2} es el mas grane");
        }
    }
}
