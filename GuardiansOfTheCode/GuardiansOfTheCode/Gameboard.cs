using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode
{
    public class Gameboard
    {
        private PrimaryPlayer _player;
        private EnemyFactory _enemyFactory;

        public Gameboard()
        {
            _player = PrimaryPlayer.Instance;
            _player.Weapon = new Sword(12, 8);
            Console.WriteLine($"Name: {_player.Name}, Level: {_player.Level}");

            PlayArea(1);
        }

        public void PlayArea(int level)
        {
            if (level == 1)
                PlayFirstLevel();
        }

        private void PlayFirstLevel()
        {
            const int currentLevel = 1;
            _enemyFactory = new EnemyFactory(currentLevel);
            List<IEnemy> enemies = new List<IEnemy>();
            for (int i = 0; i < 7; i++)
            {
                enemies.Add(_enemyFactory.SpawnZombie());
            }

            for (int j = 0; j < 3; j++)
            {
                enemies.Add(_enemyFactory.SpawnGiant());
            }

            foreach (IEnemy enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetType()}: health {enemy.Health} and level {enemy.Level}");
            }

            foreach (IEnemy enemy in enemies)
            {
                while (enemy.Health > 0 && _player.Health > 0)
                {
                    _player.Weapon.Use(enemy);
                    enemy.Attack(_player);
                    enemy.Defend(_player);
                }
            }
        }
    }
}
