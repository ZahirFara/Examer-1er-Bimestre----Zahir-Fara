﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vtv : MonoBehaviour
{
    public string patente;
    public int modelo;
    public int kilometrosRecorridos;
    public int vencimientoVTV;
    public int hcPPM;
    private int añoActual = 2025;

    // Start is called before the first frame update
    void Start()
    {

        if (patente == "")
        {
            Debug.Log("Error: La patente no puede estar vacía.");
            Debug.Log("VTV no aprobada");
            return;
        }

        if (modelo < 1900 || modelo > añoActual)
        {
            Debug.Log("Error: El modelo debe ser mayor a 1900 y menor o igual al año actual.");
            Debug.Log("VTV no aprobada");
            return;
        }

        if (kilometrosRecorridos < 0)
        {
            Debug.Log("Error: Los kilómetros recorridos no pueden ser negativos.");
            Debug.Log("VTV no aprobada");
            return;
        }

        if (vencimientoVTV <= modelo || vencimientoVTV >= añoActual)
        {
            Debug.Log("Error: El vencimiento de la VTV debe ser mayor que el año de fabricación y menor que el año actual.");
            Debug.Log("VTV no aprobada");
            return;
        }

        if (hcPPM < 5)
        {
            Debug.Log("Error: Los HC no pueden ser menores que 5.");
            Debug.Log("VTV no aprobada");
            return;
        }

        if (hcPPM > 100)
        {
            Debug.Log("Error: Los HC son demasiado altos. VTV desaprobada.");
            Debug.Log("VTV no aprobada");
            return;
        }

        float promedioKilometraje = (float)kilometrosRecorridos / (añoActual - modelo);

        if (promedioKilometraje < 10000)
        {
            Debug.Log("VTV otorgada por 2 años.");
        }
        else
        {
            Debug.Log("VTV otorgada por 1 año.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}