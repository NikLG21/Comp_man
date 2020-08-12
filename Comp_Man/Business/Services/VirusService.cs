using System;
using Common;
using Common.Model;
using Common.Services;

namespace Business.Services
{
    public class VirusService : IVirusService
    {
        
        public void CalculateChance(GameMenu game)
        {
            game.Virus.CurrentChance += 4;
            if (game.Virus.CurrentChance > 100)
            {
                game.Virus.CurrentChance = 100; ;
            }
        }

        public void VirusActivation(GameMenu game)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            game.Virus.RandomChance = rand.Next(0, game.Virus.CurrentChance);
            if(game.Virus.RandomChance<50)
            {
                game.Virus.VirusActivated = false;
            }
            else
            {
                game.Virus.VirusActivated = true; 
            }
        }

        public void TryVirusKill(GameMenu game)
        {
            if (game.Virus.RandomChance < game.Computer.Antivirus)
            {
                //game.Virus.RandomChance = 0;
                game.Virus.VirusActivated = false;
                //Virus Lost
            }

        }

        public void VirusWon(GameMenu game)
        {
            
            if(game.Virus.RandomChance<65)
            {
                game.Bss.DeletedMb = (int) (game.Bss.MbSoft * 0.2);
                game.Bss.MbSoft -= game.Bss.DeletedMb;
                //delete some MB
            }
            else
            {
                if(game.Virus.RandomChance<80)
                {
                    //delete many MB
                    game.Bss.DeletedMb = (int)(game.Bss.MbSoft * 0.5);
                    game.Bss.MbSoft -= game.Bss.DeletedMb;
                }
                else
                {
                    if(game.Virus.RandomChance<90)
                    {
                        game.Bss.MyBssInstaled = false;
                        //delete My BBS
                    }
                    else
                    {
                        game.Bss.MyBssInstaled = false;
                        game.Computer.Antivirus = 0;
                        //delete antivirus + my BBS
                    }
                }
            }
            //game.Virus.RandomChance = 0;
            game.Virus.VirusActivated = false;
        }
    }
}
