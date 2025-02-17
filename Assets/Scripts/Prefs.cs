using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Prefs : MonoBehaviour
{
    GameController controller;
    public int TotalReward;
    public int TotalScore;
    public int HighScore;

    public Text TextReward;
    public Text TextScore;
    public Text Highscore;


    public void Start()
    {
        controller = FindAnyObjectByType<GameController>();
        if (controller == null)
        {
            return;
        }
        else
        {
            Load();
            TextReward.text = TotalReward.ToString();
            TextScore.text = TotalScore.ToString();
            Highscore.text = HighScore.ToString();
        }
      

    }
    public void Load()
    {
        TotalReward = PlayerPrefs.GetInt("reward",controller.TotalReward);
        TotalScore = PlayerPrefs.GetInt("score", controller.TotalScore);
        
    }

    //    if (controller == null)
    //    {
    //        return;
    //    }
    //    else
    //    {
    //        controller.Load();
    //        TotalReward = controller.TotalReward;
    //        TotalScore = controller.TotalScore;
    //        HighScore = controller.HighScore;

    //    }
    //    TextReward.text = TotalReward.ToString();
    //    TextScore.text = TotalScore.ToString();
    //    Highscore.text = HighScore.ToString();




    //}
}
