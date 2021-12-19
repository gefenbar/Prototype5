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
        coins.text = Player.coins.ToString();
    }
    public void BuyApple()
    {
        if (Player.coins >= applePrice)
        {
            Player.coins -= applePrice;
            Player.apple += 1;
            Debug.Log("coinsleft: " + Player.coins);
            Debug.Log("apples: " + Player.apple);
        }
        else
Error("Apple");
        

    }

    public void BuyPotion()
    {
        if (Player.coins >= potionPrice)
        {
            Player.coins -= potionPrice;
            Player.potion += 1;
        }
        else
        Error("Potion");

    }

    public void BuyScroll()
    {
        if (Player.coins >= scrollPrice)
        {
            Player.coins -= scrollPrice;
            Player.scroll += 1;
        }
        else
                Error("Scroll");

    }

    public void Error(string item){
        error.text="You don't have enough money to buy " + item;
    }

    public void BuySword1()
    {
 if (Player.coins >= sword1price)
        {
            Player.coins -= sword1price;
            Player.sword="sword1";
        }
        else
                Error("Sword1");

    }
     public void BuySword2()
    {
 if (Player.coins >= sword2price)
        {
            Player.coins -= sword2price;
            Player.sword="sword2";
        }
        else
                Error("Sword2");
    }
     public void BuySword3()
    {
 if (Player.coins >= sword3price)
        {
            Player.coins -= sword3price;
            Player.sword="sword3";
        }
        else
                Error("Sword3");
    }
}
