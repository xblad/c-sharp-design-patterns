namespace GuardiansOfTheCode
{
    public class IceStaff : IWeapon
    {
        public int Damage { get; }

        public int ParalyzedFor { get; }

        public IceStaff(int damage, int paralyzedFor)
        {
            Damage = damage;
            ParalyzedFor = paralyzedFor;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.Paralyzed = true;
            enemy.ParalyzedFor = ParalyzedFor;
        }
    }
}