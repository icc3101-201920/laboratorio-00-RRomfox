using System;
using System.Collections.Generic;
using System.Text;

namespace Card
{
    public class Player
    {
        private int lifePoints;
        private int attackPoints;

        public int LifePoints { get => lifePoints; set => lifePoints = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }


    }
}
