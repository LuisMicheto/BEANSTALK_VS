using UnityEngine;
using TMPro;

public class ControlMensaje : MonoBehaviour
{
    public TextMeshProUGUI mensajeText;
    public float duracionMensaje = 3f;

    void Start()
    {
        mensajeText.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Obtén el mensaje desde el componente TextMeshProUGUI de la UI
            string mensaje = mensajeText.text;

            // Muestra el mensaje
            MostrarMensaje(mensaje);
        }
    }

    void MostrarMensaje(string mensaje)
    {
        mensajeText.text = mensaje;
        mensajeText.gameObject.SetActive(true);

        Invoke("OcultarMensaje", duracionMensaje);
    }

    void OcultarMensaje()
    {
        mensajeText.gameObject.SetActive(false);
    }
}