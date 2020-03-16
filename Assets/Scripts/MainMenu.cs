﻿    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Load classic mode
    public void Playgame()
    {
        SceneManager.LoadScene("GameScene");
    }
   
    //Quit the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
