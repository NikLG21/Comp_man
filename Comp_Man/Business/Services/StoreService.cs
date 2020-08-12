using System.Xml.Linq;
using Common;
using Common.DataAccess;
using Common.Extensions;
using Common.Model;
using Common.Services;
using DataAccess;

namespace Business.Services
{
    public class StoreService : IStoreService
    {
        
        private IConvertor convertor;
        private IFileSystemStore fileSystemStore;
        private IPersonService personService;
        private IHackingService hackingService;

        public StoreService(IConvertor convertor, IFileSystemStore fileSystemStore, IPersonService personService, IHackingService hackingService)
        {
            this.convertor = convertor;
            this.fileSystemStore = fileSystemStore;
            this.personService = personService;
            this.hackingService = hackingService;
        }

        public void Save(GameMenu game, string filePath)
        {
            string xml = convertor.Save(game);
            fileSystemStore.Save(xml,filePath);
        }

        public void Load(GameMenu main, string filePath)
        {
            XDocument document = XDocument.Parse(fileSystemStore.Load(filePath));
            GameMenu game = convertor.Load(document);
            main.DeepCopy(game);
            personService.IncomeCalculate(main);
            personService.PointsCalculate(main);
            hackingService.CheckHackingEnabled(main);
        }
    }
}
