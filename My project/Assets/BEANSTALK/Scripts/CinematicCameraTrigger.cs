using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicCameraTrigger : MonoBehaviour
{
    public Transform puntoCinematico; // Punto al que apuntar� la c�mara
    public Transform camaraEmpty; // Empty que representa la c�mara durante la cinem�tica
    public float duracionCinematica = 5f; // Duraci�n en segundos de la cinematica
    public GameObject barrasNegras; // Objeto que representa las barras negras
    public GameObject jugador; // Objeto que representa al jugador

    private Camera mainCamera;
    private Collider miCollider;

    void Start()
    {
        mainCamera = Camera.main;
        miCollider = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ActivarCinematica());
        }
    }

    IEnumerator ActivarCinematica()
    {
        // Desactivar collider
        miCollider.enabled = false;

        // Mostrar barras negras
        barrasNegras.SetActive(true);

        // Guardar la posici�n original de la c�mara principal
        Vector3 posicionOriginal = mainCamera.transform.position;
        Quaternion rotacionOriginal = mainCamera.transform.rotation;

        // Cambiar a la c�mara del empty durante la cinem�tica
        mainCamera.transform.position = camaraEmpty.position;
        mainCamera.transform.rotation = camaraEmpty.rotation;

        // Esperar la duraci�n de la cinematica
        yield return new WaitForSeconds(duracionCinematica);

        // Volver a la posici�n original de la c�mara principal
        mainCamera.transform.position = posicionOriginal;
        mainCamera.transform.rotation = rotacionOriginal;

        // Ocultar barras negras
        barrasNegras.SetActive(false);

    }
}
