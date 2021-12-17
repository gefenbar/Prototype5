using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    void Awake()
    {
        StartCoroutine(StartBattle());
    }
    IEnumerator StartBattle()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("Battle");
    }
}
