using System;
using Common;
using Common.Model;
using Common.Services;

namespace Business.Services
{
    public class BssService : IBssService
    {
        private IPersonService _personService;

        public BssService(IPersonService personService)
        {
            this._personService = personService;

        }

        public void MakeMyBss(GameMenu game)
        {
            if (game.Computer.Comp != 0 && game.Computer.Memory != 0 && game.Computer.HDD != 0 && game.Computer.Modem != 0)
            {
                game.Bss.MyBssInstaled = true;
            }

            _personService.PointsCalculate(game);
        }

        public void CheckConnectionEnabled(GameMenu game)
        {
            if (game.Computer.Comp != 0 && game.Computer.Memory != 0 && game.Computer.HDD != 0 && game.Computer.Modem != 0)
            {
                game.Bss.ConnectionEnabled = true;
            }
        }

        public void ConnectToSinsBss(GameMenu game)
        {
            if(game.Bss.ConnectionEnabled)
            {
                game.Bss.Connected = true;
                game.Bss.Uploaded = false;
                game.Bss.Downloaded = false;
            }
        }

        public void DownloadFromSinsBss(GameMenu game)
        {
            Random rand = new Random();
            int random = rand.Next(1, 10);
            if (random < 8)
            {
                game.Bss.MbDownloaded += random;
                MySoftAddMb(game, random);
            }
            else
            {
                game.Computer.Antivirus = random * 8;
                // Antivirus downloaded
            }
            game.Bss.Downloaded = true;
        }

        public void UploadToSinsBss(GameMenu game)
        {
            Random rand = new Random();
            int random = rand.Next(1, 5);
            game.Bss.MbUploaded += random;
            MySoftAddMb(game, random);
            game.Bss.Uploaded = true;
        }

        public void MySoftAddMb(GameMenu game, int mb)
        {
            game.Bss.MbSoft += mb;
            if (game.Bss.MbSoft > game.Computer.HDD * 50)
            {
                game.Bss.MbSoft = game.Computer.HDD * 50;
            }
        }


    }
}
