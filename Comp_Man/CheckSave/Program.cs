using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Services;
using Common.Model;

namespace CheckSave
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMenu game = new GameMenu();
            for (int i = 0; i < 54; i++)
            {
                (new GameService()) .NextTick(game);
            }
            (new StoreService()).Save(game, "C:\\Users\\Nikita\\Desktop\\save.xml");
            Console.ReadKey();
            for (int i = 0; i < 150; i++)
            {
                (new GameService()).NextTick(game);
            }

            game = (new StoreService().Load("C:\\Users\\Nikita\\Desktop\\save.xml"));
            Console.WriteLine(game.Time.ToString("O"));
            Console.ReadKey();

        }
    }
}
