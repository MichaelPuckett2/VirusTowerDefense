using System;
using System.Collections.Generic;
using VirusTowerDefense.Models.Enemy;

namespace VirusTowerDefense.EnemySpawnController
{
    public class EnemySpawnController
    {
        private const int DefaultNumberOfEnemies = 10;
        private const int EnemyVSRoundMultiplier = 2;

        public IList<Enemy> SpawnEnemies(int waveNumber)
        {
            var numberOfEnemies = DefaultNumberOfEnemies + waveNumber * EnemyVSRoundMultiplier;
            var enemies = new List<Enemy>();
            var random = new Random();
            Enemy newEnemy = null;

            for (int i = 0; i < numberOfEnemies; i++)
            {
                var randomValue = random.Next(0, waveNumber);

                switch (waveNumber)
                {
                    case 0:
                    case 1:
                    case 2:
                        newEnemy = new Malware();
                        break;

                    case 3:
                        if (randomValue > 1)
                            newEnemy = new Spyware();
                        else
                            newEnemy = new Malware();
                        break;

                    default:
                        if (waveNumber > 3)
                        {
                            if (randomValue > 1)
                                newEnemy = new Spyware();
                            else
                                newEnemy = new Malware();
                            break;
                        }
                        break;
                }

                if (newEnemy != null)
                    enemies.Add(newEnemy);
            }

            return enemies;
        }
    }
}
