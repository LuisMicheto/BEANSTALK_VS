using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public bool presionado = false;

    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entra en el �rea del bot�n tiene la etiqueta correcta
        if (other.CompareTag("Player"))  // Aseg�rate de que esta etiqueta coincida con la del objeto que cruza el bot�n
        {
            presionado = true;
            VerificarPuerta();
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Este m�todo se llama cuando un objeto sale del �rea del bot�n
        // Puedes usarlo para hacer algo cuando el objeto deje de tocar el bot�n, si es necesario
    }

    void VerificarPuerta()
    {
        Boton[] botones = FindObjectsOfType<Boton>();

        // Verifica si todos los botones est�n presionados
        bool todosPresionados = true;
        foreach (Boton boton in botones)
        {
            if (!boton.presionado)
            {
                todosPresionados = false;
                break;
            }
        }

        // Si todos los botones est�n presionados, activa la puerta
        if (todosPresionados)
        {
            ActivarPuerta();
        }
    }

    void ActivarPuerta()
    {
        // Encuentra el objeto Puerta y llama a su funci�n SubirPuerta()
        Puerta puerta = FindObjectOfType<Puerta>();
        if (puerta != null)
        {
            puerta.SubirPuerta();
        }
    }
}
