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
    public partial class NewJobForm : Form
    {
        private GameMenu _game;
        private IPersonService personService;
        public NewJobForm(GameMenu game, IPersonService personService)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            _game = game;
            this.personService = personService;
            job1Button.Text = "Janitor: " + _game.Person.Jobs[1];
            job2Button.Text = "Locksmith: " + _game.Person.Jobs[2];
            job3Button.Text = "Programmer: " + _game.Person.Jobs[3];
            job4Button.Text = "Sysadmin: " + _game.Person.Jobs[4];
            job5Button.Text = "Super hacker: " + _game.Person.Jobs[5];
        }

        private void job1Button_Click(object sender, EventArgs e)
        {
            personService.NewJob(_game, 1);
        }

        private void job2Button_Click(object sender, EventArgs e)
        {
            personService.NewJob(_game, 2);
        }

        private void job3Button_Click(object sender, EventArgs e)
        {
            personService.NewJob(_game, 3);
        }

        private void job4Button_Click(object sender, EventArgs e)
        {
            personService.NewJob(_game, 4);
        }

        private void job5Button_Click(object sender, EventArgs e)
        {
            personService.NewJob(_game, 5);
        }

        private void NewJobForm_Load(object sender, EventArgs e)
        {

        }
    }
}
