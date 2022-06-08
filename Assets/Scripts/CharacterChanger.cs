using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterChanger : MonoBehaviour
{
    bool isChange;
    public GameObject ErrorPanel;
    public void Start()
    {
        
    }
    public void SwitchSkin(int numberSkin)
    {
        PlayerPrefs.SetInt("SkinNumber", numberSkin);
        isChange = true;
        Debug.Log(PlayerPrefs.GetInt("SkinNumber"));
    }
    public void LoadMenu()
    {
        if(isChange)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            ErrorPanel.SetActive(true);
        }
    }
}
