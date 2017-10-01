using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirusTowerDefense.Models.Enemy;

namespace VirusTowerDefense.ScoreController
{
    public class MoneyController
    {
        public int Score { get; set; }

        public void VirusEnteredKernal(Enemy enemy)
        {
            var value = 0;

            switch (enemy)
            {
                case BotAttack botAttack:
                    value = 10;
                    break;

                case Malware malware:
                    value = 10;
                    break;

                case PiratedGame piratedGame:
                    value = 10;
                    break;

                case Spyware spyware:
                    value = 10;
                    break;

                default:
                    break;
            }

            Score -= value;
        }

        public void VirusDefeated(Enemy enemy)
        {
            var value = 0;

            switch (enemy)
            {
                case BotAttack botAttack:
                    value = 5;
                    break;

                case Malware malware:
                    value = 10;
                    break;

                case PiratedGame piratedGame:
                    value = 35;
                    break;

                case Spyware spyware:
                    value = 20;
                    break;

                default:
                    break;
            }

            Score += value;
        }

        public void WaveComplete(int waveNumber)
        {
            Score += 500;
        }
    }
}
