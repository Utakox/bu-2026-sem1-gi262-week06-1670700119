using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Hero : Character
    {
        public int currentExp;
        private int gold;

        public override void Attack(GameEntity target)
        {
            // Implement hero-specific attack logic here
        }

        public void CollectGold(int amount)
        {
            gold += amount;
            // Implement gold collection logic here
        }

        protected override void LevelUp()
        {
            base.LevelUp();
            currentExp = 0;
            // Implement hero-specific level up logic here
        }
    }
}
