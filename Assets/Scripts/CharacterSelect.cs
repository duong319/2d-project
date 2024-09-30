using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    private int Index;
    [SerializeField] GameObject[] characters;
    [SerializeField] GameObject[] icons;
    [SerializeField] TextMeshProUGUI characterName;
    [SerializeField] GameObject[] characterPrefabs;
    public static GameObject selectedCharacter;

    void Start()
    {
        Index = 0;
        SelectCharacter();
    }

    public void PrevBtnClick()
    {
        if (Index > 0)
        {
            Index--;
        }
        SelectCharacter();
    }
    public void NextBtnClick()
    {
        if (Index < characters.Length)
        {
            Index++;
        }
        SelectCharacter();

    }

    private void SelectCharacter()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (i == Index)
            {
                characters[i].SetActive(true);
                characters[i].GetComponent<Animator>().enabled = true;
                icons[i].GetComponent<SpriteRenderer>().color = Color.white;
                selectedCharacter = characterPrefabs[i];
                characterName.text = characterPrefabs[i].name;
            }
            else
            {
                characters[i].SetActive(false);
                characters[i].GetComponent<Animator>().enabled = false;
                icons[i].GetComponent<SpriteRenderer>().color = Color.black;
            }
        }
    }

}
