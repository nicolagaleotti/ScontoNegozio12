using System;

namespace MetodoSconto
{
    public class Sconto
    {
        public static double ScontoMinore(double totale)
        {
            double sconto = totale / 100 * 10;
            return sconto;
        }
        public static double ScontoMaggiore(double totale)
        {
            double scontoprima = 300 / 100 * 10;
            double spesainpiu = totale - 300;
            double scontodopo = spesainpiu / 100 * 20;
            double sconto = scontoprima + scontodopo;
            return sconto;
        }
    }
}
