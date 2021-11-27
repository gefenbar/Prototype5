using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterBattle : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Battle");
    }
}
