using System;

namespace BilletSystem
{
    /// <summary>
    /// MC klassen
    /// </summary>
    public class MC : køretøjer
    {
        /// <summary>
        /// MC Klassens constructor
        /// </summary>
        /// <param name="nummerplade"></param>
        public MC(string nummerplade) : base(nummerplade)
        {
            
        }


        /// <summary>
        /// Metode til MC klassen der skriver prisen
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 125;
        }


        /// <summary>
        /// En metode, der beskriver hvilket køretøj
        /// </summary>
        /// <returns></returns>
        public override string køretøj()
        {
            return "MC";
        }

        /// <summary>
        /// en metode der viser brobizz rabat på MC
        /// </summary>
        /// <returns></returns>
        public override double Brobizz() // Opgave 6
        {

            double Result = 125 / 1.05;
            return Result;
        }
    }
}