using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellButtonScript : MonoBehaviour
{
    public int backpackItemID;
    public GameObject BackpackManagerScript;
    public GameObject backpackItem;

    public void WhenSellButtonClicked()
    {
        if (backpackItem.activeInHierarchy == true)
            backpackItem.SetActive(false);
        else
            backpackItem.SetActive(true);
    }
}
