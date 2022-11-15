using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad1 : MonoBehaviour
{
    

      //float decimnales                                                       //esta la puse private pq no interesa que toquen el resultado
      public float variableA = 54; public float variableB = 78; public float variableC = 12; private float Suma;

      public void Start()
      {
            Suma = (variableA + variableB + variableC);
            Debug.Log(Suma);
      }
}
//media hora pa hacer esto y despues de analizarlo me doy cuenta de lo facil que es y de lo tonto que soy xddd


