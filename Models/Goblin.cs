namespace IronNinja.Models {
    public class Goblin : Monster {
        public Goblin() : base() {
        }

        public void Action(Hero target) {
            int dmg = (int)(AttackPoints * 0.5);
            target.HealthPoints -= dmg;
        }

    }
}