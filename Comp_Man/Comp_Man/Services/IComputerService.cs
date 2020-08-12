using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;
using Common.Model.Enum;

namespace Common.Services
{
    public interface IComputerService
    {
        void BuyingComputer(GameMenu game, Hardware hardware);
        void Install(GameMenu game, Programs programs, int k);
    }
}
