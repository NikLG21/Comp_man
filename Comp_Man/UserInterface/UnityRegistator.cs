using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Services;
using Common.DataAccess;
using Common.Model;
using Common.Services;
using DataAccess;
using Unity;
using Unity.Lifetime;

namespace UserInterface
{
    public static class UnityRegistator
    {
        public static IUnityContainer GetContainer()
        {
            IUnityContainer c = new UnityContainer();

            c.RegisterType<GameMenu>(new ContainerControlledLifetimeManager());

            c.RegisterType<IBssService, BssService>();
            c.RegisterType<IComputerService, ComputerService>();
            c.RegisterType<IPersonService, PersonService>();
            c.RegisterType<IHackingService, HackingService>();
            c.RegisterType<IVirusService, VirusService>();
            c.RegisterType<IGameService, GameService>();
            c.RegisterType<IStoreService, StoreService>();
            c.RegisterType<IConvertor, XmlConvertor>();
            c.RegisterType<IFileSystemStore, FileSystemStore>();

            c.RegisterType<ComputerForm>();
            c.RegisterType<BssForm>();
            c.RegisterType<HackingForm>();
            c.RegisterType<EntertainmentForm>();
            c.RegisterType<NewJobForm>();
            c.RegisterType<ProgramsForm>();
            c.RegisterType<SinsBssForm>();
            c.RegisterType<VirusForm>();
            c.RegisterType<HackingTaskForm>();

            return c;
        }
    }
}
