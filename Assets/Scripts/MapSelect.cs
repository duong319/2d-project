using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class MapSelect : MonoBehaviour
{
    private int Index;
    [SerializeField] GameObject[] Maps;
    [SerializeField] GameObject[] icons;
    [SerializeField] GameObject[] mapPrefabs;
   
    public static GameObject selectedMap;
   

    void Start()
    {
        Index = 0;



        SelectMap();
    }

    public void PrevBtnClick()
    {
        if (Index > 0)
        {
            Index--;
        }
        SelectMap();
    }
    public void NextBtnClick()
    {
        if (Index < Maps.Length)
        {
            Index++;
        }
        SelectMap();

    }

    public void SelectMap()
    {
        for (int i = 0; i < Maps.Length; i++)
        {


            if (i == Index)
            {
                Maps[i].SetActive(true);
                icons[i].GetComponent<Image>().color = Color.white;
                selectedMap = mapPrefabs[i];
            }
            else
            {
                Maps[i].SetActive(false);
                icons[i].GetComponent<Image>().color = Color.black;
            }
        }
    }
    }
