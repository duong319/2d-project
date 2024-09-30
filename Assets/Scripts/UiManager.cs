using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public GameObject PauseGameScreen;
    public GameObject EndGameScreen;
    

    public void showPauseGameScreen(bool isshow)
    {
        if (PauseGameScreen)
        {
            PauseGameScreen.SetActive(isshow);
        }

    }

    public void showEndGameScreen(bool isshow)
    {
        if (EndGameScreen)
        {
            EndGameScreen.SetActive(isshow);
        }
    }
  
}
