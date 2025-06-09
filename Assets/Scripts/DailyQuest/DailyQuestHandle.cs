using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DailyQuestHandle : MonoBehaviour
{
    public DailyQuestDatas QuestDatas;
    public Progress progress;


    public Text descriptionText;
    public Image questIcon;
    public Text currentProgress;
    public Text totalProgress;
    public Text rewardQuality;


    public void Start()
    {
        UpdateUi();
    }


    public void UpdateUi()
    {
        Debug.Log("UpdateUi");
        descriptionText.text = QuestDatas.description;
        questIcon.sprite = QuestDatas.questIcon;
        rewardQuality.text = QuestDatas.rewardQuality.ToString();
        totalProgress.text = QuestDatas.totalProgress.ToString();
        currentProgress.text =$"/{QuestDatas.currentProgress}";
    }
}
