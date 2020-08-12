using System;
using System.Globalization;
using System.Xml.Linq;
using Common.DataAccess;
using Common.Model;


namespace DataAccess
{
    public class XmlConvertor : IConvertor
    {
        public string Save(GameMenu game)
        {
            XElement root = new XElement("Root");
            XDocument document = new XDocument(root);
            XElement gameElement = new XElement("Game");
            root.Add(gameElement);

            XElement timeElement = new XElement("Time", game.Time.ToString("O"));
            
            //game.Time.ToString("yyyyMMddHHmmss");
            //DateTime.ParseExact(s, "O");
            //for (int i = 0; i < 4; i++)
            //{
            //    if (i == 0)
            //    {
            //        XAttribute attribute = new XAttribute("H", game.Time.Hour);
            //    }
            //    if (i == 1)
            //    {
            //        XAttribute attribute = new XAttribute("D", game.Time.Day);
            //    }
            //    if (i == 2)
            //    {
            //        XAttribute attribute = new XAttribute("M", game.Time.Month);
            //    }
            //    if (i == 3)
            //    {
            //        XAttribute attribute = new XAttribute("Y", game.Time.Year);
            //    }

            //}
            gameElement.Add(timeElement);
            

            XElement personElement = new XElement("Person");
            gameElement.Add(personElement);

            personElement.Add(new XElement("Money", game.Person.Money));
            personElement.Add(new XElement("Mood", game.Person.Mood));
            personElement.Add(new XElement("MonthIncome", game.Person.MonthIncome));
            personElement.Add(new XElement("Job", game.Person.Job));
            
            
            XElement computerElement = new XElement("Computer");
            gameElement.Add(computerElement);

            computerElement.Add(new XElement("Comp",game.Computer.Comp));
            computerElement.Add(new XElement("Memory", game.Computer.Memory));
            computerElement.Add(new XElement("HDD", game.Computer.HDD));
            computerElement.Add(new XElement("Modem", game.Computer.Modem));
            computerElement.Add(new XElement("Cd", game.Computer.Cd));
            computerElement.Add(new XElement("InstalSystem", game.Computer.InstalSystem));
            computerElement.Add(new XElement("InstalProgramming", game.Computer.InstalProgramming));
            computerElement.Add(new XElement("Antivirus", game.Computer.Antivirus));

            XElement bssElement = new XElement("BSS");
            gameElement.Add(bssElement);

            bssElement.Add(new XElement("MyBssInstaled", game.Bss.MyBssInstaled));
            bssElement.Add(new XElement("MbDownloaded", game.Bss.MbDownloaded));
            bssElement.Add(new XElement("MbUploaded", game.Bss.MbUploaded));
            bssElement.Add(new XElement("MbSoft", game.Bss.MbSoft));

            XElement hackingElement = new XElement("Hacking");
            gameElement.Add(hackingElement);

            hackingElement.Add(new XElement("PasswordCrack", game.Hacking.PasswordCrack));
            hackingElement.Add(new XElement("SystemAccessCrack", game.Hacking.SystemAccessCrack));
            hackingElement.Add(new XElement("Disguise", game.Hacking.Disguise));
            hackingElement.Add(new XElement("SuperDisguise", game.Hacking.SuperDisguise));
            hackingElement.Add(new XElement("BombFile", game.Hacking.BombFile));
            hackingElement.Add(new XElement("NetworkVirus", game.Hacking.NetworkVirus));
            hackingElement.Add(new XElement("NetworkAntivirus", game.Hacking.NetworkAntivirus));
            hackingElement.Add(new XElement("HackingPoints", game.Hacking.HackingPoints));
            hackingElement.Add(new XElement("SuccessfulHack", game.Hacking.SuccessfulHack));

            XElement virusElement = new XElement("Virus");
            gameElement.Add(virusElement);

            virusElement.Add(new XElement("CurrentChance", game.Virus.CurrentChance));

            return document.ToString();
        }

        public GameMenu Load(XDocument document)
        {
            GameMenu game = new GameMenu();
            XElement gameElement = document.Element("Root").Element("Game");
            XElement timeElement = gameElement.Element("Time");
            IFormatProvider provider = new DateTimeFormatInfo();
            game.Time = DateTime.ParseExact(timeElement.Value, "O",provider);

            XElement personElement = gameElement.Element("Person");
            game.Person.Money = Int32.Parse(personElement.Element("Money").Value);
            game.Person.Mood = Int32.Parse(personElement.Element("Mood").Value);
            game.Person.MonthIncome = Int32.Parse(personElement.Element("MonthIncome").Value);
            game.Person.Job = Int32.Parse(personElement.Element("Job").Value);
            

            XElement computerElement = gameElement.Element("Computer");
            game.Computer.Comp = Int32.Parse(computerElement.Element("Comp").Value);
            game.Computer.Memory = Int32.Parse(computerElement.Element("Memory").Value);
            game.Computer.HDD = Int32.Parse(computerElement.Element("HDD").Value);
            game.Computer.Modem = Int32.Parse(computerElement.Element("Modem").Value);
            game.Computer.Cd = Int32.Parse(computerElement.Element("Cd").Value);
            game.Computer.InstalSystem = Int32.Parse(computerElement.Element("InstalSystem").Value);
            game.Computer.InstalProgramming = Int32.Parse(computerElement.Element("InstalProgramming").Value);
            game.Computer.Antivirus = Int32.Parse(computerElement.Element("Antivirus").Value);

            XElement bssElement = gameElement.Element("BSS");
            game.Bss.MyBssInstaled = Boolean.Parse(bssElement.Element("MyBssInstaled").Value);
            game.Bss.MbDownloaded = Int32.Parse(bssElement.Element("MbDownloaded").Value);
            game.Bss.MbUploaded = Int32.Parse(bssElement.Element("MbUploaded").Value);
            game.Bss.MbSoft = Int32.Parse(bssElement.Element("MbSoft").Value);

            XElement hackingElement = gameElement.Element("Hacking");
            game.Hacking.PasswordCrack = Boolean.Parse(hackingElement.Element("PasswordCrack").Value);
            game.Hacking.SystemAccessCrack = Boolean.Parse(hackingElement.Element("SystemAccessCrack").Value);
            game.Hacking.Disguise = Boolean.Parse(hackingElement.Element("Disguise").Value);
            game.Hacking.SuperDisguise = Boolean.Parse(hackingElement.Element("SuperDisguise").Value);
            game.Hacking.BombFile = Boolean.Parse(hackingElement.Element("BombFile").Value);
            game.Hacking.NetworkVirus = Boolean.Parse(hackingElement.Element("NetworkVirus").Value);
            game.Hacking.NetworkAntivirus = Boolean.Parse(hackingElement.Element("NetworkAntivirus").Value);
            game.Hacking.HackingPoints = Int32.Parse(hackingElement.Element("HackingPoints").Value);
            
            game.Virus.CurrentChance = Int32.Parse(gameElement.Element("Virus").Element("CurrentChance").Value);



            return game;
        }
    }
}
