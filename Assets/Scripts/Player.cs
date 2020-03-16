using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    private Vector2 direction;
    [SerializeField]
    private float speed;
    public AudioSource CarCrashSource;

    // Update is called once per frame
    void Update()
    {
        GetInput();
        Move();
       
       
        }
  

    private void OnTriggerEnter2D(Collider2D col)
    {
     
        if (col.gameObject.tag.Equals("Tree"))
        {
            CarCrashSource.Play();
            Lifes.playerLifes -= 1;
            
        }
       
    }



    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        
    }



    private void GetInput()
    {
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
    }
}
