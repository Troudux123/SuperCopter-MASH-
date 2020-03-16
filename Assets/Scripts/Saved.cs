using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Saved : MonoBehaviour
{
    public static int soldierSaved = 0;
    Text score;
    void Start()
    {
        score = GetComponent<Text>();
    }


    void Update()
    {
        score.text = "Soldier Saved: " + soldierSaved;
        winCon();
    }

    private void winCon()
    {
        if(soldierSaved == 4)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }

}
