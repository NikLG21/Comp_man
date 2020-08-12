using System.Collections.Generic;
using Common.Model.Enum;

namespace Common.Model
{
    public class Hacking
    {
        private bool _hackingEnabled;
        private int _hackingPoints;
        private bool _passwordCrack;
        private bool _systemAccessCrack;
        private bool _disguise;
        private bool _superDisguise;
        private bool _bombFile;
        private bool _networkVirus;
        private bool _networkAntivirus;
        private int _successfulHack;
        private List<HackingTask> hackingTasks;

        public Hacking()
        {
            _hackingEnabled = false;
            _hackingPoints = 0;
            _passwordCrack = false;
            _systemAccessCrack = false;
            _disguise = false;
            _superDisguise = false;
            _bombFile = false;
            _networkAntivirus = false;
            _networkVirus = false;
            _successfulHack = 0;
            hackingTasks = new List<HackingTask>();
            hackingTasks.Add(new HackingTask(HackingPrograms.SystemAccessCrack, HackingPrograms.Null, 2, new []{20},
                "It's your first task. Get access to this computer"));
            hackingTasks.Add(new HackingTask(HackingPrograms.Disguise, HackingPrograms.Null, 3, new[] {30,70,150},
                "Try to steal money from this usual bank"));
            hackingTasks.Add(new HackingTask(HackingPrograms.SuperDisguise, HackingPrograms.Null, 5, new[] { 50, 115, 250 },
                "This bank has good defence but you can do this with very good disguise"));
            hackingTasks.Add(new HackingTask(HackingPrograms.SystemAccessCrack, HackingPrograms.BombFile, 5, new[] { 30 },
            "This is an order to destroy system with bomb file. Customer will pay 30"));
            hackingTasks.Add(new HackingTask(HackingPrograms.Disguise, HackingPrograms.NetworkVirus, 5, new[] { 40 },
                "This is an order to put network virus in this computer. Customer will pau 40"));
            hackingTasks.Add(new HackingTask(HackingPrograms.NetwokAntivirus, HackingPrograms.Null, 7, new[] { 100, 250, 600 },
                "It is the best bank that you gave ever met. Try to steal money from them"));
            
        }

        public int SuccessfulHack
        {
            get => _successfulHack;
            set => _successfulHack = value;
        }

        public int HackingPoints
        {
            get => _hackingPoints;
            set => _hackingPoints = value;
        }

        public bool PasswordCrack
        {
            get => _passwordCrack;
            set => _passwordCrack = value;
        }

        public bool SystemAccessCrack
        {
            get => _systemAccessCrack;
            set => _systemAccessCrack = value;
        }

        public bool Disguise
        {
            get => _disguise;
            set => _disguise = value;
        }

        public bool SuperDisguise
        {
            get => _superDisguise;
            set => _superDisguise = value;
        }

        public bool BombFile
        {
            get => _bombFile;
            set => _bombFile = value;
        }

        public bool NetworkVirus
        {
            get => _networkVirus;
            set => _networkVirus = value;
        }

        public bool NetworkAntivirus
        {
            get => _networkAntivirus;
            set => _networkAntivirus = value;
        }

        public bool HackingEnabled
        {
            get => _hackingEnabled;
            set => _hackingEnabled = value;
        }

        public List<HackingTask> HackingTasks
        {
            get => hackingTasks;
            set => hackingTasks = value;
        }
    }
}
