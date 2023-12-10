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

    // M�todo para ajustar el volumen
    public void OnClickVolumen()
    {
        // Ajusta el volumen del juego seg�n el valor del Slider
        AudioListener.volume = volumenSlider.value;
    }

    // M�todo para volver al men� principal
    public void OnClickVolver()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClickOptions()
    {
        SceneManager.LoadScene("Options");
    }
}