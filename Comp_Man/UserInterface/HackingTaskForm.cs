using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Model;
using Common.Model.Enum;
using Common.Services;

namespace UserInterface
{
    public partial class HackingTaskForm : Form
    {
        private GameMenu _game;
        private IHackingService _hackingService;
        private int task;
        private int part;
        public HackingTaskForm(GameMenu game, IHackingService hackingService)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            _game = game;
            _hackingService = hackingService;
            task = _hackingService.HackingTasksPick(_game);
            part = -1;
            DataUpdate();
        }
        private void ThisPartCheck()
        {
            switch (part)
            {
                case 0:
                    if (_game.Hacking.HackingTasks[task].ZeroProgramUsed)
                    {
                        part++;
                    }
                    else
                    {
                        part = -2;
                    }
                    break;
                case 1:
                    if (_game.Hacking.HackingTasks[task].FirstProgramUsed)
                    {
                        part++;
                        MoneyButtonsCheck();
                    }
                    else
                    {
                        part = -2;
                    }
                    break;
                case 2:
                    if (_game.Hacking.HackingTasks[task].SecondProgramUsed)
                    {
                        DataUpdate();
                    }
                    else
                    {
                        part = -2;
                    }
                    break;
            }
            DataUpdate();

        }

        private void DataUpdate()
        {
            string[] lines = new string[5] ;
            switch (part)
            {
                case -2:

                    break;
                case -1:
                    
                    break;
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;

            }
        }

        private void CheckPrograms()
        {
            if (_game.Hacking.PasswordCrack)
            {
                passwordCrackButton.Enabled = true;
            }
            if (_game.Hacking.SystemAccessCrack)
            {
                systemAccessCrackButton.Enabled = true;
            }
            if (_game.Hacking.Disguise)
            {
                disguiseButton.Enabled = true;
            }
            if (_game.Hacking.SuperDisguise)
            {
                superDisguiseButton.Enabled = true;
            }
            if (_game.Hacking.BombFile)
            {
                bombFileButton.Enabled = true;
            }
            if (_game.Hacking.NetworkVirus)
            {
                networkVirusButton.Enabled = true;
            }
            if (_game.Hacking.NetworkAntivirus)
            {
                networkAntivirusButton.Enabled = true;
            }
        }

        private void MoneyButtonsCheck()
        {
            if (_game.Hacking.HackingTasks[task].MoneyEarned.Length == 3)
            {
                money1Button.Enabled = true;
                money2Button.Enabled = true;
                money3Button.Enabled = true;
                money1Button.Text = _game.Hacking.HackingTasks[task].MoneyEarned[0].ToString();
                money2Button.Text = _game.Hacking.HackingTasks[task].MoneyEarned[1].ToString();
                money3Button.Text = _game.Hacking.HackingTasks[task].MoneyEarned[2].ToString();

            }
        }

        private void takeTaskButton_Click(object sender, EventArgs e)
        {
            CheckPrograms();
            part = 0;
        }

        private void rejectTaskButton_Click(object sender, EventArgs e)
        {
            task = _hackingService.HackingTasksPick(_game);
            part = -1;
        }
        
        private void passwordCrackButton_Click(object sender, EventArgs e)
        {
            _hackingService.HackingDoing(_game,task,part, HackingPrograms.PasswordCrack, 0);
            ThisPartCheck();
        }

        private void systemAccessCrackButton_Click(object sender, EventArgs e)
        {
            _hackingService.HackingDoing(_game, task, part, HackingPrograms.SystemAccessCrack, 0);
            ThisPartCheck();
        }

        private void disguiseButton_Click(object sender, EventArgs e)
        {
            _hackingService.HackingDoing(_game, task, part, HackingPrograms.Disguise, 0);
            ThisPartCheck();
        }

        private void superDisguiseButton_Click(object sender, EventArgs e)
        {
            _hackingService.HackingDoing(_game, task, part, HackingPrograms.SuperDisguise, 0);
            ThisPartCheck();
        }

        private void bombFileButton_Click(object sender, EventArgs e)
        {
            _hackingService.HackingDoing(_game, task, part, HackingPrograms.BombFile, 0);
            ThisPartCheck();
        }

        private void networkAntivirusButton_Click(object sender, EventArgs e)
        {
            _hackingService.HackingDoing(_game, task, part, HackingPrograms.NetwokAntivirus, 0);
            ThisPartCheck();
        }

        private void networkVirusButton_Click(object sender, EventArgs e)
        {
            _hackingService.HackingDoing(_game, task, part, HackingPrograms.NetworkVirus, 0);
            ThisPartCheck();
        }


    }
}
