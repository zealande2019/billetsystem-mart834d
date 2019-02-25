using System;

namespace BilletSystem
{
    public abstract class køretøjer
    {
      
        public køretøjer(string nummerplade) // Opgave 4
        {
            nummerPlade = nummerplade;

        }

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

        public DateTime Dato { get; set; }

        public abstract decimal Pris();

        public abstract string køretøj();
        public abstract double Brobizz();


    }
}