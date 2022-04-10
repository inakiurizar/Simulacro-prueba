using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ11 : MonoBehaviour
{
    //    Realizá un programa que resuelva el siguiente problema:
    //Deberá ingresarse por Inspector una fecha de compra(String en el siguiente formato:
    //YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del
    //producto comprado.Mostrá a modo de ticket, la información ingresada y el monto a pagar.
    //Modelo de Ticket:
    //Fecha de Compra: YYYYMMDD
    //Nombre del Comprador: xxxxx xxxxx
    //Producto solicitado: xxxxx
    //Cantidad solicitada: xx
    //Precio Unitario: $xxx
    //Total a Pagar: $xxxxx

    public string fechaCompra;
    public string nombreComprador;
    public string nombreProducto;
    public int cantidad;
    public float precio;

    void Start()
    {
        Debug.Log($"Fecha de compra: {fechaCompra}\n Nombre del comprador: {nombreComprador}");
        Debug.Log($"Producto solicitado: {nombreProducto}\n Cantidad solicitada: {cantidad}");
        Debug.Log($"Precio unitario: ${precio}\n Total a pagar: ${cantidad* precio}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
