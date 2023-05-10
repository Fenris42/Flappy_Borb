using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int Score;
    public Text scoreText;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Increase Score")]
    public void addScore(int ScoreToAdd)
    {
        Score = Score + ScoreToAdd;
        scoreText.text = Score.ToString();

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
