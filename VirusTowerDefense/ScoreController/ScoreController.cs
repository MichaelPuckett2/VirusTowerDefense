using VirusTowerDefense.Models.Enemy;

namespace VirusTowerDefense.ScoreController
{
    public class ScoreController
    {
        public int Score { get; set; }

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

            Score -= value;
        }

        public void VirusDefeated(Enemy enemy)
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

            Score += value;
        }

        public void WaveComplete(int waveNumber)
        {
            Score += 1000;
        }
    }
}
