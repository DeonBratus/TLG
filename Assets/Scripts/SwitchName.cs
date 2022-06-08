using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchName : MonoBehaviour
{
    public Text nameText;
    public Text NickName;
    void Start()
    {
        
    }
    void Update()
    {
        NickName.text = PlayerPrefs.GetString("NickName");

    }
    public void NewName()
    {
        if (String.IsNullOrEmpty(nameText.text) == true)
        {
            Debug.Log("isEmpty");

        }
        else
        {
            PlayerPrefs.SetString("NickName", nameText.text);
            Debug.Log(PlayerPrefs.GetString("NickName"));
          
           
        }
    }
}
