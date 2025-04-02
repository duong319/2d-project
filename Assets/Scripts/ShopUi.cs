using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUi : MonoBehaviour
{
    private GameController controller;
    public int id;
    public int cost;
    

    public Text costText;
    public Button purchaseBtn;
    public int coin;



    private void Awake()
    {

        controller = FindObjectOfType<GameController>();
        if (controller == null)
        {
            Debug.Log("null");
            return;
        }
        
        purchaseBtn.onClick.AddListener(Onpurchase);
        SetData(id);
        controller.Load();
        coin = controller.TotalReward;



    }

    private void UpdateUi()
    {
        if (id == 0)
        {
            return;
        }
        else
        {

            var isOwned = ShopData.IsOwnedDragonWithId(id);
            if (isOwned)
            {
                purchaseBtn.enabled = false;
                costText.text = "Owned";
            }
            else
            {
                purchaseBtn.enabled = true;
                costText.text = cost.ToString();
            }
        }
        }

    public void SetData(int id)
    {
        this.id = id;
        UpdateUi();
    }

    private void Onpurchase()
    {
        if (controller == null)
        {
            return;
        }
        var canPurchase = ShopData.isEnoughReward(controller.TotalReward,cost);
        if (canPurchase == true)
        {
            Debug.Log("get");
            ShopData.AddDragon(id);

            controller.GetDragon(cost);
            
            UpdateUi();
        }
        else
        {
            Debug.Log("not enough money");
        }
        

    }
}
