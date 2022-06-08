using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistCamera : MonoBehaviour
{
    public Camera mainCam;
    public float Deltasize;
    float valueCamSize;
    public void Start()
    {
         valueCamSize = PlayerPrefs.GetFloat("CamView");
        mainCam.orthographicSize = valueCamSize;
    }
    public void Update()
    {
        valueCamSize = PlayerPrefs.GetFloat("CamView");

        if (Input.GetKeyUp(KeyCode.Equals) && mainCam.orthographicSize > 2f)
        {
            
            valueCamSize -= Deltasize;
            PlayerPrefs.SetFloat("CamView", valueCamSize);
            mainCam.orthographicSize = PlayerPrefs.GetFloat("CamView");


        }
        if (Input.GetKeyUp(KeyCode.Minus) && mainCam.orthographicSize < 4f)
        {
          
            valueCamSize += Deltasize;
            PlayerPrefs.SetFloat("CamView", valueCamSize);
            mainCam.orthographicSize = PlayerPrefs.GetFloat("CamView");

        }
        Debug.Log(valueCamSize + " " + PlayerPrefs.GetFloat("CamView"));
        //mainCam.orthographicSize = valueCamSize;

    }
}
