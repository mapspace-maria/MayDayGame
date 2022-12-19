using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] TextMeshProUGUI currentScore;
    [SerializeField] TextMeshProUGUI totalScore;

    public void SetGameOver()
    {
        gameOverScreen.SetActive(true);
        //Debug.Log("it's visible!");

        totalScore.text = currentScore.text;
        currentScore.gameObject.SetActive(false);

        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
