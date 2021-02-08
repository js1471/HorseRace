using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HorseRace
{
    public abstract class Punter
    {
        public string Name;
        public Bet bet;
        public int Cash;
        public bool busted;
        public Label statusLabel, MaxBet;

        public Punter(Bet bet, Label MaximumBet, int Cash, Label statusLabel)
        {
            this.bet = bet;
            this.Cash = Cash;
            this.MaxBet = MaximumBet;
            this.statusLabel = statusLabel;
            if (this.statusLabel != null)
                this.statusLabel.ForeColor = System.Drawing.Color.Red;

        }

        public void UpdateLabels()
        {
            if (bet == null)
            {
                statusLabel.Text = String.Format("{0} hasn't placed any bets", Name);

            }

            else
            {
                statusLabel.Text = bet.GetDescription();
            }
            if (Cash == 0)
            {
                busted = true;
                statusLabel.Text = String.Format("BUSTED!");
                statusLabel.ForeColor = System.Drawing.Color.Red;

            }
            MaxBet.Text = String.Format("Max Bet: ${0}", Cash);
            statusLabel.ForeColor = System.Drawing.Color.Blue;
        }


        public void ClearBet()
        {
            bet.Amount = 0;
        }

        public bool PlaceBet(int Amount, int horse)
        {
            if (Amount <= Cash)
            {
                bet = new Bet(Amount, horse, this);
                return true;
            }
            return false;
        }

        public void Collect(int Winner)
        {
            Cash += bet.Pay(Winner);
        }

        public abstract void setPunterName();
    }
}