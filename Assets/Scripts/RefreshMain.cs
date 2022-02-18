using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefreshMain : MonoBehaviour
{
    public Text coins;

    void Awake()
    {
        Player.Instance.body.SetActive(false);
        coins.text = Player.Instance.coins.ToString();
    }
}
