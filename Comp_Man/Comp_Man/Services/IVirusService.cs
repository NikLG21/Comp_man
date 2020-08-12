using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace Common.Services
{
    public interface IVirusService
    {
        void CalculateChance(GameMenu game);
        void VirusActivation(GameMenu game);
        void TryVirusKill(GameMenu game);
        void VirusWon(GameMenu game);
    }
}
