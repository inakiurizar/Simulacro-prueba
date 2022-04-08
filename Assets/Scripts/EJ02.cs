using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ02 : MonoBehaviour
{
    //Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
    //Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta

    public float precio1;
    public float precio2;
    public float precio3;
    public float montoDis;

    void Start()
    {
        float sumaPrecios = precio1 + precio2 + precio3;

        if(sumaPrecios > montoDis)
        {
            Debug.Log("La suma de los precios supera el monto disponible");
            Debug.Log($"Faltan {sumaPrecios -  montoDis}");
        } 
        else
        {
            Debug.Log("Con el monto disponible, se pueden comprar los tres productos");
            Debug.Log($"Sobran {montoDis - sumaPrecios}");
        }
        

    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
