using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterBeanstalk : MonoBehaviour
{
    // Nombre de la escena a cargar
    public string nombreEscenaACargar;

    // Método llamado cuando otro collider entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entró tiene la etiqueta "Player" (ajústalo según tus necesidades)
        if (other.CompareTag("Player"))
        {
            CargarEscenaPorNombre(nombreEscenaACargar);
        }
    }

    // Método para cargar una escena por nombre
    private void CargarEscenaPorNombre(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
