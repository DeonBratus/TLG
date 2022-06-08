using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsVC : MonoBehaviour
{
    public Slider Volume;
    public Slider CamView;
    public Text txtV;
    public Text camV;
    public AudioSource audio;
    float volumeValue;
    float CVValue;
    void Start()
    {
        Volume.value = PlayerPrefs.GetFloat("VolumeValue");
        CamView.value = PlayerPrefs.GetFloat("CamView");
    }

    // Update is called once per frame
    void Update()
    {
        audio.volume = PlayerPrefs.GetFloat("VolumeValue");
        CVValue = PlayerPrefs.GetFloat("CamView");
        volumeValue = Volume.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        CamView.value = CVValue;
        PlayerPrefs.SetFloat("CamView", CVValue);
        txtV.text = $"{Mathf.Round(volumeValue * 100)}/{Volume.maxValue*100}";
        camV.text = $"{Mathf.Round(CVValue*25)}/{CamView.maxValue*25}";

    }
}
