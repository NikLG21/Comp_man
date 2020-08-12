namespace Common.Model
{
    public class Virus
    {
        private int _currentChance;
        private int _randomChance;
        private bool _virusActivated;
        
        public Virus()
        {
            _currentChance = 60;
            _randomChance = 0;
            _virusActivated = false;
        }
        public int CurrentChance
        {
            get { return _currentChance; }
            set { _currentChance = value; }
        }
        public int RandomChance
        {
            get { return _randomChance; }
            set { _randomChance = value; }
        }
        public bool VirusActivated
        {
            get { return _virusActivated; }
            set { _virusActivated = value; }
        }
    }
}
