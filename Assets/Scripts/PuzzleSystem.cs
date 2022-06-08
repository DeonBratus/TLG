using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace PuzzleElements
{
    public class PuzzleSystem : MonoBehaviour

    {
        public Text AboutDescript;
        public GameObject LoadSceneButton;
        int sphereName;
        int sphereLVL;
        public List<GameObject> prefabsPuzzle;
        
        public List<Puzzle> puzzles;

        public void Start()
        {
            LoadSceneButton.SetActive(false);
            sphereName = PlayerPrefs.GetInt("CurrentSphere");
            sphereLVL = PlayerPrefs.GetInt("Level_IT");
          
        }
        public void SwitchSphere(int n)
        {
            for(int i = 0; i<prefabsPuzzle.Count-1; i++)
            {
                if (i == n)
                {
                    prefabsPuzzle[i].SetActive(true);
                }
                else
                {
                    prefabsPuzzle[i].SetActive(false);
                }
            }
        }
        
        public void Update()
        {
            switch (sphereName)
            {
                case 0:
                    SwitchSphere(0);
                    break;
                case 1:
                    SwitchSphere(1);
                    break;
                case 2:
                    SwitchSphere(2);
                    break;
                default:
                    break;
            }
            switch (sphereLVL)
            {
                case 0:
                    puzzles[0].isAct = true;
                    break;
                case 1:
                    puzzles[0].isAct = true;
                    puzzles[1].isAct = true;
                    break;
                case 2:
                    puzzles[0].isAct = true;
                    puzzles[1].isAct = true;
                    puzzles[2].isAct = true;
                   
                    break;
                default:
                    break;
            }
            PuzzleAction();
            Debug.Log(sphereName + "   " + sphereLVL);



        }
        public void PuzzleAction()
        {
            foreach(Puzzle PuzFor in puzzles)
            {         
                PuzFor.PuzzleState();
              
                
            }    
        }
        public void PuzAndDescript(string name)
        {
            foreach(Puzzle Puzz in puzzles)
            {
                if (Puzz.PuzButton.name == name)
                {
                    AboutDescript.text = Puzz.TextTask;
                    LoadSceneButton.SetActive(true);
                }
            }

        }
        public void SceneLoader()
        {
            SceneManager.LoadScene(2);
        }
        public void ZeroLvl()
        {
            //PlayerPrefs.SetFloat("Level_IT", 0);
            //PlayerPrefs.SetFloat("PlayerPositionX", 0);
            //PlayerPrefs.SetFloat("PlayerPositionY", 0);
            //PlayerPrefs.SetInt("ComplitedSeller", 0);
            //PlayerPrefs.SetString("CodeForCafe", null);
            PlayerPrefs.DeleteAll();
        }
            
    }
}
    