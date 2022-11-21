using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5 : MonoBehaviour
{
    public int age = 19;


    private void Start()
    {


        if (age > 18) 
        {
            Debug.Log("You are legal of age, so you can come in");
        } else {
            Debug.Log("You are NOT legal of age, so you can not come in"); }

    }
}
