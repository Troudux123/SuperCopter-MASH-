using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    public AudioSource CarCrashSource;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player") && InHelicopter.soldierInHelicopter < 3)
        {
            InHelicopter.soldierInHelicopter += 1;
            CarCrashSource.Play();
            Destroy(gameObject);
        }
    }
}
