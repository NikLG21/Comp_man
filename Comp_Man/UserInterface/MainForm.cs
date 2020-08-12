using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Services;
using Common;
using Common.Model;
using Common.Services;
using Unity;
using Timer = System.Threading.Timer;

namespace UserInterface
{
    public partial class MainForm : Form
    {
        private delegate void MyDel();

        private GameMenu game;
        private bool gameOnOff;
        private Timer _timer;
        private string filePath;

        private IFactory factory = new Factory();

        private IUnityContainer container;

        public MainForm()
        {
            InitializeComponent();
            container = UnityRegistator.GetContainer();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            gameOnOff = true;
            _timer = new Timer(TimerTick, null, 0, 1000);
            game = container.Resolve<GameMenu>();
            filePath = null;
            DataUpdate();
            pauseButton.Text = "Pause";
        }

        private void TimerTick(object o)
        {
            if (!gameOnOff || game == null)
                return;

            IGameService gameService = container.Resolve<IGameService>();
            //IGameService gameService = factory.CreateGameService();
            gameService.NextTick(game);
            if (InvokeRequired)
            {
                Invoke(new  MyDel(DataUpdate));
            }
            else
            {
                DataUpdate();
            }

            if (game.Virus.VirusActivated)
            {
                VirusForm virus = new VirusForm(game, factory.CreateVirusService());
                virus.ShowDialog();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void computerButton_Click(object sender, EventArgs e)
        {
            ComputerForm computer = container.Resolve<ComputerForm>();
            //ComputerForm computer = new ComputerForm(game, factory.CreateComputerService());
            computer.ShowDialog();
        }

        private void systemProgrammingButton_Click(object sender, EventArgs e)
        {
            ProgramsForm programs = container.Resolve<ProgramsForm>();
            //ProgramsForm programs = new ProgramsForm(game, factory.CreateComputerService());
            programs.ShowDialog();
        }

        private void newJobButton_Click(object sender, EventArgs e)
        {
            NewJobForm newJob = container.Resolve<NewJobForm>();
            //NewJobForm newJob = new NewJobForm(game, factory.CreatePersonService());
            newJob.ShowDialog();
        }

        private void hackingButton_Click(object sender, EventArgs e)
        {
            if (game.Hacking.HackingEnabled)
            {
                HackingForm hackingForm = container.Resolve<HackingForm>();
                //HackingForm hackingForm = new HackingForm(game, factory.CreateHackingService());
                hackingForm.ShowDialog();
            }

        }

        private void bssButton_Click(object sender, EventArgs e)
        {
            BssForm bss = container.Resolve<BssForm>();
            //BssForm bss = new BssForm(game, factory.CreateBssService());
            bss.ShowDialog();

        }

        private void EntertainmentButton_Click(object sender, EventArgs e)
        {
            EntertainmentForm entertainment = container.Resolve<EntertainmentForm>();
            //EntertainmentForm entertainment = new EntertainmentForm(game, factory.CreatePersonService());
            entertainment.ShowDialog();

        }
        
        private void DataUpdate()
        {
            dateTextBox.Text = game.Time.ToString("g");
            string[] lines = new string[]
            {
                "Money: " + game.Person.Money,
                "Points: " + game.Person.Points,
                "Income: " + game.Person.Income,
                "Mood: " + game.Person.Mood
            };

            personTextBox.Lines = lines;

            string[] lines1 = new string[]
            {
                "Computer: " + game.Computer.Comp,
                "Memory: " + game.Computer.Memory,
                "HDD: " + game.Computer.HDD,
                "Modem: " + game.Computer.Modem,
                "CD: " + game.Computer.Cd,
                "System: " + game.Computer.InstalSystem,
                "Programming: " + game.Computer.InstalProgramming,
                "Antivirus: " + game.Computer.Antivirus
            };

            computerTextBox.Lines = lines1;
            string[] lines2 = new string[]
            {
                "My bss: " + game.Bss.MyBssInstaled,
                "Mb soft: " + game.Bss.MbSoft
            };
            bssTextBox.Lines = lines2;
        }
        
        private void pauseButton_Click(object sender, EventArgs e)
        {
            gameOnOff = !gameOnOff;
            if (gameOnOff)
            {
                pauseButton.Text = "Pause";
            }
            else
            {
                pauseButton.Text = "Play";
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            gameOnOff = false;
            if (openDialog.ShowDialog() != DialogResult.OK) 
            {
                return;
            }

            filePath = Path.GetFullPath((openDialog.FileName));
            IStoreService storeService = container.Resolve<IStoreService>();
            //IStoreService storeService = factory.CreateStoreService();

            storeService.Load(game, filePath);
            gameOnOff = true;
            pauseButton.Text = "Pause";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (filePath == null)
            {
                saveAsButton_Click(sender, e);
            }

            IStoreService storeService = container.Resolve<IStoreService>();
            //IStoreService storeService = factory.CreateStoreService();
            storeService.Save(game, filePath);
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            gameOnOff = false;
            if (SaveDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            filePath = Path.GetFullPath(SaveDialog.FileName);
            IStoreService storeService = container.Resolve<IStoreService>();
            //IStoreService storeService = factory.CreateStoreService();
            storeService.Save(game, filePath+".xml");
            gameOnOff = true;
            pauseButton.Text = "Pause";
        }
    }
}
