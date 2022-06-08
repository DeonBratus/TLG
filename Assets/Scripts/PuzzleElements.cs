using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace PuzzleElements
{
    [System.Serializable]
    public class Puzzle
    {
        public Button PuzButton;
        public string TextTask;
        public bool isAct;
        public void PuzzleState()
        {
            PuzButton.interactable = isAct;
           
        }
    }
}
