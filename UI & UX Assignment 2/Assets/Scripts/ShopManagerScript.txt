using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ShopManagerScript : MonoBehaviour
{
    public int[,] shopItems = new int[7, 7];
    public float currency;
    public TMP_Text CurrencyTxt;

    void Start()
    {
        CurrencyTxt.text = "Currency: $" + currency.ToString();

        //ID
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;

        //Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 25;
        shopItems[2, 5] = 35;
        shopItems[2, 6] = 40;
    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (currency >= shopItems[2, ButtonRef.GetComponent<ButtonScript>().ItemID])
        {
            currency -= shopItems[2, ButtonRef.GetComponent<ButtonScript>().ItemID];
            CurrencyTxt.text = "Currency: $" + currency.ToString();
        }
        
        
    }
}
