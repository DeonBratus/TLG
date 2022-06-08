using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
   public GameObject playPanel;
   public GameObject menuPanel;
    public GameObject player;
    void Start()
    {
        playPanel.SetActive(true);
        menuPanel.SetActive(false);
        Time.timeScale = 1;
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale != 0)
            {
                toGameMenu();
            }
            else
            {
                BackToPlay();
            }
        }
    }
    public void toGameMenu()
    {
        playPanel.SetActive(false);
        menuPanel.SetActive(true);
        player.SetActive(false);
        Time.timeScale = 0;
    }

    public void BackToPlay()
    {
        playPanel.SetActive(true);
        menuPanel.SetActive(false);
        player.SetActive(true);
        Time.timeScale = 1;

    }
    public void toMainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
