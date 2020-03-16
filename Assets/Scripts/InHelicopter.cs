using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InHelicopter : MonoBehaviour
{
    public static int soldierInHelicopter = 0;
    Text score;
    void Start()
    {
        score = GetComponent<Text>();
    }



    
    void Update()
    {
        score.text = "Soldier in Helicopter: " + soldierInHelicopter;
    }
}
