using System;

namespace FintechInvestment.Core
{
    public class Investment
    {
        public double total(double interes, double quantitat, int temps)
        {
            double total;
            double totalinteres;

            totalinteres = interes / 100;

            total = quantitat;

            for (int i = 0; i < temps; i++)
            {
                total += Math.Round(total * totalinteres, 2);
            }

            return total;
        }

        public double guany(double total, double quantitat)
        {
            double guany = Math.Round( total - quantitat, 2);
            return guany;
        }

    }
}
