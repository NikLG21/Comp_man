namespace Common.Model
{
    public class Computer
    {
        //private string[] comps = new string[] {"no computer","1st computer","2nd computer","3rd computer","4th computer"};
        //private string[] memories = new string[] {};// 5 вариантов памяти
        //private string[] vinchester = new string[] { };
        //private string[] modems = new string[] { };
        //private string[] cds = new string[] { };
        private int _comp;
        private int _memory; 
        private int _hdd; 
        private int _modem;
        private int _cd;
        private int _instalSystem;
        private int _instalProgramming;
        private int _antivirus;

        public int Comp
        {
            get { return _comp;}
            set { _comp = value; }
        }
        public int Memory
        {
            get { return _memory; }
            set { _memory = value; }
        }
        public int HDD
        {
            get { return _hdd; }
            set { _hdd = value; }
        }
        public int Modem
        {
            get { return _modem; }
            set { _modem = value; }
        }
        public int Cd
        {
            get { return _cd; }
            set { _cd = value; }
        }
        public int InstalSystem
        {
            get { return _instalSystem; }
            set { _instalSystem = value; }
        }
        public int InstalProgramming
        {
            get { return _instalProgramming; }
            set { _instalProgramming = value; }
        }

        public int Antivirus
        {
            get { return _antivirus; }
            set { _antivirus = value; }
        }

        public Computer()
        {
            _comp = 0;
            _memory = 0;
            _hdd = 0;
            _modem = 0;
            _cd = 0;
            _instalSystem = 0;
            _instalProgramming = 0;
        }
    }
}
