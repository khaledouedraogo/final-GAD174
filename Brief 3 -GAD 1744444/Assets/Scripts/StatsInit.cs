using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsInit : MonoBehaviour
{
    public int statOne;
    public Image[] firstStat;
    public int statTwo;
    public Image[] secondStat;
    static public int amount;
    public string worth = "" + amount + "f";
    public string itemName;
    public string statNameOne;
    public string statNameTwo;
    public string price = "Price";

    private void OnMouseEnter()
    {
        Stats._instance.SetAndShowName(itemName, statNameOne, statNameTwo, price, worth);
        for (int i = 0; i < firstStat.Length; i++)
        {
            if (i < statOne)
            {
                firstStat[i].enabled = true;
            }
            else
            {
                firstStat[i].enabled = false;
            }
        }
        for (int i = 0; i < secondStat.Length; i++)
        {
            if (i < statTwo)
            {
                secondStat[i].enabled = true;
            }
            else
            {
                secondStat[i].enabled = false;
            }
        }
    }

    private void OnMouseExit()
    {
        Stats._instance.HideStats();
    }
}
