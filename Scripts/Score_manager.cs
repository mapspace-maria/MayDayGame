using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class Score_manager : MonoBehaviour
{

    public int score;
    public TextMeshProUGUI scoreText; // Assign the TextMeshPro component in the inspector

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Scoring: " + score.ToString() + " points";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
