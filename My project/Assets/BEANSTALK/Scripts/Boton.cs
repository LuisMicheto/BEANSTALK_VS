using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public bool presionado = false;

    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entra en el área del botón tiene la etiqueta correcta
        if (other.CompareTag("Player"))  // Asegúrate de que esta etiqueta coincida con la del objeto que cruza el botón
        {
            presionado = true;
            VerificarPuerta();
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Este método se llama cuando un objeto sale del área del botón
        // Puedes usarlo para hacer algo cuando el objeto deje de tocar el botón, si es necesario
    }

    void VerificarPuerta()
    {
        Boton[] botones = FindObjectsOfType<Boton>();

        // Verifica si todos los botones están presionados
        bool todosPresionados = true;
        foreach (Boton boton in botones)
        {
            if (!boton.presionado)
            {
                todosPresionados = false;
                break;
            }
        }

        // Si todos los botones están presionados, activa la puerta
        if (todosPresionados)
        {
            ActivarPuerta();
        }
    }

    void ActivarPuerta()
    {
        // Encuentra el objeto Puerta y llama a su función SubirPuerta()
        Puerta puerta = FindObjectOfType<Puerta>();
        if (puerta != null)
        {
            puerta.SubirPuerta();
        }
    }
}
