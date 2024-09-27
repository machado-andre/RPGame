using Microsoft.EntityFrameworkCore;
using RPGame.Classes;

namespace RPGame
{
    public partial class Login : Form
    {
        private RPGameDbContext? dbContext;
        private Player player;
        private int counter = -1;
        private List<String> subtitles = new List<String>();

        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
            subtitles.Add("You don't really know what happened... You just know you have a sword near you and there is only one path to follow...");
            subtitles.Add("hint: Try to click around and defeat monsters. Some may attack you first, some are stronger.");
            subtitles.Add("Pick up the sword and escape!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.dbContext = new RPGameDbContext();

            this.dbContext.Items.Load();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == null || textBoxPassword.Text == null)
            {
                MessageBox.Show("Username or password cannot be empty");
                return;
            }
            var players = this.dbContext.Players;

            foreach (var player in players)
            {
                if (!(player.Username == textBoxUsername.Text))
                {
                    MessageBox.Show("Username not found.");
                    return;
                }
                if (!(player.Password == textBoxPassword.Text))
                {
                    MessageBox.Show("Password incorrect.");
                    return;
                }
                this.player = player;
            }

            MessageBox.Show("Successful login.");
            HomeScreenTransition();
            this.CenterToScreen();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void HomeScreenTransition()
        {
            labelUsername.Visible = false;
            labelPassword.Visible = false;
            textBoxPassword.Visible = false;
            textBoxUsername.Visible = false;
            buttonLogin.Visible = false;
            this.BackColor = Color.Moccasin;
            // Original size is -> 230; 220
            this.Size = new Size(860, 640);
        }

        private void linkLabelStartGame_LinkClicked(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            labelSubtitles.Text = "";
            PlaySubtitles(++counter);
        }

        private void StartGame()
        {
            this.Hide();
            Home home = new Home(this.player);
            home.Closed += (s, args) => this.Close();
            home.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (counter == this.subtitles.Count-1)
            {
                StartGame();
                return;
            }

            PlaySubtitles(++counter);
        }

        private void PlaySubtitles(int subtitle)
        {
            labelSubtitles.Text = null;
            labelSubtitles.Text = this.subtitles[subtitle];
        }
    }
}