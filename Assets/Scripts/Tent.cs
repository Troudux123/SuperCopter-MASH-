using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tent : MonoBehaviour
{
    public AudioSource CarCrashSource;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Saved.soldierSaved += InHelicopter.soldierInHelicopter;
            InHelicopter.soldierInHelicopter -= Saved.soldierSaved;
            InHelicopter.soldierInHelicopter = 0;
            CarCrashSource.Play();
        }

        
    }
}



