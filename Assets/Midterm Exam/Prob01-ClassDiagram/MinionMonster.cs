using Unity.VisualScripting;
using UnityEngine;

namespace MidtermExam.Prob01
{
    public class MinionMonster : Monster
    {
        public int swarmBonus;
        private bool isAlerted;

        public void CallReinforcements()
        {
            isAlerted = true;
        }
        // TODO: Implement inheritance, fields and methods according to Class Diagram
    }
}
