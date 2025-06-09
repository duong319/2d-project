using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Progress : MonoBehaviour
{

    public DailyQuestDatas questDatas;
    public bool isCompleted;
    public int currentProgress;
    public int totalProgress;

    public Progress(DailyQuestDatas quest)
    {
        this.questDatas = quest;
        isCompleted = false;
        currentProgress = 0;
        totalProgress = questDatas.totalProgress;
    }



    public void UpdateProgress(int amount)
    {
        if (isCompleted) return;

        currentProgress += amount;


        if (currentProgress >= questDatas.totalProgress)
        {
            currentProgress = questDatas.totalProgress;
            isCompleted = true;
            Debug.Log("Quest Completed: " + questDatas.totalProgress);


        }
    }

    public void ResetProgress()
    {
        currentProgress = 0;
        isCompleted = false;
    }

   
}
