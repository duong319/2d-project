using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public float spawntime;
    int Score;
    float Spawntime;
    bool isGameOver;
    public Text Textpoint;
    UiManager Ui;
    public GameObject mermaid;
    public GameObject man;
    public GameObject donut;
    public GameObject normalchest;
    public GameObject bluechest;
   



    void Start()
    {
        
        Spawntime = 0;
        Ui = FindObjectOfType<UiManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            Spawntime = 0;
            Ui.showEndGameScreen(true);
            return;
        }
        Spawntime -= Time.deltaTime;

        if (Spawntime <= 0)
        {
            SpawnObstacle();
            Spawntime = spawntime;
        }
    }

    public void SpawnObstacle()
    {
        float randYpos1 = Random.Range(-7f, -2.85f);
        float randYpos2 = Random.Range(3f, 6.5f);
        float randXpos1 = Random.Range(4f, 6f);
        float randXpos2 = Random.Range(4f, 6.5f);

        Vector2 spawnPos1 = new Vector2(randXpos1, randYpos1);
        Vector2 spawnPos2 = new Vector2(randXpos2, randYpos2);


        if (obstacle1)
        {
            Instantiate(obstacle1, spawnPos1, Quaternion.identity);
        }
        if (obstacle2)
        {
            Instantiate(obstacle2, spawnPos2, Quaternion.identity);
        }
    }
    public void SetScore(int value)
    {
        Score = value;
    }
    public int GetScore()
    {
        return Score;
    }
    public void ScoreInCrement()
    {
        Score++;
        Textpoint.text = Score.ToString();


    }
    public bool IsGameOver()
    {

        return isGameOver;

    }
    public void SetGameOverState(bool state)
    {
        isGameOver = state;
        Time.timeScale = 0;
    }

    public void PauseGame()
    {

        Ui.showPauseGameScreen(true);
        Time.timeScale = 0;
        
    }
    public void Resume()
    {
        Ui.showPauseGameScreen(false);
       Time.timeScale = 1;
    }
}
