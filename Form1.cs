using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class Form1 : Form
    {
        Horse[] horses = new Horse[4];

        Punter[] punters = new Punter[3];
        PunterFactory pFactory = new PunterFactory();


        public Form1()
        {
            InitializeComponent();
           
            SetupTrack();
        }

        private void SetupTrack()
        {

            Horse.StartingPosition1 = Horse1.Right - racetrack.Left;
            Horse.RacetrackLength1 = racetrack.Size.Width - 70; //fixing length of race - till finish line

            horses[0] = new Horse() { HorsePictureBox = Horse1 };
            horses[1] = new Horse() { HorsePictureBox = Horse2 };
            horses[2] = new Horse() { HorsePictureBox = Horse3 };
            horses[3] = new Horse() { HorsePictureBox = Horse4 };

            punters[0] = pFactory.getPunter("sahib", MaximumBet, SahibBet); 
            punters[1] = pFactory.getPunter("Inder", MaximumBet, InderBet); 
            punters[2] = pFactory.getPunter("Jashan", MaximumBet, JashanBet); 


            foreach (Punter punter in punters)
            {
                punter.UpdateLabels();
            }
        }

        private void sahibButton_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[0].Cash);
        }

        private void inderRButton_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[1].Cash);
        }

        private void JashanRButton_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[2].Cash);

        }
        private void setMaximumBetTextLabel(int Cash)
        {
           jbet.Text= Convert.ToString(Cash);
            MaximumBet.Text = String.Format("Max Bet: ${0}", Cash);
        }

        private void Bets_Click(object sender, EventArgs e)
        {
            int PunterNum = 0;

            if (sahibButton.Checked)
            {
                PunterNum = 0;
                
                
            }
            if (inderRButton.Checked)
            {
                PunterNum = 1;
               
                MessageBox.Show("Ready for Race --");
                racebtn.Enabled = true;
               
            }
            if (jashanRButton.Checked)
            {
                PunterNum = 2;
               
              
            }

            punters[PunterNum].PlaceBet((int)BettingAmount.Value, (int)HorseNumber.Value);
            punters[PunterNum].UpdateLabels();
        }






        private void racebtn_Click(object sender, EventArgs e)
        {
            bool NoWinner = true;
            int winningHorse;
            racebtn.Enabled = false; 

            while (NoWinner)
            { 
                Application.DoEvents();
                for (int i = 0; i < horses.Length; i++)
                {
                    if (Horse.Run(horses[i]))
                    {
                        winningHorse = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner - Horse " + winningHorse);
                        foreach (Punter punter in punters)
                        {
                            if (punter.bet != null)
                            {
                                punter.Collect(winningHorse); 
                                punter.bet = null;
                                punter.UpdateLabels();
                            }
                        }
                        foreach (Horse horse in horses)
                        {
                            horse.startPosition();
                        }
                        break;
                    }
                }
            }
            if (punters[0].busted && punters[1].busted && punters[2].busted)
            {  //stop punters from betting if they run out of cash
                String message = "Do you want to Play Again?";
                String title = "End Game!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SetupTrack(); //restart game
                }
                else
                {
                    this.Close();
                }

            }
            racebtn.Enabled = true;
        }

        private void Horse1_Click(object sender, EventArgs e)
        {

        }

        private void RogerBet_Click(object sender, EventArgs e)
        {

        }

        private void sahibBet_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            racebtn.Enabled = false;

        }

        private void MaximumBet_Click(object sender, EventArgs e)
        {

        }

        private void jbet_Click(object sender, EventArgs e)
        {

        }
    }
}
