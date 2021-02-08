using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HorseRace
{
    public class PunterFactory
    {
        public Punter getPunter(String Name, Label MaximumBet, Label bet)
        {
            Punter p;
            switch (Name.ToLower())
            {
                case "sahib":
                    p = new  Sahib(null, MaximumBet, 50, bet);
                    break;

                case "inder":
                    p = new Inder(null, MaximumBet, 50, bet);
                    break;

                case "jashan":
                    p = new Jashan(null, MaximumBet, 50, bet);
                    break;

                default:
                    p = null;
                    break;
            }
            p.setPunterName();
            return p;
        }
    }
}