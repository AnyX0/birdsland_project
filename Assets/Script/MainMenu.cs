using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void MainMenuu()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("MainMenu");
    }

    public void Animal()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("Animal");
    }

    public void Karnivora()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("Karnivora");
    }

    public void Herbivora()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("Herbivora");
    }

    public void Omnivora()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("Omnivora");
    }

    public void ARCamera()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("ARCamera");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
