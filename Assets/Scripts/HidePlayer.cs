using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePlayer : MonoBehaviour
{
    void Awake()
    {
                        Player.Instance.body.SetActive(false);

    }
    }
