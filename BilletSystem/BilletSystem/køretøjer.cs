using System;

namespace BilletSystem
{
    /// <summary>
    /// Baseklassen for køretøjer
    /// </summary>
    public abstract class køretøjer
    {
      /// <summary>
      /// Baseklassens constructor
      /// </summary>
      /// <param name="nummerplade"></param>
        public køretøjer(string nummerplade) // Opgave 4
        {
            nummerPlade = nummerplade;

        }

        /// <summary>
        /// property der beskriver nummerpladen
        /// </summary>
        public string nummerPlade
        {
            get { return nummerPlade; }
            set {
                if (nummerPlade.Length > 7) // Opgave 5
                {
                  throw new Exception();
                }

                }
        }

        /// <summary>
        /// property der beskriver Dato'en
        /// </summary>
        public DateTime Dato { get; set; }


        /// <summary>
        /// Abstravt metode til Pris
        /// </summary>
        /// <returns></returns>
        public abstract decimal Pris();
        /// <summary>
        /// Abstract metode, til en at vide hvilken type køretøj.
        /// </summary>
        /// <returns></returns>

        public abstract string køretøj();
        /// <summary>
        /// Abstract metode, som beskriver brobizzen
        /// </summary>
        /// <returns></returns>
       public abstract double Brobizz();


    }
}