using System;
using System.Collections.Generic;

namespace AS2021_TPSIT_4H_BartoliniLiam_laboratorio.Models
{
    class Laboratorio
    {
        List<Strumento> _strumenti = new List<Strumento>();        
        public Laboratorio()
        {}

        public void AggiuntaStrumento(){}
        public void EliminazioneStrumento(){}
        public void RicercaStrumento(int numeroInventario){}
        public void RicercaStrumento(string descrizione){}
        public void ValoreTotaleStrumenti(DateTime inizio, DateTime fine){}
    }
}