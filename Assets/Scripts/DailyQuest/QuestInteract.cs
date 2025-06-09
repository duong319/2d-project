using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestInteract : MonoBehaviour
{
    public DailyQuestDatas quest;
    public QuestManager QuestManager;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            QuestManager questManager = FindObjectOfType<QuestManager>();
            if (questManager != null)
            {
                questManager.UpdateQuestProgress(quest, 1);
            }
        }
    }



    public void SaveProgress()
    {
        foreach (var questProgress in QuestManager.quests)
        {
            PlayerPrefs.SetInt(questProgress.questDatas.description, questProgress.currentProgress);
            PlayerPrefs.SetInt(questProgress.questDatas.description, questProgress.isCompleted ? 1 : 0);
        }
        PlayerPrefs.Save();
    }

    public void LoadProgress()
    {
        foreach (var questProgress in QuestManager.quests)
        {
            int progress = PlayerPrefs.GetInt(questProgress.questDatas.description, 0);
            bool isCompleted = PlayerPrefs.GetInt(questProgress.questDatas.description, 0) == 1;

            questProgress.currentProgress = progress;
            questProgress.isCompleted = isCompleted;
        }
    }



}
