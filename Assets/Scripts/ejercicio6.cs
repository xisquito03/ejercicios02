using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio6 : MonoBehaviour
{
    public float travelled;
    public float goal;
    private float result;
    
    
    

    private void Start()
    {
        result = goal - travelled;

        if (travelled >= goal)
        {
            Debug.Log($"Enhorabuena, has superado la meta a superar!");
        }
        else
        {
            Debug.Log($"A�n no has llegado a la meta, a�n te quedan {result} para llegar");
        }


    }

    
}
    