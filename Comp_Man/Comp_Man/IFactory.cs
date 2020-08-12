using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DataAccess;
using Common.Services;

namespace Common
{
    public interface IFactory
    {
        IVirusService CreateVirusService();
        IStoreService CreateStoreService();
        IPersonService CreatePersonService();
        IHackingService CreateHackingService();
        IComputerService CreateComputerService();
        IGameService CreateGameService();
        IBssService CreateBssService();
        IFileSystemStore CreateFileSystemStore();
        IConvertor CreateConvertor();
    }
}
