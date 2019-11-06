// using System;

namespace IronNinja.Models {
    public class Hero {
        public string Name { get;set; }
        public int HealthPoints { get;set; }
        public int AttackPoints { get;set; }
        public int DefensePoints { get;set; }
        public int StaminaPoints { get;set; }

        public Hero(string name) {
            Name = name;
            HealthPoints = 0;
            AttackPoints = 0;
            DefensePoints = 0;
            StaminaPoints = 0;
        }
    }
}