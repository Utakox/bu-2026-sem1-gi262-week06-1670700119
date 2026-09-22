using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Character : GameEntity
    {
       public string characterName;
       protected float moveSpeed;
       private int level;

       public virtual void Attack(GameEntity target)
       {
           // Implement attack logic here
       }

       protected virtual void LevelUp()
       {
           level++;
           // Implement level up logic here
       }
    }
}
