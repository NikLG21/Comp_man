using System;
using Common;
using Common.Model;
using Common.Model.Enum;
using Common.Services;

namespace Business.Services
{
    public class PersonService : IPersonService
    {
        private IHackingService hackingService;
        public PersonService(IHackingService hackingService)
        {
            this.hackingService = hackingService;
        }

        public void PointsCalculate(GameMenu game)
        {
            game.Person.Points = 4 * game.Computer.Comp +
                                 3 * game.Computer.Memory +
                                 2 * game.Computer.HDD +
                                 game.Computer.Cd +
                                 game.Computer.Modem +
                                 2 * game.Computer.InstalSystem +
                                 2 * game.Computer.InstalProgramming +
                                 2 * Convert.ToInt32(game.Bss.MyBssInstaled) + (int)(game.Bss.MbSoft * 0.5);
            hackingService.CheckHackingEnabled(game);
        }
        public void IncomeCalculate(GameMenu game)
        {
            double k = 1;
            if (game.Person.Mood <= 30)
            {
                k = 0.5;
            }
            else
            {
                if (game.Person.Mood > 90)
                {
                    k = 1.5;
                }
            }

            game.Person.Income = (int)(k * game.Person.Jobs[game.Person.Job]);
            //0-30 mood: 0,5*income; 31-90: 1* income; 91-100: 1,5*income
        }
        public void Entertainment(GameMenu game, Entertainments entertainments)//1 - 5 dollars; 2 - 20 dollars; 3 - 30 dollars;
        {
            if (game.Person.Mood==100)
            {
                return;
            }
            switch (entertainments)
            {
                case Entertainments.VisitFriend:
                    if (game.Person.Money >= 5)
                    {
                        game.Person.Mood += 10;
                        game.Person.Money -= 5;
                        IncomeCalculate(game);
                    }
                    else
                    {
                        //Not enough money
                    }
                    break;
                case Entertainments.BathWithGirls:
                    if (game.Person.Money >= 20)
                    {
                        game.Person.Mood += 30;
                        game.Person.Money -= 20;
                        IncomeCalculate(game);
                    }
                    else
                    {
                        //Not enough money
                    }
                    break;
                case Entertainments.PlayGames:
                    if (game.Person.Money >= 30)
                    {
                        game.Person.Mood += 50;
                        game.Person.Money -= 30;
                        IncomeCalculate(game);
                    }
                    else
                    {
                        //Not enough money
                    }
                    break;
            }
            if (game.Person.Mood > 100)
            {
                game.Person.Mood = 100;
            }
        }
        public void NewJob(GameMenu game,int newJob)//Change if when status added
        {
            if (game.Person.Points >= 30 * (newJob - 1))
            {
                game.Person.Job = newJob;
                IncomeCalculate(game);
            }
            else
            {
                //Работа недоступна
            }
        }
        public void Taxes(GameMenu game)
        {
            int tax = game.Person.MonthIncome / 20;
            game.Person.Money -= tax;
        }
    }
}
