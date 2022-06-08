using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadMainMenu : MonoBehaviour
{
    public void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("SkinNumber"));
    }
    public void toMain()
    {
        if (String.IsNullOrEmpty(PlayerPrefs.GetInt("SkinNumber").ToString()) == true || PlayerPrefs.GetInt("SkinNumber") == 0)
            SceneManager.LoadScene(3);
        else
            SceneManager.LoadScene(1);
    }
    public void SwitchLoad()
    {
        SceneManager.LoadScene(3);
    }
}
