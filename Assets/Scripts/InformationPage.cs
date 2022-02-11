using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationPage : MonoBehaviour
{
    public Text applesQuantity;
     public Text scrollsQuantity;
      public Text potionsQuantity;

    public GameObject apple;
    public GameObject scroll;
    public GameObject potion;
    public Text coins;
    public Text name;
    public Text wins;
     public Text losses;
     public Text attack;
    public Text defense;
    // public Text strength;
    // public Text weakness;
    void Start()
    {
        wins.text=Player.Instance.wins.ToString();
        losses.text=Player.Instance.losses.ToString();
        coins.text = Player.Instance.coins.ToString();
        attack.text = Player.Instance.attack.ToString();
        defense.text = Player.Instance.defense.ToString();
applesQuantity.text=Player.Instance.apple.ToString();
scrollsQuantity.text=Player.Instance.scroll.ToString();
potionsQuantity.text=Player.Instance.potion.ToString();
        if (Player.Instance.apple == 0)
        {
            apple.GetComponent<Image>().color = new Color32(150, 150, 150, 150);
        }
        
        if (Player.Instance.scroll == 0)
        {
            scroll.GetComponent<Image>().color = new Color32(150, 150, 150, 150);
        }
        if (Player.Instance.potion == 0)
        {
            potion.GetComponent<Image>().color = new Color32(150, 150, 150, 150);

        }
    }
}
