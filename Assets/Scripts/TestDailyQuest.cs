using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDailyQuest : MonoBehaviour
{
    public InputField idText;
    public InputField progressText;
    public DailyQuestManager questManager;

    public void UpdateQuest()
    {
        var id = int.Parse(idText.text);
        var progress = int.Parse(progressText.text);
        var questProgress = new QuestProgress(id, progress, false);
        questManager.UpdateQuestProgress(questProgress);
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
    }
}
