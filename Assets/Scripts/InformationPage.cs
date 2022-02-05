using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationPage : MonoBehaviour
{
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
        wins.text=Player.wins.ToString();
        losses.text=Player.losses.ToString();
        coins.text = Player.coins.ToString();
        attack.text = Player.attack.ToString();
        defense.text = Player.defense.ToString();

        if (Player.apple == 0)
        {
            apple.GetComponent<Image>().color = new Color32(150, 150, 150, 150);
        }
        if (Player.scroll == 0)
        {
            scroll.GetComponent<Image>().color = new Color32(150, 150, 150, 150);
        }
        if (Player.potion == 0)
        {
            potion.GetComponent<Image>().color = new Color32(150, 150, 150, 150);

        }
    }
}
