using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void CambiarEscenaClick(string sceneName)
    {
        Debug.Log("Cambiando escena: " + sceneName);
        StartCoroutine(retrasoEscena(sceneName));
    }

    public void SalirJuego()
    {
        Debug.Log("Saliendo del juego");
        Application.Quit();
    }

    IEnumerator retrasoEscena(string sceneName)
    {
        //duracion antes de cambiar (1s)
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene(sceneName);
    }
}
