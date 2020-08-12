using Common;
using Common.Model;
using Common.Services;

namespace Business.Services
{
    public class GameService : IGameService
    {
        private IBssService bssService;
        private IVirusService virusService;
        private IPersonService personService;
        public GameService(IBssService bssService, IVirusService virusService, IPersonService personService)
        {
            this.personService = personService;
            this.bssService = bssService;
            this.virusService = virusService;
        }

        public void NextTick(GameMenu game)
        {
            game.Time = game.Time.AddHours(1);
            if (game.Time.Hour == 0)
            {
                bssService.MySoftAddMb(game, 1);

                game.Person.Money += game.Person.Income;
                game.Person.MonthIncome += game.Person.Income;
                game.Person.Mood -= 2;
                if (game.Person.Mood == 0)
                {
                    game.GameOnOff = false;
                    //Game over: death
                }

                /*if ()условие победы
                {
                    
                }*/
                virusService.CalculateChance(game);
                
                if (game.Time.Day == 1)
                {
                    personService.Taxes(game);
                    game.Person.MonthIncome = 0;
                }

            }
        
        }
    }
}
