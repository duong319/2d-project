using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ButtonManager : MonoBehaviour
{
    public void ShowMainMenu()
    {
        SceneManager.LoadScene("main menu");
        Time.timeScale = 1;
    }

    public void ShowShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void ShowMap()
    {
        SceneManager.LoadScene("Map");
    }

    public void ShowSetting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void ChooseDragon()
    {
        SceneManager.LoadScene("ChooseDragon");
    }

    public void TapToPlay()
    {
        SceneManager.LoadScene("Game Play");
    }

  

}
