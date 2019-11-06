namespace IronNinja.Models {
    public class Warrior : Hero {
        public Warrior(string name) : base(name) {
            HealthPoints = 15;
            AttackPoints = 15;
            DefensePoints = 15;
        }

        public void Attack(Monster target) {
            int damage = (int)(AttackPoints * 1.2) - (int)(target.DefensePoints * 0.8);
            HealthPoints -= damage; 
        }
    }
}