using System;
using MetodoSconto;

namespace Sconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Totale speso? ");
            double totale = double.Parse(Console.ReadLine());
            double sconto;
            double scontato;
            try
            {
                if (totale <= 300)
                {
                    sconto = MetodoSconto.Sconto.ScontoMinore(totale);
                    scontato = totale - sconto;
                    Console.WriteLine($"Lo sconto è di {sconto} euro e l'importo da pagare è {scontato} euro");
                }
                else if (totale > 300)
                {
                    sconto = MetodoSconto.Sconto.ScontoMaggiore(totale);
                    scontato = totale - sconto;
                    Console.WriteLine($"Lo sconto è di {sconto} euro e l'importo da pagare è {scontato} euro");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
