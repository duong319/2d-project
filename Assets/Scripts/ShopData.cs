using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShopData
{
    public GameController Controller;
    private const string ALL_Data = "all_data";
    private static AllData allData;

    static ShopData()
    {
        allData = JsonUtility.FromJson<AllData>(PlayerPrefs.GetString(ALL_Data));

        if (allData == null)
        {
            return;
        }
        else
        {
            allData = new AllData();
            
            SaveData();
        }

    }

    private static void SaveData()
    {
        var data = JsonUtility.ToJson(allData);
        PlayerPrefs.SetString(ALL_Data, data);
    }

    public static bool IsOwnedDragonWithId(int id)
    {
        return allData.IsOwnedDragonWithId(id);
    }

    public static void AddDragon(int id)
    {
        allData.AddDragon(id);
        SaveData();
    }



  
    public static bool isEnoughReward(int coin,int cost)
    {
        return allData.isEnoughReward(coin,cost);
       
    }
}

public class AllData
{
    public GameController Controller;
    public List<int> dragonList = new List<int>();

    

  

    public bool IsOwnedDragonWithId(int id)
    {
        return dragonList.Contains(id);
    }

    public void AddDragon(int id)
    {
        if (IsOwnedDragonWithId(id)) return;
        dragonList.Add(id);
    }

  
    public bool isEnoughReward(int coin, int cost)
    {
        return coin >= cost;
    }

    
    }