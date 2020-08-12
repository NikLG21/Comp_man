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

namespace UserInterface
{
    public partial class ProgramsForm : Form
    {
        private GameMenu _game;
        private IComputerService computerService;
        public ProgramsForm(GameMenu game, IComputerService computerService)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            _game = game;
            this.computerService = computerService;
        }

        private void system1Button_Click(object sender, EventArgs e)
        {
            computerService.Install(_game, Programs.System, 1);
        }

        private void system2Button_Click(object sender, EventArgs e)
        {
            computerService.Install(_game, Programs.System, 2);
        }

        private void system3Button_Click(object sender, EventArgs e)
        {
            computerService.Install(_game, Programs.System, 3);
        }

        private void system4Button_Click(object sender, EventArgs e)
        {
            computerService.Install(_game, Programs.System, 4);
        }

        private void programming1Button_Click(object sender, EventArgs e)
        {
            computerService.Install(_game, Programs.Programming, 1);
        }

        private void programming2Button_Click(object sender, EventArgs e)
        {
            computerService.Install(_game, Programs.Programming, 2);
        }

        private void programming3Button_Click(object sender, EventArgs e)
        {
            computerService.Install(_game, Programs.Programming, 3);
        }

        private void programming4Button_Click(object sender, EventArgs e)
        {
            computerService.Install(_game, Programs.Programming, 4);
        }
    }
}
