using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;
using Common.Model.Enum;

namespace Common.Services
{
    public interface IHackingService
    {
        void CheckHackingEnabled(GameMenu game);
        void ProgramExchange(GameMenu game, HackingPrograms programs);
        void HackingPointsCalculate(GameMenu game);
        int HackingTasksPick(GameMenu game);
        void HackingDoing(GameMenu game, int task, int part, HackingPrograms hackingProgramUsed, int moneyTake);
    }
}
