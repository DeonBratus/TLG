using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad : MonoBehaviour
{
    public GameObject player;
    public GameObject NavMesh2d;
    Vector2 SavedPosition;
    private void Awake()
    {
        
    }
    void Start()
    {
        LoadPosition();

    }
    void Update()
    {
        
    }
    public void SavePosition()
    {
        SavedPosition = player.transform.position;
        PlayerPrefs.SetFloat("PlayerPositionX", SavedPosition.x);
        PlayerPrefs.SetFloat("PlayerPositionY", SavedPosition.y);
    }
    public void LoadPosition()
    {
      
        
        player.GetComponent<PlayerClickMove>().enabled = false;
        Vector2 pos =  new Vector2(PlayerPrefs.GetFloat("PlayerPositionX"), PlayerPrefs.GetFloat("PlayerPositionY"));
        player.transform.position = pos;
        Debug.Log(pos + ""+ player.transform.position);
        player.GetComponent<PlayerClickMove>().enabled = true;


    }
}
