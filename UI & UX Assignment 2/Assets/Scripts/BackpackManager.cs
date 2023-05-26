using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class BackpackManager : MonoBehaviour
{
    public TMP_Text CurrencyTxt;
    public int[,] backpackItem = new int[7, 7];
    public float currency;

    void Start()
    {
        CurrencyTxt.text = "Currency: $" + currency.ToString();

        //ID
        backpackItem[1, 1] = 1;
        backpackItem[1, 2] = 2;
        backpackItem[1, 3] = 3;
        backpackItem[1, 4] = 4;
        backpackItem[1, 5] = 5;
        backpackItem[1, 6] = 6;

        //Price
        backpackItem[2, 1] = 10;
        backpackItem[2, 2] = 20;
        backpackItem[2, 3] = 30;
        backpackItem[2, 4] = 25;
        backpackItem[2, 5] = 35;
        backpackItem[2, 6] = 40;
    }

   public void Sell()
    {
        currency +=0;
        CurrencyTxt.text = "Currency: $" + currency.ToString();
    }
}