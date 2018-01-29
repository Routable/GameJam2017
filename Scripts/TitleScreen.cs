using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : MonoBehaviour {
    public Transform mainMenu, optionsMenu, creditsScreen;
    

    public void LoadScene(string name)
    {
        Application.LoadLevel(name);

    }

    public void QuitGame(string name)
    {
        Application.Quit();
    }

    public void OptionsMenu(bool clicked)
    {
        if (clicked)
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }else
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }


    }

    public void easyDiff(bool clicked)
    {
        GameOver.health = 5;
    }

    public void medDiff(bool clicked)
    {
        GameOver.health = 3;
    }

    public void hardDiff(bool clicked)
    {
        GameOver.health = 1;
    }

    public void creditsMenu(bool clicked)
    {
        if (clicked)
        {
            optionsMenu.gameObject.SetActive(clicked);
            creditsScreen.gameObject.SetActive(false);
        }
        else
        {
            optionsMenu.gameObject.SetActive(clicked);
            creditsScreen.gameObject.SetActive(true);
        }
    }
}
