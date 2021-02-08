using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace HorseRace
{
   public class Horse
    {
        private static int StartPosition;
        private static int RacetrackLength;
        public PictureBox HorsePictureBox = null;
        public int Location = 0;
        public static Random MyRandom = new Random(); 

        public static int StartingPosition1 { get => StartPosition; set => StartPosition = value; }
        public static int RacetrackLength1 { get => RacetrackLength; set => RacetrackLength = value; }

        // generation across all horse objects

        public static bool Run(Horse obj) {
            int distance = MyRandom.Next(2, 6);
            if (obj.HorsePictureBox != null)
            obj.MoveHorsePictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (RacetrackLength1 - StartingPosition1)) {
                return true;
            }
            return false;
        }

        public void startPosition() {
            MoveHorsePictureBox(-Location); 
            Location = 0;

        }

        public void MoveHorsePictureBox(int distance) {
            Point p = HorsePictureBox.Location;
            p.X += distance;  
            HorsePictureBox.Location = p; //move horse in x-axis
        }
    }
}
