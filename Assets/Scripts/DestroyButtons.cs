using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyButtons : MonoBehaviour
{
    public void DelButton()
    {
        Destroy(gameObject);
        TerminalCode.isAdded = true;
    }
}
