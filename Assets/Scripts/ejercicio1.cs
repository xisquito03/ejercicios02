using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    public float number;


    private void Start()
    {

        if (number > 0) {
            Debug.Log("El numero es mayor a 0");
        } else if (number < 0) { 
                Debug.Log("El numero es menor que zero");
        }
        else { 
                Debug.Log("El numero es 0");
        }
    }
}
