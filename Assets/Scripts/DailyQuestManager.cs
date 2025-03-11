using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

using static QuestProgress;

public class DailyQuestManager : MonoBehaviour
{
    public DailyQuestDatas dailyQuest;
    public DailyQuestHandle dailyQuestHandle;
    public Transform Ui;
    public QuestProgressDatabase questProgressDataBase;

    private Dictionary<int, DailyQuestHandle> uiHandlerDict;



    private void Start()
    {
        uiHandlerDict = new Dictionary<int, DailyQuestHandle>();
        LoadQuestProgress();

        foreach (var questData in dailyQuest.questDatas)
        {
            QuestProgress questProgress = questProgressDataBase.questProgresses.Find(questProgress => questProgress.id == questData.id);
            CreatQuest(questData, questProgress);
        }
    }

    private void LoadQuestProgress()
    {
        var defaultQuestProgressDatabaseString = JsonUtility.ToJson(questProgressDataBase);
        var questProgressDatabasevalue = PlayerPrefs.GetString(nameof(questProgressDataBase), defaultQuestProgressDatabaseString);

        questProgressDataBase = JsonUtility.FromJson<QuestProgressDatabase>(questProgressDatabasevalue);
    }

    private void CreatQuest(QuestDatas questDatas, QuestProgress questProgress)
    {
        var quest = Instantiate(dailyQuestHandle, Ui);
        quest.SetData(questDatas, questProgress);
        uiHandlerDict.Add(questProgress.id, quest);
        

    }

    private void OnApplicationQuit()
    {
        SaveProgress();
    }

    private void SaveProgress()
    {
        var questProgressDatabaseString = JsonUtility.ToJson(questProgressDataBase);
        PlayerPrefs.SetString(nameof(questProgressDataBase), questProgressDatabaseString);
        PlayerPrefs.Save();
    }

    public void UpdateQuestProgress(QuestProgress questProgress)
    {
        var questIndex = questProgressDataBase.questProgresses.FindIndex(progress => questProgress.id == progress.id);
        questProgressDataBase.questProgresses[questIndex] = questProgress;
        uiHandlerDict[questProgress.id].UpdateProgress(questProgress);
    }
}
