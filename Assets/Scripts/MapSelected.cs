using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelected : MonoBehaviour
{
    public GameObject Map;
    public GameObject SelectedMap;

    void Start()
    {

        GameObject selectedMap = MapSelect.selectedMap;

        if (selectedMap == null)
        {
            return;
        }
        else
        {
            Debug.Log("1");
            Map.SetActive(false);
            Instantiate(selectedMap, transform.position, Quaternion.identity);

        }





    }
}
