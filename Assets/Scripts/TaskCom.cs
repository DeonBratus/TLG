using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TaskCom : MonoBehaviour
{
    public Text TextDescription;
    public string nameSphere;
    int PhraseNum;
    public GameObject buttonJoin;
    public Dialogue[] dialogue;
    void Start()
    {
        
    }
    void Update()
    {
                TextDescription.text = dialogue[PlayerPrefs.GetInt("Level_IT")].Phrases[PhraseNum];
        if(PlayerPrefs.GetInt("Level_IT") == 0 && PhraseNum >= dialogue[PlayerPrefs.GetInt("Level_IT")].Phrases.Length - 1)
        {
            buttonJoin.SetActive(true);
        }
        else
        {
            buttonJoin.SetActive(false);
        }
        Debug.Log(PlayerPrefs.GetInt("Level_IT"));
    }
    public void nextPhrase()
    {
        if (PhraseNum < dialogue[PlayerPrefs.GetInt("Level_IT")].Phrases.Length-1)
            PhraseNum++;
        else
        {
            
        }
    }
    public void PrePhrase()
    {
        if (PhraseNum > 0)
            PhraseNum--;
    }
    public void PlusLVL()
    {
        PlayerPrefs.SetInt("Level_IT", 1);
        PhraseNum = 0;
    }
}
