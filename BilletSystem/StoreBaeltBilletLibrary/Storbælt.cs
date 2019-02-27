using System;
using BilletSystem;

namespace StoreBaeltBilletLibrary
{
    public class Stortbælt
    {
     
        public double WeekendRabat(DateTime day)
        {
            Bil minBil = new Bil("");

            var pris = (double)minBil.Pris();
            double result1 = pris * 0.95;
            double WeekendsRabat = pris * 0.80;
            double result2 = WeekendsRabat * 0.95;
            
            
            if (day.DayOfWeek == DayOfWeek.Saturday ||  day.DayOfWeek == DayOfWeek.Sunday)
            {
                return result2;
            }
            else
            {
                return result1;
            }
        }


    }
}
