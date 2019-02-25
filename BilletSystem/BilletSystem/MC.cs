using System;

namespace BilletSystem
{
    public class MC : køretøjer
    {
        public MC(string nummerplade) : base(nummerplade)
        {
            
        }

        public override decimal Pris()
        {
            return 125;
        }

        public override string køretøj()
        {
            return "MC";
        }

        public override double Brobizz() // Opgave 6
        {
           double Result = 125 / 1.05;
           return Result;
        }
    }
}