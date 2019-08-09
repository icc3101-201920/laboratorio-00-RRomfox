using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_00
{
    public class Player
    {
        private int lifePoints;
        private int attackPoints;

        public int LifePoints { get => lifePoints; set => lifePoints = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }

        public void DrawCard() { }
        public void PlayCard() { }
        public void ChangeCard() { }
        public void FirstHand() { }
        public void ChooseCaptainCard() { }




    }
}
