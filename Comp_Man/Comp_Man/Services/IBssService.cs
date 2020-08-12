using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace Common.Services
{
    public interface IBssService
    {
        void MakeMyBss(GameMenu game);
        void CheckConnectionEnabled(GameMenu game);
        void ConnectToSinsBss(GameMenu game);
        void DownloadFromSinsBss(GameMenu game);
        void UploadToSinsBss(GameMenu game);
        void MySoftAddMb(GameMenu game, int mb);
    }
}
