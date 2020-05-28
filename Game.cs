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
        Random rand = new Random();
        int playerAnimateNumber = 1;
        int playerMoveSpeed = 5;
        public Game()
        {
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Height = 332;
            this.Width = 259;
            this.BackColor = Color.FromArgb(56, 126, 62);
            StartScreen();
        }
        private void StartScreen()
        {
            labelTitle.Location = new Point(34, 163);
            buttonPlay.Location = new Point(41, 214);
            virusStartScreen.Location = new Point(41, 12);
            virusStartScreen.BackgroundImage = Properties.Resources.virusStartScreen;
            virusStartScreen.BackgroundImageLayout = ImageLayout.Stretch;
            virusStartScreen.Visible = true;
            labelTitle.Visible = true;
            buttonPlay.Visible = true;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            PlayerAnimate.Start();
            virusStartScreen.Visible = false;
            labelTitle.Visible = false;
            buttonPlay.Visible = false;
            this.Height = 460;
            this.Width = 760;
            int rand1 = rand.Next(30, 730);
            int rand2 = rand.Next(30, 430);
            Player.Location = new Point(rand1, rand2);
            MoveTimer.Start();
        }
        private void PlayerBorderCollision()
        {
            if (Player.Top + Player.Height < 0)
            {
                Player.Top = ClientRectangle.Height;
            }
            else if (Player.Top > ClientRectangle.Height)
            {
                Player.Top = 0 - Player.Height;
            }
            else if (Player.Left + Player.Width < 0)
            {
                Player.Left = ClientRectangle.Width;
            }
            else if (Player.Left > ClientRectangle.Width)
            {
                Player.Left = 0 - Player.Width;
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                Player.Top -= playerMoveSpeed;
            }
            else if (e.KeyCode == Keys.S)
            {
                Player.Top += playerMoveSpeed;
            }
            else if (e.KeyCode == Keys.A)
            {
                Player.Left -= playerMoveSpeed;
            }
            else if (e.KeyCode == Keys.D)
            {
                Player.Left += playerMoveSpeed;
            }
        }

        private void PlayerAnimate_Tick(object sender, EventArgs e)
        {
            string playerImageName;
            playerImageName = "hero_" + playerAnimateNumber;
            Player.Image = (Image)Properties.Resources.ResourceManager.GetObject(playerImageName);
            playerAnimateNumber += 1;
            if (playerAnimateNumber > 2)
            {
                playerAnimateNumber = 1;
            }
        }
        private void PlayerMove()
        {
            PlayerBorderCollision();
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            PlayerMove();
        }
    }
}
