namespace GuardiansOfTheCode
{
    public class FireStaff : IWeapon
    {
        public int Damage { get; }

        private int FireDamage { get; }

        public FireStaff(int damage, int fireDamage)
        {
            Damage = damage;
            FireDamage = fireDamage;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.OvertimeDamage = FireDamage;
        }
    }
}