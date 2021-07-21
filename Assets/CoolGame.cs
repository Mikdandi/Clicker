using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoolGame : MonoBehaviour
{
   //Lesson 1
    public Text berriesText;
    public double berries;
    public double berriesClickValue;

    //Lesson 2
    public Text berriesPerSecText;
    public Text handUpgradeText;
    public Text treeUpgradeText;
    //-----------
    //Button HandUpgrade
    //-----------
    //number jf berries per second pasivly
    public double berriesPerSecond;
    // value of how much costs new upgrate
    public double handUpgradeCost;
    // current level of upgrade
    public int handUpgradeLevel;


    public double treeUpgradeCost;
    public int treeUpgradeLevel1;


    // Start is called before the first frame update
    void Start()
    {
        //  berries = 0;
          berriesClickValue = 1;
          handUpgradeCost = 10;
          treeUpgradeCost = 25;
     //   berriesPerSecond = 0;

    }
    // Update is called once per frame
    void Update()
    {
        berriesPerSecond = treeUpgradeLevel1;

        berriesText.text = "Berries: "+ berries.ToString("F0");
        berriesPerSecText.text = berriesPerSecond + " berries/s";
        handUpgradeText.text = "Hand Upgrade 1\nCost: " + handUpgradeCost + " berries\nPower + 1 hand size\nLevel: " + handUpgradeLevel;
        treeUpgradeText.text = "Tree Upgrade 1\nCost: " + treeUpgradeCost + " tree\nPower + 1 berries/s\nLevel: " + treeUpgradeLevel1;

        berries += berriesPerSecond * Time.deltaTime;
    }

    public void Click()
    {
        berries += berriesClickValue;
    }
    public void handUpgradeClick()
    {
        if(berries>= handUpgradeCost)
        {
            handUpgradeLevel++;
            berries -= handUpgradeCost;
            handUpgradeCost *= 2;
            berriesClickValue++;
        }
     
    }
    public void treeUpgradeClick()
    {
        if (berries >= treeUpgradeCost)
        {
            treeUpgradeLevel1++;
            berries -= treeUpgradeCost;
            treeUpgradeCost *= 2;
            
        }

    }
}
