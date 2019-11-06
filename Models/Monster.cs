namespace IronNinja.Models {
    public class Monster {
        public int HealthPoints { get;set; }
        public int AttackPoints { get;set; }
        public int DefensePoints { get;set; }

        public Monster() {
            HealthPoints = 10;
            AttackPoints = 10;
            DefensePoints = 10;
        }
    }
}