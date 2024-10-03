using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour
{
    public GameObject Dragon;
    public GameObject Dragonchoosed;

    void Start()
    {

        GameObject selectedCharacter = CharacterSelect.selectedCharacter;
        if (selectedCharacter == null)
        {
            return;
        }
        else
        {
            Dragon.SetActive(false);
            Instantiate(selectedCharacter, transform.position, Quaternion.identity);
        }


    }


}
