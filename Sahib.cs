
using System.Windows.Forms;
using System;
namespace HorseRace
{
    public class Sahib : Punter
    {

        public Sahib(Bet MyBet, Label MaximumBet, int Cash, Label MyLabel) : base(MyBet, MaximumBet, Cash, MyLabel)
        {
        }

        public override void setPunterName()
        {
            Name = "Sahib";
        }
    }
}
