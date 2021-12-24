using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationPage : MonoBehaviour
{
    public GameObject apple;
    public GameObject scroll;
    public GameObject potion;

    void Start()
    {
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
