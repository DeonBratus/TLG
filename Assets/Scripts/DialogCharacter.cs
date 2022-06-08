using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogCharacter : MonoBehaviour
{
    //
    [System.Serializable]
    public class NPC
    {
        public string nameCharacter;
        public List<string> textDialog;
    }
    public Text TextUI;
    public GameObject buttonDialog;
    public GameObject buttonAccept;
    public GameObject FirstPuzzle;
    public NPC[] npc;
   public static int IT_lvl;
    int IT_Number =0;
    public int MED_lvl;
   public static int numberText = 0;
    void Start()
    {
      // PlayerPrefs.SetInt("Level_IT", IT_lvl);
    //   PlayerPrefs.SetInt("Level_MED", MED_lvl);
        IT_lvl = PlayerPrefs.GetInt("Level_IT");
        MED_lvl = PlayerPrefs.GetInt("Level_MED");
        buttonAccept.SetActive(false);
        FirstPuzzle.SetActive(false);
    }

    
    void Update()
    { 
        if (TriggerScript.numberHero == 0)
        {
            switch (IT_lvl)
            {
                case 0:
                    TextUI.text = npc[0].textDialog[numberText];
                    IT_Number = 0;

                    break;
                case 1:
                    TextUI.text = npc[2].textDialog[numberText];
                    IT_Number = 2;
                    break;
                case 2:
                    TextUI.text = npc[4].textDialog[numberText];
                
                    break;
                case 3:
                    TextUI.text = npc[6].textDialog[numberText];
                    
                    break;
                case 4:
                    TextUI.text = npc[8].textDialog[numberText];
                    IT_Number = +2;break;
                default:
                    break;
            }
        }
        else if (TriggerScript.numberHero == 1)
        {
            switch (MED_lvl)
            {
                case 0:
                    TextUI.text = npc[1].textDialog[numberText];
                    break;
                case 1:
                    TextUI.text = npc[3].textDialog[numberText];
                    break;
                case 2:
                    TextUI.text = npc[5].textDialog[numberText];
                    break;
                case 3:
                    TextUI.text = npc[7].textDialog[numberText];
                    break;
                case 4:
                    TextUI.text = npc[9].textDialog[numberText];
                    break;
                default:
                    break;
            }
        }

       
        
            if ((MED_lvl == 0 || IT_lvl == 0))
            {
            if (numberText + 1 >= npc[TriggerScript.numberHero].textDialog.Count)
              {
                buttonDialog.SetActive(false);
                buttonAccept.SetActive(true);
              }

            }  
       
        
        Debug.Log(numberText+1 + " " + npc[TriggerScript.numberHero].textDialog.Count);
        
    }
   public void PlusClick()
    {
        if (numberText < npc[IT_Number].textDialog.Count - 1)
        {
            numberText++;
        }
    }
    public void JoinToSphere()
    {
        Time.timeScale = 0;
        numberText = 0;
        IT_lvl++;
        MED_lvl++;
        FirstPuzzle.SetActive(true);
        if (TriggerScript.numberHero == 0)
        {     
            PlayerPrefs.SetInt("Level_IT", IT_lvl);
        }
        else if(TriggerScript.numberHero == 1)
        {
            PlayerPrefs.SetInt("Level_MED", MED_lvl);
        }
        PlayerPrefs.SetInt("CurrentSphere", TriggerScript.numberHero);
        buttonAccept.SetActive(false);
        buttonDialog.SetActive(false);
    }
     
   public void MinusClick()
    {
        if(numberText>0)
        numberText--;
    }
}
