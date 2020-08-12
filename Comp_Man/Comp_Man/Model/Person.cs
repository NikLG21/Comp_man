namespace Common.Model
{
    public class Person
    {
        private int _money;
        private int _points;
        private int _mood;
        private int _income;
        private int _monthIncome;
        private int _job;
        private int[] jobs = new[] {0, 10, 20, 30, 50, 70};

        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }
        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }
        public int Income
        {
            get { return _income; }
            set { _income = value; }
        }
        public int Mood
        {
            get { return _mood; }
            set { _mood = value; }
        }
        public int MonthIncome
        {
            get { return _monthIncome; }
            set { _monthIncome = value; }
        }

        public int Job
        {
            get { return _job; }
            set { _job = value; }
        }
        public int[] Jobs
        {
            get { return jobs; }
        }

        public Person()
        {
            _money = 60;
            _points = 0;
            _mood = 50;
            _income = 0;
            _job = 0;
            _monthIncome = 0;
        }
     
    }
}
