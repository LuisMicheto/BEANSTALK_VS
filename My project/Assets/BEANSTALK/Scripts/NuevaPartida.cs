using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NuevaPartida : MonoBehaviour
{
    public void OnClickNuevaPartida()
    {
        SceneManager.LoadScene("VerticalSlice");
    }


    public void OnClickSalir()
    {
        Application.Quit();
    }
}
