using System;

namespace BilletSystem
{
    /// <summary>
    /// Bil klassen
    /// </summary>
    public class Bil : køretøjer
    {
        /// <summary>
        /// Bil klassens contructor
        /// </summary>
        /// <param name="nummerPlade"></param>

      
        public Bil(string nummerPlade) : base(nummerPlade)
        {
            
        }
        /// <summary>
        /// En metode der beskriver hvilket køretøj den passer til Klassen
        /// </summary>
        /// <returns></returns>

        public override string køretøj()
        {
            return "Bil";
        }

        /// <summary>
        /// En metode der beskriver prisen
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// en metode der beskriver brobizzen for en bil
        /// </summary>
        /// <returns></returns>
        public override double Brobizz()
        {

            var Result = (double)Pris() * 0.95;
            return Result;
        }
    }

}