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
using Unity;

namespace UserInterface
{
    public partial class BssForm : Form
    {
        private GameMenu _game;
        private IBssService bssService;
        private IUnityContainer container;
        public BssForm(GameMenu game, IBssService bssService)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            _game = game;
            this.bssService = bssService;
            container = UnityRegistator.GetContainer();
            if (_game.Bss.MyBssInstaled)
            {
                makeMyBss.Enabled = false;
            }
        }


        private void connectBssButton_Click(object sender, EventArgs e)
        {
            bssService.ConnectToSinsBss(_game);
            if (_game.Bss.Connected)
            {
                SinsBssForm sinsBssForm = container.Resolve<SinsBssForm>();
                //SinsBssForm sinsBssForm = new SinsBssForm(_game, bssService);
                sinsBssForm.ShowDialog();
            }

        }

        private void makeMyBss_Click(object sender, EventArgs e)
        {
            bssService.MakeMyBss(_game);
        }
    }
}
