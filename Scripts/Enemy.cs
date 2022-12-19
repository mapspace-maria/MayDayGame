using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    
    [SerializeField] private float speed;
    [SerializeField] private GameObject player;
    private Vector2 position;

    [SerializeField] GameOverManager gameOverManager;


    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the enemy collided with the player
        if(collision.transform.gameObject == player)
        {
            gameOverManager.SetGameOver();
            Debug.Log("Game over!");
            
            // Destroy the player
            //Destroy(gameObject);

            // Stop the game
            Application.Quit();
        }
    }
}
