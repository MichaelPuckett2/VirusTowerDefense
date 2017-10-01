using VirusTowerDefense.Models.Enemy;
using VirusTowerDefense.Models.Towers;

namespace VirusTowerDefense.MoneyController
{
    public class MoneyController
    {
        public int Money { get; set; }

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

            Money -= value;
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

            Money += value;
        }

        public void TowerPurchased(Tower tower)
        {
            var value = 0;

            switch (tower)
            {
                case AntiMalware antiMalware:
                    value = 5;
                    break;

                case AntiVirus antiVirus:
                    value = 10;
                    break;

                case Firewall firewall:
                    value = 20;
                    break;

                default:
                    break;

            }

            Money -= value;
        }

        public void WaveComplete(int waveNumber)
        {
            Money += 500;
        }
    }
}
