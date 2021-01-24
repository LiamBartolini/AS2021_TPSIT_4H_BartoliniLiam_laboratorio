using System;
using AS2021_TPSIT_4H_BartoliniLiam_laboratorio.Models;

namespace AS2021_TPSIT_4H_BartoliniLiam_laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bartolini Liam 4H, laboratorio");
            Laboratorio laboratorio = new Laboratorio();
            laboratorio.AggiuntaStrumento("Primo", 70.0, DateTime.Today);
            laboratorio.AggiuntaStrumento("Secondo", 80.0, Convert.ToDateTime("10/01/2005"));
            laboratorio.AggiuntaStrumento("Terzo", 90.0, Convert.ToDateTime("20/11/2020"));

            Console.WriteLine("Ricerca strumento identificativo:\n"+laboratorio.RicercaStrumento(2));
            Console.WriteLine("Ricerca strumento descrizione:\n"+laboratorio.RicercaStrumento("Primo"));
            Console.WriteLine("Valore Totale strumenti: " + laboratorio.ValoreTotaleStrumenti(Convert.ToDateTime("10/01/2005"), DateTime.Today));
            Console.WriteLine("Elenco strumenti in garanzia:\n" + laboratorio.ElencoStrumentiInGaranzia());
            Console.WriteLine("Salvataggio Dati: " + laboratorio.SalvataggioDati());
        }
    }
}