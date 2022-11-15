using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad6 : MonoBehaviour
{
    public int dia = 1;
    public void Start()
    {

        if (dia > 7)
        {
            Debug.Log($"Este dia no existe");
        }

        else if (dia>5)
                
        {
            Debug.Log($"Vamonos es dia {dia} fin de semana fiestaaa!");
        }


        if (dia<5)
        {
            Debug.Log($"Hoy es dia {dia} toca classe");
        }

        
        
        
    }
}
