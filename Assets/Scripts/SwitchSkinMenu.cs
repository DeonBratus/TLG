using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchSkinMenu : MonoBehaviour
{
    public Sprite[] skins;
    public Image avatar;
    
    void Start()
    {
        avatar.sprite = skins[PlayerPrefs.GetInt("SkinNumber")];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
