using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public string SceneToLoad;

    public void ChangeSceneGame()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
    public void ChangeSceneMenu()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
    public void ChangeSceneExit()
    {
        Application.Quit();
        {
            Debug.Log("Saliendo del juego");
        }

    }
}


