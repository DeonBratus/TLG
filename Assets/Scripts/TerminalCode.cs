using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerminalCode : MonoBehaviour
{
    public Canvas Can;
    RectTransform canRect;
    public GameObject Screen;
    public Transform spawn;
    public int offset;
    int FullOffset = 0;
    public string text;
    [System.Serializable]
    public class PrintTxt
    {
        public GameObject block;
        public Text text;
        public GameObject DelBut;
    }
    public PrintTxt printText;
    RectTransform BlockRect;
    bool isPressed;
    GameObject obj;
    public Text txt;
    public static bool  isAdded = true;
    void Start()
    {
    }
 
    void Update()
    {
       text = obj.GetComponentInChildren<InputField>().GetComponentsInChildren<Text>()[1].text;
        Debug.Log(text);
        
    }

    public void CreateBlocks()
    {
        if (isAdded)
        {
            obj = GameObject.Instantiate<GameObject>(printText.block, Screen.transform);
            Vector2 pos = new Vector2(spawn.position.x - offset, spawn.position.y + FullOffset);
           // FullOffset -= 300;
            obj.transform.position = pos;
            Debug.Log(obj.GetComponentInChildren<InputField>().GetComponentInChildren<Text>().name);
            isAdded = false;
        }
        else
        {

        }
        
    }
    public void PrintOut()
    {
        
        txt.text = text;
    }
    public void PowerOffPC()
    {
        Time.timeScale = 1;

    }
    public void LoadCode()
    {
        PlayerPrefs.SetString("CodeForCafe", txt.text);
        txt.text = "Код успешно загружен на флешку";
    }    
    
}
