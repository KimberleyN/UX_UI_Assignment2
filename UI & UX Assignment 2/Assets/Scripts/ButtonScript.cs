using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    public int ItemID;
    public TMP_Text PriceTxt;
    public GameObject ShopManager;
    public GameObject Item;

    void Update()
    {
        PriceTxt.text = "Price: $" + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
    }

    public void WhenButtonClicked()
    {
        if (Item.activeInHierarchy == true)
            Item.SetActive(false);
        else
            Item.SetActive(true);
    }
}
