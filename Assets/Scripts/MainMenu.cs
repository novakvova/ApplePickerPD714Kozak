using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("_Scene_1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void StartDemolition()
    {
        SceneManager.LoadScene("_Scene_Dem");
    }

}
