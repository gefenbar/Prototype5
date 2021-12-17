using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour
{
    public Text coins;
    public Text error;
    int applePrice = 150;
    int potionPrice = 250;
    int scrollPrice = 350;
     int sword1price = 150;
    int sword2price = 250;
    int sword3price = 350;

    public void Update()
    {
        coins.text = Character.coins.ToString();
    }
    public void BuyApple()
    {
        if (Character.coins >= applePrice)
        {
            Character.coins -= applePrice;
            Character.apple += 1;
            Debug.Log("coinsleft: " + Character.coins);
            Debug.Log("apples: " + Character.apple);
        }
        else
Error("Apple");
        

    }

    public void BuyPotion()
    {
        if (Character.coins >= potionPrice)
        {
            Character.coins -= potionPrice;
            Character.potion += 1;
        }
        else
        Error("Potion");

    }

    public void BuyScroll()
    {
        if (Character.coins >= scrollPrice)
        {
            Character.coins -= scrollPrice;
            Character.scroll += 1;
        }
        else
                Error("Scroll");

    }

    public void Error(string item){
        error.text="You don't have enough money to buy " + item;
    }

    public void BuySword1()
    {
 if (Character.coins >= sword1price)
        {
            Character.coins -= sword1price;
            Character.sword="sword1";
        }
        else
                Error("Sword");

    }
     public void BuySword2()
    {
 if (Character.coins >= sword2price)
        {
            Character.coins -= sword2price;
            Character.sword="sword2";
        }
        else
                Error("Sword2");
    }
     public void BuySword3()
    {
 if (Character.coins >= sword3price)
        {
            Character.coins -= sword3price;
            Character.sword="sword31";
        }
        else
                Error("Sword3");
    }
}
