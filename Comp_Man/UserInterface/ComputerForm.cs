using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Services;
using Common;
using Common.Model;
using Common.Model.Enum;
using Common.Services;
using Unity;

namespace UserInterface
{
    public partial class ComputerForm : Form
    {
        private GameMenu _game;
        private IComputerService computerService;
        
        public ComputerForm(GameMenu game, IComputerService computerService)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            _game = game;
            this.computerService = computerService;
            compUpgrade.Text = "Comp: "+(_game.Computer.Comp+1);
            memoryUpgrade.Text = "Memory: " + (_game.Computer.Memory+1);
            hddUpgrade.Text = "HDD: " + (_game.Computer.HDD+1);
            modemUpgrade.Text = "Modem: " + (_game.Computer.Modem+1);
            cdUpgrade.Text = "Cd: " + (_game.Computer.Cd+1);
        }

        private void compUpgrade_Click(object sender, EventArgs e)
        {
            computerService.BuyingComputer(_game, Hardware.Comp);
            compUpgrade.Text = "Comp: " + (_game.Computer.Comp + 1);
        }

        private void memoryUpgrade_Click(object sender, EventArgs e)
        {
            computerService.BuyingComputer(_game, Hardware.Memory);
            memoryUpgrade.Text = "Memory: " + (_game.Computer.Memory + 1);
        }

        private void hddUpgrade_Click(object sender, EventArgs e)
        {
            computerService.BuyingComputer(_game, Hardware.Hdd);
            hddUpgrade.Text = "HDD: " + (_game.Computer.HDD + 1);
        }

        private void modemUpgrade_Click(object sender, EventArgs e)
        {
            computerService.BuyingComputer(_game, Hardware.Modem);
            modemUpgrade.Text = "Modem: " + (_game.Computer.Modem + 1);
        }

        private void cdUpgrade_Click(object sender, EventArgs e)
        {
            computerService.BuyingComputer(_game, Hardware.Cd);
            cdUpgrade.Text = "Cd: " + (_game.Computer.Cd + 1);
        }
    }
}
