using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TMPro.TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;

    bool gameOver = false;
    int score = 0;

    void Awake()
    {
        instance = this;
    }
    
    public void incrementScore()
    {
        if (!gameOver) 
        { 
            score++;

            scoreText.text = score.ToString();
        }
    }

    public void GameOver()
    {
        gameOver = true;

        GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning();

        gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
