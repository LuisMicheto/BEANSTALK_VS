using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public Slider volumenSlider; // Asocia un Slider para ajustar el volumen en el Inspector de Unity

    private void Start()
    {
        // Recupera el valor actual del volumen y actualiza el Slider
        volumenSlider.value = AudioListener.volume;
    }

    // Método para ajustar el volumen
    public void OnClickVolumen()
    {
        // Ajusta el volumen del juego según el valor del Slider
        AudioListener.volume = volumenSlider.value;
    }

    // Método para volver al menú principal
    public void OnClickVolver()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClickOptions()
    {
        SceneManager.LoadScene("Options");
    }
}