using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void BotonStart()
    {
        SceneManager.LoadScene(2);
    }

    public void BotonEntrenamiento()
    {
        SceneManager.LoadScene(4);
    }

    public void BotonQuit()
    {
        Debug.Log("Salimos de la aplicacion");
        Application.Quit();
    }
}
