using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour
{
    public GameObject Dragon;
    public GameObject chooseDragon;

    void Start()
    {

        GameObject selectedCharactermenu = CharacterSelect.selectedCharactermenu;

        if (selectedCharactermenu == null)
        {
            return;
        }
        else
        {
            Dragon.SetActive(false);
            Instantiate(selectedCharactermenu, transform.position, Quaternion.identity);
        }

       
       


    }


}
