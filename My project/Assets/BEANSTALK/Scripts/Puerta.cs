using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public float velocidadSubida = 2.0f;
    public float alturaMaxima = 5.0f; // Cambia esto a la altura máxima que deseas

    private bool puertaSubiendo = false;
    private Vector3 posicionInicial;

    private void Start()
    {
        // Guarda la posición inicial de la puerta
        posicionInicial = transform.position;
    }

    private void Update()
    {
        // Verifica si la puerta debe subir
        if (puertaSubiendo)
        {
            SubirPuerta();
        }
    }

    public void IniciarSubidaPuerta()
    {
        // Llama a este método para iniciar la subida de la puerta
        puertaSubiendo = true;
    }

    public void SubirPuerta()
    {
        // Calcula la nueva posición gradualmente usando Lerp
        float nuevaAltura = Mathf.Lerp(transform.position.y, posicionInicial.y + alturaMaxima, velocidadSubida * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, nuevaAltura, transform.position.z);

        // Si la puerta alcanza la altura máxima, detén la subida
        if (transform.position.y >= posicionInicial.y + alturaMaxima)
        {
            puertaSubiendo = false;
        }
    }
}
