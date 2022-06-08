using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TriggerScript : MonoBehaviour
{
    public GameObject buttonTalk;
    public GameObject InterPanel;
    public Text DescriptonText;
    public static int numberHero;
    int NumberReplic;
    

        private void OnTriggerEnter2D(Collider2D collision)
        {
                
            if (collision.tag == "Player")
            {
            if(gameObject.name == "ProgrammerTrigger")
            {
                numberHero = 0;
                
            }
            if(gameObject.name == "MedicTrigger")
            {
                numberHero = 1;
            }
                buttonTalk.SetActive(true);
   

        }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                buttonTalk.SetActive(false);
                InterPanel.SetActive(false);
            DialogCharacter.numberText = 0;

            }
        }
        public void ActiveWin()
        {
            InterPanel.SetActive(true);
            buttonTalk.SetActive(false);
        }

  

    }

