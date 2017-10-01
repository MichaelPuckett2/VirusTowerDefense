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
                    value = 20;
                    break;

                case Malware malware:
                    value = 10;
                    break;

                case PiratedGame piratedGame:
                    value = 5;
                    break;

                case Spyware spyware:
                    value = 15;
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
                    value = 15;
                    break;

                case PiratedGame piratedGame:
                    value = 50;
                    break;

                case Spyware spyware:
                    value = 10;
                    break;

                default:
                    break;
            }

            Money += value;
        }

        public void PurchasedTower(Tower tower)
        {
            var value = 0;

            switch (tower)
            {
                case AntiMalware antiMalware:
                    value = 100;
                    break;

                case AntiVirus antiVirus:
                    value = 150;
                    break;

                case Firewall firewall:
                    value = 200;
                    break;

                case Tower tower:
                    value = 10;
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
