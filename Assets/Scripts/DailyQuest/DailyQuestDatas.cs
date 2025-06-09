using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Quest", menuName = "ScriptableObject/Data", order = 1)]

public class DailyQuestDatas : ScriptableObject
{
    public string description;
    public int rewardQuality;
    public Sprite questIcon;
    public int totalProgress;
    public int currentProgress;
    public bool completed;
}

