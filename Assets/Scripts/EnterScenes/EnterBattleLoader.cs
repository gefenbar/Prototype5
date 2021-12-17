using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnterBattleLoader : MonoBehaviour
{
   void OnMouseDown()
    {
        SceneManager.LoadScene("BattleLoader");
    }
}