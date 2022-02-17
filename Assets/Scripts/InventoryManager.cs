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
        coins.text = Player.Instance.coins.ToString();
    }
    public void BuyApple()
    {
        if (Player.Instance.coins > applePrice)
        {
            Player.Instance.coins -= applePrice;
            Player.Instance.apple += 1;
          
        }
        else
            Error("Apple");


    }

    public void BuyPotion()
    {
        if (Player.Instance.coins > potionPrice)
        {
            Player.Instance.coins -= potionPrice;
            Player.Instance.potion += 1;
        }
        else
            Error("Potion");

    }

    public void BuyScroll()
    {
        if (Player.Instance.coins > scrollPrice)
        {
            Player.Instance.coins -= scrollPrice;
            Player.Instance.scroll += 1;
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
        if (Player.Instance.coins > sword1price)
        {
            Player.Instance.coins -= sword1price;
            Player.Instance.sword = 1;
            Player.Instance.attack+=10;

        }
        else
            Error("Sword1");

    }
    public void BuySword2()
    {
        if (Player.Instance.sword == 1)
        {
            if (Player.Instance.coins > sword2price)
            {
                Player.Instance.coins -= sword2price;
                Player.Instance.sword = 2;
              Player.Instance.attack+=15;
            }
            else
                Error("Sword2");
        }
        else Error("Begginer's");

    }
    public void BuySword3()
    {
        if (Player.Instance.sword == 2)
        {
            if (Player.Instance.coins > sword3price)
            {
                Player.Instance.coins -= sword3price;
                Player.Instance.sword = 3;
              Player.Instance.attack+=20;

            }
            else
                Error("Sword3");
        }
        else Error("Intermediate's");
    }
}
