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
    public partial class SinsBssForm : Form
    {
        private GameMenu _game;
        private IBssService bssService;
        public SinsBssForm(GameMenu game, IBssService bssService)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            _game = game;
            this.bssService = bssService;
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            bssService.DownloadFromSinsBss(_game);
            downloadButton.Enabled = false;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            bssService.UploadToSinsBss(_game);
            uploadButton.Enabled = false;
        }
    }
}
