using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public List<Progress> quests;
    public float resetTime = 24f;
     QuestInteract QuestInteract;

    private float timer;

    private void Start()
    {
        QuestInteract = GetComponent<QuestInteract>();
        QuestInteract.LoadProgress();
    }

    private void Update()
    {

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            ResetQuests();
            timer = resetTime;
        }
    }

    public void UpdateQuestProgress(DailyQuestDatas quest, int amount)
    {

        Progress questProgress = quests.Find(q => q.questDatas == quest);

        if (questProgress != null)
        {
            questProgress.UpdateProgress(amount);
        }
    }

    public void ResetQuests()
    {
        foreach (var questProgress in quests)
        {
            questProgress.ResetProgress();
        }

        Debug.Log("All quests have been reset for the new day.");
    }


}
