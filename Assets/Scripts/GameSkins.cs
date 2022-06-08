using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;




public class GameSkins : MonoBehaviour
{
    public Animator animator;

    public SpriteRenderer spriteRender;

    public RuntimeAnimatorController[] animController;

    public Sprite[] sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        switch(PlayerPrefs.GetInt("SkinNumber"))
        {
            case 1:
                SetSkin(1);
                break;
            case 2:
                SetSkin(2);
                break;
            case 3:
                SetSkin(3);
                break;
            case 4:
                SetSkin(4);
                break;
            case 5:
                SetSkin(5);
                break;
            case 6:
                SetSkin(6);
                break;
            default:
                SetSkin(0);
                break;
        }
    }
    public void SetSkin(int n)
    {
        animator.runtimeAnimatorController = animController[n];
        spriteRender.sprite = sprite[n];
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("SkinNumber"));
        
    }
}
