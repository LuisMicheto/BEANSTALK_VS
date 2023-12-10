using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterBeanstalk : MonoBehaviour
{
    // Nombre de la escena a cargar
    public string nombreEscenaACargar;

    // M�todo llamado cuando otro collider entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entr� tiene la etiqueta "Player" (aj�stalo seg�n tus necesidades)
        if (other.CompareTag("Player"))
        {
            CargarEscenaPorNombre(nombreEscenaACargar);
        }
    }

    // M�todo para cargar una escena por nombre
    private void CargarEscenaPorNombre(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
