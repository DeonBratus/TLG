using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerClickMove : MonoBehaviour
{
    public NavMeshAgent toPoint;
  
    Animator anim;
    Vector2 deltaMousePlayer;
    Vector2 oldPos;
   public static Vector3 WorldPos;
    void Start()
    {
       
        toPoint = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
       
        toPoint.updateRotation = false;
        toPoint.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
         WorldPos = Input.mousePosition;
         WorldPos.z = -Camera.main.transform.position.z;
        WorldPos = Camera.main.ScreenToWorldPoint(WorldPos);
        AnimAndMove();
       



    }
    public void AnimAndMove()
    {
         if (  Mathf.Abs( oldPos.y - toPoint.transform.position.y)<0.01)
        {
            anim.SetFloat("Vertic", 0);
        }
        if (Mathf.Abs(oldPos.x - toPoint.transform.position.x) < 0.01)
        {
            anim.SetFloat("Horiz", 0);
        }
       
        
        if (Input.GetMouseButton(1))
        {
            deltaMousePlayer = WorldPos - toPoint.transform.position;

            if (deltaMousePlayer.y > 0.5)
            {
                anim.SetFloat("Horiz", 0);
                anim.SetFloat("Vertic", 1);

            }
            else if (deltaMousePlayer.y < -0.5)
            {
                anim.SetFloat("Horiz", 0);
                anim.SetFloat("Vertic", -1);
            }
            if (deltaMousePlayer.x > 1)
            {
                anim.SetFloat("Vertic", 0);
                anim.SetFloat("Horiz", 1);
            }
            else if (deltaMousePlayer.x < -1)
            {
                anim.SetFloat("Vertic", 0);
                anim.SetFloat("Horiz", -1);
            }
            toPoint.SetDestination(WorldPos);
            oldPos = WorldPos;
           

        }
    }
    public void keyMove()
    {
        Vector2 pos = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
       
    }
}
