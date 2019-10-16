using System;

namespace Sconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Totale speso? ");
            double totale = double.Parse(Console.ReadLine());
            double scontoprima;
            double scontodopo;
            double sconto;
            double scontato;
            double spesainpiu;
            if (totale <= 300)
            {
                sconto = totale / 100 * 10;
                scontato = totale - sconto;
                Console.WriteLine($"Lo sconto è di {sconto} euro e l'importo da pagare è {scontato} euro");
            }
            else if (totale > 300)
            {
                scontoprima = 300 / 100 * 10;
                spesainpiu = totale - 300;
                scontodopo = spesainpiu / 100 * 20;
                sconto = scontoprima + scontodopo;
                scontato = totale - sconto;
                Console.WriteLine($"Lo sconto è di {sconto} euro e l'importo da pagare è {scontato} euro");
            }
            Console.ReadLine();
        }
    }
}
