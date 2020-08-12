using Common.Model;
using Common.Model.Enum;
using UserInterface;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace DataAccessTests
{
    
    public class ServicesTest
    {
        private GameMenu game = new GameMenu();
        private GameMenu game1 = new GameMenu();
        Factory factory = new Factory();
        [Fact]
        public void TestTick()
        {
            for (int i = 0; i < 49; i++)
            {
                factory.CreateGameService().NextTick(game);
            }
            Assert.AreEqual(46, game.Person.Mood);
        }

        [Fact]
        public void TestStoreService()
        {
            for (int i = 0; i < 49; i++)
            {
                factory.CreateGameService().NextTick(game);
            }
            factory.CreateStoreService().Save(game, "C:\\Users\\Nikita\\Desktop\\1.xml");
            factory.CreateStoreService().Load(game1, "C:\\Users\\Nikita\\Desktop\\1.xml");
            Assert.AreEqual(game.Person.Mood, game1.Person.Mood);
        }

        [Fact]
        public void TestIncome()
        {
            game.Person.Mood = 95;
            factory.CreatePersonService().NewJob(game, 1);
            Assert.AreEqual(15, game.Person.Income);
            game.Person.Mood = 8;
            factory.CreatePersonService().IncomeCalculate(game);
            Assert.AreNotEqual(10, game.Person.Income);
        }

        [Fact]
        public void TestEntertainment()
        {
            factory.CreatePersonService().Entertainment(game, Entertainments.VisitFriend);
            Assert.AreEqual(55, game.Person.Money);
            Assert.AreEqual(60, game.Person.Mood);
        }

        [Fact]
        public void TestHackingExchange()
        {
            factory.CreateHackingService().ProgramExchange(game, HackingPrograms.PasswordCrack);
            Assert.AreEqual(30, game.Person.Money);
            Assert.AreEqual(true, game.Hacking.PasswordCrack);
        }

        [Fact]
        public void TestTaskPick()
        {
            int i = factory.CreateHackingService().HackingTasksPick(game);
            Assert.AreEqual(3, i);
        }

        [Fact]
        public void TestCompBuy()
        {
            game.Person.Money = 1000;
            factory.CreateComputerService().BuyingComputer(game, Hardware.Comp);
            factory.CreateComputerService().BuyingComputer(game, Hardware.Comp);
            Assert.AreEqual(2, game.Computer.Comp);
        }

        [Fact]
        public void TestSystemInstal()
        {
            factory.CreateComputerService().Install(game, Programs.System, 1);
            Assert.AreEqual(0, game.Computer.InstalSystem);
        }

        [Fact]
        public void TestUpload()
        {
            factory.CreateBssService().UploadToSinsBss(game);
            Assert.AreNotEqual(0, game.Bss.Uploaded);
        }

        [Fact]
        public void TestVirus()
        {
            game.Virus.RandomChance = 80;
            game.Bss.MyBssInstaled = true;
            factory.CreateVirusService().VirusWon(game);
            Assert.AreEqual(false, game.Bss.MyBssInstaled);
        }

    }
}
