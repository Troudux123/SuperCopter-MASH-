using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lifes : MonoBehaviour
{
    public static int playerLifes = 3;
    Text score;
    void Start()
    {
        score = GetComponent<Text>();
    }


    void Update()
    {
        score.text = "Lifes: " + playerLifes;
        loseCon();
    }

    private void loseCon()
    {
        if(playerLifes == 0)
        {
            SceneManager.LoadScene("LoseScreen");
        }
        
    }

   

}