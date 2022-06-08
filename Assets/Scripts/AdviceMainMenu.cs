using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdviceMainMenu : MonoBehaviour
{
    public GameObject Advice1;
    void Start()
    {
        if(PlayerPrefs.GetInt("Level_IT") == 0)
        {
            Advice1.SetActive(true);
        }
        else
        {
            Advice1.SetActive(false);
        }    
    }
}
