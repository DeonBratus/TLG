using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pcBut;
    public GameObject ErrBut;
    public GameObject Terminal;
    void Start()
    {
        pcBut.SetActive(false);
        ErrBut.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            if (PlayerPrefs.GetInt("Level_IT") >= 1)
            {

                pcBut.SetActive(true);

            }
            else
            {
                ErrBut.SetActive(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pcBut.SetActive(false);
        }
    }
    public void LaunchPC()
    {
        pcBut.SetActive(false);
        Terminal.SetActive(true);
        Time.timeScale = 0;
    }
}    

