using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seller : MonoBehaviour
{
    public GameObject triggerSell;
    public GameObject button;
    public GameObject panelPositive;
    public GameObject panelNegative;
    public GameObject sellBoard;
    public string taskName;
    void Start()
    {
        button.SetActive(false);
        panelNegative.SetActive(false);
        panelPositive.SetActive(false);
        button.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("ComplitedSeller") != 1)
        {
            sellBoard.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
        }
        else
        {
            sellBoard.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PlayerPrefs.GetInt("ComplitedSeller") != 1 && PlayerPrefs.GetInt("Level_IT")>=0)
        {
            if (collision.tag == "Player")
            {
                button.SetActive(true);
                Debug.Log("Enter");
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            button.SetActive(false);

        }
    }

  public  void AcceptTask()
    {
        if (taskName == PlayerPrefs.GetString("CodeForCafe"))
        {
            panelPositive.SetActive(true);
            button.SetActive(false);
            PlayerPrefs.SetInt("ComplitedSeller", 1);
            level2();


        }
        else
        {
            panelNegative.SetActive(true);
            button.SetActive(false);
        }
    }
    public void level2()
    {
        PlayerPrefs.SetInt("Level_IT", 2);
    }

}
