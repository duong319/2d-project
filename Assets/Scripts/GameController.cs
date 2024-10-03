using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
   
    public GameObject obstacle1;
    public GameObject obstacle2;
    public float spawntime;
    int Score;
    float Spawntime;
    bool isGameOver;
    int Reward;
    public Text Textpoint;
    public Text TextReward;
    UiManager Ui;
    [SerializeField] GameObject[] randomObject;




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
        float randYpos1 = Random.Range(-7f, -4f);
        float randYpos2 = Random.Range(4f, 6.5f);
        float randXpos1 = Random.Range(4f, 6f);
        float randXpos2 = Random.Range(4f, 6.5f);

        Vector2 spawnPos1 = new Vector2(randXpos1, randYpos1);
        Vector2 spawnPos2 = new Vector2(randXpos2, randYpos2);

        int i = Random.Range(0, randomObject.Length);
        Vector2 spawn1 = new Vector2(randXpos1, (randYpos1 / 2)+0.2f);
        Vector2 spawn2 = new Vector2(randXpos2, (randYpos2 / 2)-0.5f);



        if (obstacle1)
        {
            Instantiate(obstacle1, spawnPos1, Quaternion.identity);
            Instantiate(randomObject[i], spawn1, Quaternion.identity);

        }
        if (obstacle2)
        {
            Instantiate(obstacle2, spawnPos2, Quaternion.identity);

            Instantiate(randomObject[i], spawn2, Quaternion.identity);


        }



    }

    public void SetReward(int value)
    {
        Reward = value;
    }
    public int GetReward()
    {
        return Reward;
    }
    public void RewardIncrement()
    {
        Reward+=2;
        TextReward.text= Reward.ToString();

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
