using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    [System.Serializable]
    public class buttonsMenu
    {
        public string nameButton;
        public GameObject partsMenuToLoad;
    }
    public List<buttonsMenu> Buttons;
    public void Start()
    {
        actionName("Main");
    }
    public void actionName(string name)
    {
        foreach (buttonsMenu menu in Buttons)
        {
            menu.partsMenuToLoad.SetActive(false);
            if (menu.nameButton == name) menu.partsMenuToLoad.SetActive(true);
        }
    }
}