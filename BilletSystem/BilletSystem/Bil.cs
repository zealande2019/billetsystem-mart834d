using System;

namespace BilletSystem
{
    public class Bil : køretøjer
    {
        public Bil(string nummerPlade) : base(nummerPlade)
        {
            
        }

        public override string køretøj()
        {
            return "Bil";
        }

        public override decimal Pris()
        {
            return 240;
        }

        public override double Brobizz()
        {
            var Result = 240/1.05;
            return Result;
        }
    }
}