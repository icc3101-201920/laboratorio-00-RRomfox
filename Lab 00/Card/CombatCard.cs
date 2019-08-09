using System;
using System.Collections.Generic;
using System.Text;

namespace Card
{
    public class CombatCard
    {
        private string name;
        private int attackPoints;
        private bool hero;
        private string type;
        private string effect;

        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public string Name { get => name; set => name = value; }
        public string Effect { get => effect; set => effect = value; }
        public string Type { get => type; set => type = value; }
        public bool Hero { get => hero; set => hero = value; }



    }
}
