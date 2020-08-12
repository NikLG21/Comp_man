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
using Common.Services;

namespace UserInterface
{
    public partial class VirusForm : Form
    {
        private GameMenu _game;
        private IVirusService virusService;
        public VirusForm(GameMenu game, IVirusService virusService)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            _game = game;
            this.virusService = virusService;
            textBox.Text = "Virus attack";
        }

        private void tryVirusKill_Click(object sender, EventArgs e)
        {
            virusService.TryVirusKill(_game);
            if (_game.Virus.VirusActivated)
            {
                virusAttack_Click(sender, e);
            }
            else
            {
                textBox.Text = "Antivirus won";
            }

        }

        private void virusAttack_Click(object sender, EventArgs e)
        {
            virusService.VirusWon(_game);
            textBox.Text = "Virus won";
        }
    }
}
