using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour
{


    void Start()
    {

        GameObject selectedCharacter = CharacterSelect.selectedCharacter;
        if (selectedCharacter == null)
        {
            return;
        }
        else
        {
            Instantiate(selectedCharacter, transform.position, Quaternion.identity);
        }


    }


}
