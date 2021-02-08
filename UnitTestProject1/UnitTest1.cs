using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HorseRace;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        PunterFactory pFactory = new PunterFactory();
        Punter Sahib;
        Horse[] horses = new Horse[2];
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestWinnerOutcome()
        {
            Horse.StartingPosition1 = 0;
            Horse.RacetrackLength1 = 50;
            int BettingAmount = 20;
            int HorseNumber = 1;
            int expectedWin = 40;
            int expectedLose = 0;
            horses[0] = new Horse() { HorsePictureBox = null };
            horses[1] = new Horse() { HorsePictureBox = null };
            Sahib = pFactory.getPunter("Sahib", null, null);
            Sahib.Cash = BettingAmount;
            Sahib.PlaceBet((int)BettingAmount, HorseNumber);

            bool nowin = true;
            int win = -1;
            while (nowin)
            {
                for (int i = 0; i < horses.Length; i++)
                {
                    if (Horse.Run(horses[i]))
                    {
                        win = i + 1;
                        Sahib.Collect(win);
                        nowin = false;

                    }
                }
            }
            if (Sahib.bet.horseNum == win)
            {
                Assert.AreEqual(expectedWin, Sahib.Cash, "Account not credited correctly");
            }
            if (Sahib.bet.horseNum != win)
            {
                Assert.AreEqual(expectedLose, Sahib.Cash, "Account not debited correctly");

            }
        }
    }

}

 