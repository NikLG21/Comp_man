using System;
using Common.Dictionaries;

namespace Common.Model
{
    public class GameMenu
    {
        private Computer computer;
        private Person person;
        private Hacking hacking;
        private Virus virus;
        private Bss bss;
        private bool gameOnOff;
        private DateTime time;
        private HackingTaskDictionary hackingTaskDictionary;

        public GameMenu()
        {
            person = new Person();
            computer = new Computer();
            hacking = new Hacking();
            virus = new Virus();
            bss = new Bss();
            hackingTaskDictionary = new HackingTaskDictionary();
            time = DateTime.Parse("2020-07-01T00:00:00.0000000+03:00");
            gameOnOff = true;
        }
        
        public Computer Computer
        {
            get { return computer; }
            set { computer = value; }
        }

        public Person Person
        {
            get { return person; }
            set { person = value; }
        }

        public Hacking Hacking
        {
            get { return hacking; }
            set { hacking = value; }
        }

        public Virus Virus
        {
            get { return virus; }
            set { virus = value; }
        }

        public Bss Bss
        {
            get { return bss; }
            set { bss = value; }
        }

        public bool GameOnOff
        {
            get { return gameOnOff; }
            set { gameOnOff = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public HackingTaskDictionary HackingTaskDictionary
        {
            get => hackingTaskDictionary;
            set => hackingTaskDictionary = value;
        }
    }
}
