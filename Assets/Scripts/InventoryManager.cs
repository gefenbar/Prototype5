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

    public void Error(string item)
    {
        if (item == "Begginer's" || item == "Intermediate's")
        {
            error.text = "You need to buy the " + item + " sword before this one ";

        }
        else
            error.text = "You don't have enough money to buy " + item;
    }

    public void BuySword1()
    {
        if (Player.coins >= sword1price)
        {
            Player.coins -= sword1price;
            Player.sword = "Sword1";
            Player.attack+=10;
        }
        else
            Error("Sword1");

    }
    public void BuySword2()
    {
        if (Player.sword == "Sword1")
        {
            if (Player.coins >= sword2price)
            {
                Player.coins -= sword2price;
                Player.sword = "Sword2";
              Player.attack+=15;
            }
            else
                Error("Sword2");
        }
        else Error("Begginer's");

    }
    public void BuySword3()
    {
        if (Player.sword == "Sword2")
        {
            if (Player.coins >= sword3price)
            {
                Player.coins -= sword3price;
                Player.sword = "Sword3";
              Player.attack+=20;

            }
            else
                Error("Sword3");
        }
        else Error("Intermediate's");
    }
}
