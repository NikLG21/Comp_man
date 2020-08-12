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
    public partial class EntertainmentForm : Form
    {
        private GameMenu _game;
        private IPersonService personService;
        public EntertainmentForm(GameMenu game, IPersonService personService)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            _game = game;
            this.personService = personService;
        }

        private void entertainment1Button_Click(object sender, EventArgs e)
        {
            personService.Entertainment(_game, Entertainments.VisitFriend);
        }

        private void entertainment2Button_Click(object sender, EventArgs e)
        {
            personService.Entertainment(_game, Entertainments.BathWithGirls);
        }

        private void entertainment3Button_Click(object sender, EventArgs e)
        {
            personService.Entertainment(_game, Entertainments.PlayGames);
        }
    }
}
