using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusEscape
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Height = 332;
            this.Width = 259;
            this.BackColor = Color.Green;
            StartScreen();
        }
        private void StartScreen()
        {
            labelTitle.Location = new Point(34, 163);
            buttonPlay.Location = new Point(41, 214);
            virusStartScreen.Location = new Point(41, 12);
            virusStartScreen.BackgroundImage = Properties.Resources.virusStartScreen;
            virusStartScreen.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
