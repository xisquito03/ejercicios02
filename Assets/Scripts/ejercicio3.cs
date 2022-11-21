using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3 : MonoBehaviour
{
    public int number;

        private void Start()
    {
        if (number % 5 == 0)
        {
            Debug.Log("Este número es divisible por 5");
        }
        else
        {
            Debug.Log("Este número no es divisible por 5");
        }
    }
}
