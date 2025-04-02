using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DailyQuestManager : MonoBehaviour
{
    public DailyQuestDatas QuestDatas;
    public DailyQuestHandle QuestHandle;
    public Transform Ui;
    public QuestProgressDatabase questProgressDataBase;


    public void Start()
    {

        LoadQuestProgress();
        if (QuestDatas == null || QuestDatas.questDatas == null || questProgressDataBase == null || questProgressDataBase.questProgresses == null)
        {
            return;
        }

        foreach (var questData in QuestDatas.questDatas)
        {
            QuestProgress questProgress = questProgressDataBase.questProgresses.Find(questProgress => questProgress.id == questData.id);
           
                CreatQuest(questData, questProgress);
            
        }
    }



    private void LoadQuestProgress()
    {
        var defaultQuestProgressDatabaseString = JsonUtility.ToJson(questProgressDataBase);
        var questProgressDatabaseValue = PlayerPrefs.GetString(nameof(questProgressDataBase), defaultQuestProgressDatabaseString);

        questProgressDataBase = JsonUtility.FromJson<QuestProgressDatabase>(questProgressDatabaseValue);
    }

    private void CreatQuest(QuestDatas questData, QuestProgress questProgress)
    {
        var quest = Instantiate(QuestHandle, Ui);
        quest.SetData(questData, questProgress);

    }

    public void SaveQuestProgress()
    {
        var questProgressDatabaseString = JsonUtility.ToJson(questProgressDataBase);
        PlayerPrefs.SetString(nameof(questProgressDataBase), questProgressDatabaseString);
        PlayerPrefs.Save();
    }

    private void OnApplicationQuit()
    {
        SaveQuestProgress();
    }

}
