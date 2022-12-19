using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class startGameButton : MonoBehaviour
{
    public GameObject startMenuPanel;

    public void OnButtonClicked()
    {
        startMenuPanel.SetActive(false);

        // Start the game here, by loading the next scene or activating other game objects
        SceneManager.LoadScene(1);
    }
}
