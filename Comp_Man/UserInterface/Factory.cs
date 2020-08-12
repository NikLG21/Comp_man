using Business.Services;
using Common;
using Common.DataAccess;
using Common.Services;
using DataAccess;

namespace UserInterface
{
    public class Factory : IFactory
    {
        public IConvertor CreateConvertor()
        {
            return new XmlConvertor();
        }
        public IFileSystemStore CreateFileSystemStore()
        {
            return new FileSystemStore();
        }
        public IBssService CreateBssService()
        {
            return new BssService(this.CreatePersonService());
        }
        public IGameService CreateGameService()
        {
            return new GameService(this.CreateBssService(),this.CreateVirusService(), this.CreatePersonService());
        }
        public IComputerService CreateComputerService()
        {
            return new ComputerService(this.CreatePersonService());
        }
        public IHackingService CreateHackingService()
        {
            return new HackingService();
        }
        public IPersonService CreatePersonService()
        {
            return new PersonService(this.CreateHackingService());
        }
        public IStoreService CreateStoreService()
        {
            return new StoreService(this.CreateConvertor(), this.CreateFileSystemStore(), this.CreatePersonService(), this.CreateHackingService());
        }
        public IVirusService CreateVirusService()
        {
            return new VirusService();
        }
        
    }
}
