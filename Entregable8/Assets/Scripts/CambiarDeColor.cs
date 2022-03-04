using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarDeColor : MonoBehaviour
{
    public Material[] material;
    public int x;
    Renderer rend;
    
    void Start()
    {
        x = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[x];
    }

   
    void Update()
    {
        rend.sharedMaterial = material[x];
    }

    public void SiguienteColor()
    {
        if (x < 2)
        {
            x ++;
        }
        else
        {
            x = 0;
        }
    }
}
// ESTE SCRIPT SE USA PARA CAMBIAR LOS MATERIALES DEL CUBO, ESTE SCRIPT EN CONCRETO CAMBIA LOS MATERIALES
// EN EL ORDEN QUE SE LO ESTABLEZCAS DENTRO DEL INSPECTOR. PUEDES AGREGARLES TANTOS MATERIALES COMO QUIERAS
