using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ01 : MonoBehaviour
{
    public int val1;
    public int val2;

    //Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.
    void Start()
    {

        if (val1 == val2)
        {
            Debug.Log("Son iguales");
        }
        else
        {
            Debug.Log("No son iguales");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
