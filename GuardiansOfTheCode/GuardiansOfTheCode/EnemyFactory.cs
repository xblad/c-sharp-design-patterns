using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode
{
    public class EnemyFactory
    {
        public int AreaLevel { get; }
        private Stack<Zombie> _zombiesPool = new Stack<Zombie>();
        private Stack<Werewolf> _werewolvesPool = new Stack<Werewolf>();
        private Stack<Giant> _giantsPool = new Stack<Giant>();

        private void PreloadZombies()
        {
            int count;
            if (AreaLevel < 3)
            {
                count = 15;
            }
            else if (AreaLevel < 10)
            {
                count = 50;
            }
            else
            {
                count = 200;
            }
            (int health, int level, int armor) = GetZombieStatus(AreaLevel);

            for (int i = 0; i < count; i++)
            {
                _zombiesPool.Push(new Zombie(health, level, armor));
            }
        }

        private static (int health, int level, int armor) GetZombieStatus(int areaLevel)
        {
            int health, armor, level;

            if (areaLevel < 3)
            {
                health = 66;
                level = 2;
                armor = 15;
            }
            else if (areaLevel < 10)
            {
                health = 66;
                level = 2;
                armor = 15;
            }
            else
            {
                health = 100;
                level = 8;
                armor = 15;
            }

            return (health, level, armor);
        }

        public void ReclaimZombie(Zombie zombie)
        {
            (int health, int level, int armor) = GetZombieStatus(AreaLevel);
            zombie.Health = health;
            zombie.Armor = armor;
            _zombiesPool.Push(zombie);
        }

        public Zombie SpawnZombie()
        {
            if (_zombiesPool.Any())
            {
                return _zombiesPool.Pop();
            }
            else
            {
                throw new Exception("Zombie pool depleted!");
            }
        }

        private void PreloadWerewolves()
        {
            int count;

            if (AreaLevel < 3)
            {
                count = 15;
            }
            else if (AreaLevel < 10)
            {
                count = 50;
            }
            else
            {
                count = 200;
            }
            (int health, int armor, int level) = GetWerewolfStatus(AreaLevel);

            for (int i = 0; i < count; i++)
            {
                _werewolvesPool.Push(new Werewolf(health, level, armor));
            }
        }

        private (int health, int level, int armor) GetWerewolfStatus(int areaLevel)
        {
            int health, armor, level;

            if (AreaLevel < 3)
            {
                health = 40;
                level = 2;
                armor = 5;
            }
            else if (AreaLevel < 10)
            {
                health = 45;
                level = 5;
                armor = 7;
            }
            else
            {
                health = 55;
                level = 8;
                armor = 12;
            }

            return (health, level, armor);
        }

        public void ReclaimWerewolf(Werewolf werewolf)
        {
            (int health, int level, int armor) = GetWerewolfStatus(AreaLevel);
            werewolf.Health = health;
            werewolf.Armor = armor;
            _werewolvesPool.Push(werewolf);
        }

        public Werewolf SpawnWerewolf()
        {
            if (_werewolvesPool.Any())
            {
                return _werewolvesPool.Pop();
            }
            else
            {
                throw new Exception("Werewolf pool depleted!");
            }
        }

        private void PreloadGiants()
        {
            int count;

            if (AreaLevel < 3)
            {
                count = 3;
            }
            else if (AreaLevel < 10)
            {
                count = 7;
            }
            else
            {
                count = 11;
            }
            (int health, int armor, int level) = GetWerewolfStatus(AreaLevel);

            for (int i = 0; i < count; i++)
            {
                _giantsPool.Push(new Giant(health, level, armor));
            }
        }

        private (int health, int level, int armor) GetGiantStatus(int areaLevel)
        {
            int health, armor, level;

            if (AreaLevel < 3)
            {
                health = 100;
                level = 1;
                armor = 15;
            }
            else if (AreaLevel < 10)
            {
                health = 111;
                level = 2;
                armor = 17;
            }
            else
            {
                health = 125;
                level = 4;
                armor = 22;
            }

            return (health, level, armor);
        }

        public void ReclaimGiant(Giant giant)
        {
            (int health, int level, int armor) = GetGiantStatus(AreaLevel);
            giant.Health = health;
            giant.Armor = armor;
            _giantsPool.Push(giant);
        }

        public Giant SpawnGiant()
        {
            if (_giantsPool.Any())
            {
                return _giantsPool.Pop();
            }
            else
            {
                throw new Exception("Giant pool depleted!");
            }
        }

        public EnemyFactory(int areaLevel)
        {
            AreaLevel = areaLevel;
            PreloadZombies();
            PreloadWerewolves();
            PreloadGiants();
        }
    }
}
