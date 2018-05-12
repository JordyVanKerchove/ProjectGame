using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuButtons : MonoBehaviour {

    public GameObject Startmenu;
    public GameObject OptionsMenu;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Opties()
    {
        Startmenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void Vorige()
    {
        Startmenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }

    
}
