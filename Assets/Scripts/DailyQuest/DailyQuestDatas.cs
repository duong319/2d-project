using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Quest", menuName = "ScriptableObject/Data", order = 1)]

public class DailyQuestDatas : ScriptableObject
{
    public List<QuestDatas> questDatas;
}

[Serializable]
public class QuestProgress
{
    public int id;
    public int progress;
    public bool hasClaimed;
    private bool v;

    public QuestProgress(int id, int progress, bool v)
    {
        this.id = id;
        this.progress = progress;
        this.v = v;
    }
  
}
[Serializable]
public class QuestProgressDatabase
{
    public List<QuestProgress> questProgresses;
}