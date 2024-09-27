using Microsoft.EntityFrameworkCore;
using RPGame.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGame
{
    public partial class Home : Form
    {
        private RPGameDbContext? dbContext;
        private Player player;
        private List<Minion> minions;

        public Home(Player player)
        {
            this.player = player;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.minions = new List<Minion>();

            this.dbContext = new RPGameDbContext();

            this.dbContext.Items.Load();
            UpdateHP();
            this.minions.Add(new Minion { BeingId = 2, HP = 10, BaseDamage = 1, Level = 3, Gold = 10, LocationId = 1, MinionType = MinionType.Rat, SkinColor = SkinColor.Black });
        }

        private void buttonMonster_Click(object sender, EventArgs e)
        {
            if (minions[0].HP <= 0)
            {
                MessageBox.Show("Minion Already Defeated");
                return;
            }

            Fight(player, minions[0]);
            UpdateHP();

            if (minions[0].HP <= 0)
            {
                MessageBox.Show("Minion Defeated");
            }
        }


        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dbContext?.Dispose();
            this.dbContext = null;
        }


        private void UpdateHP()
        {
            labelHealth.Text = "";
            labelHealth.Text = "Your HP: " + player.HP.ToString();
        }

        private void Fight(Being being1, Being being2)
        {
            being1.HP -= being2.BaseDamage;
            being2.HP -= being1.BaseDamage;
        }

        private void buttonSword_Click(object sender, EventArgs e)
        {
            buttonSword.Visible = false;
            panelSword.BackgroundImage = Properties.Resources.sword;
            player.BaseDamage += 10;
            label1.Text = "A SKELETON!";
            Thread.Sleep(3500);
            buttonMonster.Visible = true;
        }
    }
}
