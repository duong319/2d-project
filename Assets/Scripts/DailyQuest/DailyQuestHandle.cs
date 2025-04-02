using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DailyQuestHandle : MonoBehaviour
{
    public QuestDatas QuestDatas;
    public QuestProgress questProgress;

    public Text descriptionText;
    public Image questIcon;
    public Text currentProgress;
    public Text totalProgress;
    public Text rewardQuality;


    public void Update()
    {
        UpdateProgress(questProgress);
    }
    public void SetData(QuestDatas QuestDatas, QuestProgress questProgress)
    {
        Debug.Log("Set");
        this.QuestDatas = QuestDatas;
        this.questProgress = questProgress;
        UpdateUi();
    }

    public void UpdateProgress(QuestProgress questProgress)
    {
        this.questProgress = questProgress;
        UpdateUi();
    }

    public void UpdateUi()
    {
        Debug.Log("UpdateUi");
        descriptionText.text = QuestDatas.description;
        questIcon.sprite = QuestDatas.questIcon;
        rewardQuality.text = QuestDatas.rewardQuality.ToString();

        currentProgress.text = $"{questProgress.progress}";
        totalProgress.text = QuestDatas.taskCount.ToString();

    }
}
