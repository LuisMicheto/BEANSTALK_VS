using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicCameraTrigger : MonoBehaviour
{
    public Transform puntoCinematico; // Punto al que apuntará la cámara
    public Transform camaraEmpty; // Empty que representa la cámara durante la cinemática
    public float duracionCinematica = 5f; // Duración en segundos de la cinematica
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

        // Guardar la posición original de la cámara principal
        Vector3 posicionOriginal = mainCamera.transform.position;
        Quaternion rotacionOriginal = mainCamera.transform.rotation;

        // Cambiar a la cámara del empty durante la cinemática
        mainCamera.transform.position = camaraEmpty.position;
        mainCamera.transform.rotation = camaraEmpty.rotation;

        // Esperar la duración de la cinematica
        yield return new WaitForSeconds(duracionCinematica);

        // Volver a la posición original de la cámara principal
        mainCamera.transform.position = posicionOriginal;
        mainCamera.transform.rotation = rotacionOriginal;

        // Ocultar barras negras
        barrasNegras.SetActive(false);

    }
}
