using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Model;
using Common.Services;
using Unity;

namespace UserInterface
{
    public partial class HackingForm : Form
    {
        private GameMenu _game;
        private IHackingService hackingService;
        private IUnityContainer container;
        public HackingForm(GameMenu game, IHackingService hackingService)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            _game = game;
            this.hackingService = hackingService;
            container = UnityRegistator.GetContainer();
            HackingUpdate();
        }

        private void hackingProgramsButton_Click(object sender, EventArgs e)
        {
            //Business write
        }

        private void exchangeProgramsButton_Click(object sender, EventArgs e)
        {
            //Business write
        }

        private void HackingTasks_Click(object sender, EventArgs e)
        {
            HackingTaskForm hackingTaskForm = container.Resolve<HackingTaskForm>();
            hackingTaskForm.ShowDialog();
        }

        private void HackingUpdate()
        {
            hackingTextBox.Text = "Hacking Points: " + _game.Hacking.HackingPoints;
        }
    }
}
