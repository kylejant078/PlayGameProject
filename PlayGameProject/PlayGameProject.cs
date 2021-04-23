using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //allows the use of Thread.Sleep() 
using System.Media; //allows the use of SoundPlayer 
namespace PlayGameProject
{
    public partial class PlayGame : Form
    {
        public PlayGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hide countdowns 3,2 and 1
            countdown3.ForeColor = Color.Black;
            countdown2.ForeColor = Color.Black;
            countdown1.ForeColor = Color.Black;

            //Hide Go label
            go.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Make button disapear
            StartButton.Visible = false;

            //Begin countdown 3
            countdown3.ForeColor = Color.Silver;

            //Countdown sound
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.countdown_sound);
            alertPlayer.Play();

            //show changes and then pause
            Refresh();
            Thread.Sleep(1350);

            //Make countdown 3 disapear
            countdown3.Visible = false;

            //Begin countdown 2
            countdown2.ForeColor = Color.Silver;

            //show changes and then pause
            Refresh();
            Thread.Sleep(1100);

            //Make countdown 2 disapear
            countdown2.Visible = false;

            //Begin countdown 1
            countdown1.ForeColor = Color.Silver;
            //show changes and then pause
            Refresh();
            Thread.Sleep(800);

            //Make countdown 1 disapear
            countdown1.Visible = false;

            //Change audio to videogame sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.videogame_sound);
            player.Play();


            //Change background to green
            BackColor = Color.Green;

            //Go time
            go.ForeColor = Color.White;
        }

        
    }
    }
