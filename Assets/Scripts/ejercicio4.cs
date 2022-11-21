using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4 : MonoBehaviour
{
    public float bases;
    public float height;
    private float area;

    private void Start()
    {
        area = bases * height / 2;

        if(bases>0 && height > 0)
        {
            Debug.Log($"El area es {area} teniendo en cuenta que altura es {height} y la base es {bases} ");
        }
        else
        {
            Debug.Log("El area no es calculalable");
        }
    }
}
