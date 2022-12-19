using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector_points : MonoBehaviour
{

    public GameObject player;
    public Score_manager score_manager; // Assign the Score_manager component in the inspector

    
    
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.gameObject == player)
        {

            // Increment the score by 1 and update the scoreText component
            score_manager.score++;
            score_manager.scoreText.text = "Scoring:" + score_manager.score.ToString() + " points";

            //Destroy object
            Destroy (gameObject);
        }

    }
}
