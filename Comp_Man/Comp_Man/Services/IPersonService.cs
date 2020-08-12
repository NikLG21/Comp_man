using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;
using Common.Model.Enum;

namespace Common.Services
{
    public interface IPersonService
    {
        void PointsCalculate(GameMenu game);
        void IncomeCalculate(GameMenu game);
        void Entertainment(GameMenu game, Entertainments entertainments);
        void NewJob(GameMenu game, int newJob);
        void Taxes(GameMenu game);
    }
}
