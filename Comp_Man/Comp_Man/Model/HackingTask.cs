using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model.Enum;

namespace Common.Model
{
    public class HackingTask
    {
        private HackingPrograms zeroProgram;
        private HackingPrograms firstProgram;
        private HackingPrograms secondProgram;
        private bool _zeroProgramUsed;
        private bool firstProgramUsed;
        private bool secondProgramUsed;
        private int pointsEarned;
        private int[] moneyEarned;
        private string description;

        

        public HackingTask(HackingPrograms firstProgram, HackingPrograms secondProgram, int pointsEarned, int[] moneyEarned, string description)
        {
            zeroProgram = HackingPrograms.PasswordCrack;
            _zeroProgramUsed = false;
            firstProgramUsed = false;
            secondProgramUsed = false;
            this.firstProgram = firstProgram;
            this.secondProgram = secondProgram;
            this.pointsEarned = pointsEarned;
            this.moneyEarned = moneyEarned;
            this.description = description;
            
        }

        public HackingPrograms FirstProgram
        {
            get => firstProgram;
        }

        public HackingPrograms SeconProgram
        {
            get => secondProgram;
        }

        public int PointsEarned
        {
            get => pointsEarned;
        }

        public int[] MoneyEarned
        {
            get => moneyEarned;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public HackingPrograms ZeroProgram
        {
            get => zeroProgram;
        }

        public bool ZeroProgramUsed
        {
            get => _zeroProgramUsed;
            set => _zeroProgramUsed = value;
        }

        public bool FirstProgramUsed
        {
            get => firstProgramUsed;
            set => firstProgramUsed = value;
        }

        public bool SecondProgramUsed
        {
            get => secondProgramUsed;
            set => secondProgramUsed = value;
        }
    }
}
