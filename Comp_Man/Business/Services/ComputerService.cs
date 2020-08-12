using Common;
using Common.Model;
using Common.Model.Enum;
using Common.Services;

namespace Business.Services
{
    public class ComputerService : IComputerService
    {
        private IPersonService _personService;

        public ComputerService(IPersonService personService)
        {
            this._personService = personService;
        }

        public void BuyingComputer(GameMenu game, Hardware hardware)//i - 1(comp), 2(memory), 3(hdd), 4(modem), 5(cd)
        {
            int price;
            switch (hardware)
            {
                case Hardware.Comp:
                    if (game.Computer.Comp == 4)
                    {
                        break;
                    }
                    price = 10 + game.Computer.Comp * 20;
                    if (game.Person.Money >= price)
                    {
                        game.Person.Money -= price;
                        game.Computer.Comp += 1;
                        _personService.PointsCalculate(game);
                    }
                    else
                    {
                        //You don't have money
                    }
                    break;
                case Hardware.Memory:
                    if (game.Computer.Memory == 4)
                    {
                        break;
                    }
                    price = 5 + game.Computer.Memory * 10;
                    if (game.Person.Money >= price)
                    {
                        game.Person.Money -= price;
                        game.Computer.Memory += 1;
                        _personService.PointsCalculate(game);
                    }
                    else
                    {
                        //You don't have money
                    }
                    break;
                case Hardware.Hdd:
                    if (game.Computer.HDD == 4)
                    {
                        break;
                    }
                    price = 20 + game.Computer.HDD * 50;
                    if (game.Person.Money >= price)
                    {
                        game.Person.Money -= price;
                        game.Computer.HDD += 1;
                        _personService.PointsCalculate(game);
                    }
                    else
                    {
                        //You don't have money
                    }
                    break;
                case Hardware.Modem:
                    if (game.Computer.Modem == 4)
                    {
                        break;
                    }
                    price = 10 + game.Computer.Modem * 20;
                    if (game.Person.Money >= price)
                    {
                        game.Person.Money -= price;
                        game.Computer.Modem += 1;
                        _personService.PointsCalculate(game);
                    }
                    else
                    {
                        //You don't have money
                    }
                    break;
                case Hardware.Cd:
                    if (game.Computer.Cd == 4)
                    {
                        break;
                    }
                    price = 30 + game.Computer.Cd * 25;
                    if (game.Person.Money >= price)
                    {
                        game.Person.Money -= price;
                        game.Computer.Cd += 1;
                        _personService.PointsCalculate(game);
                    }
                    else
                    {
                        //You don't have money
                    }
                    break;
            }
            
        }

        public void Install(GameMenu game, Programs programs, int k)//i - 1(system), 2(programming)
        {
            switch (programs)
            {
                case Programs.System:
                    if (game.Computer.InstalSystem == 4)
                    {
                        break;
                    }

                    if (k <= game.Computer.Comp && k <= game.Computer.Memory && k <= game.Computer.HDD)
                    {
                        game.Computer.InstalSystem = k;
                        _personService.PointsCalculate(game);
                    }
                    else
                    {
                        //Слабый комп
                    }
                    break;
                case Programs.Programming:
                    if (game.Computer.InstalProgramming == 4)
                    {
                        break;
                    }

                    if (k <= (game.Computer.InstalSystem + 1) && game.Person.Points >= k * 15 && game.Computer.InstalSystem != 0)
                    {
                        game.Computer.InstalProgramming = k;
                        _personService.PointsCalculate(game);
                    }
                    else
                    {
                        //Недостаточно опыта или слабая система
                    }
                    break;
            }
        }
    }
}
