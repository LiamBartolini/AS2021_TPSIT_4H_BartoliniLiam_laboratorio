using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AS2021_TPSIT_4H_BartoliniLiam_laboratorio.Models
{
    class Laboratorio
    {
        List<Strumento> _strumenti = new List<Strumento>();
        
        public void AggiuntaStrumento(string descrizione, double costo, DateTime annoDiAcquisizione) => _strumenti.Add(new Strumento(descrizione, costo, annoDiAcquisizione));

        public void EliminazioneStrumento(int identificativo)
        {
            foreach (var s in _strumenti)
                if (s.NumeroIdentificativo == identificativo)
                    _strumenti.RemoveAt(identificativo);
        }

        public Strumento RicercaStrumento(int identificativo)
        {
            foreach (var s in _strumenti)
                if (s.NumeroIdentificativo == identificativo)
                    return s;
            throw new Exception($"Strumento non trovato!\nIdentificativo{identificativo}");
        }

        public Strumento RicercaStrumento(string descrizione)
        {
            foreach (var s in _strumenti)
                if (s.Ddescrizione == descrizione)
                    return s;
            throw new Exception($"Strumento non trovato!\nDescrizione{descrizione}");
        }

        public double ValoreTotaleStrumenti(DateTime inizio, DateTime fine)
        {
            double retVal = 0;
            foreach (var s in _strumenti)
                if (s.AnnoAcquisizione >= inizio && s.AnnoAcquisizione <= fine)
                    retVal += s.Costo;
            return retVal;
        }

        public string ElencoStrumentiInGaranzia()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var s in _strumenti)
                if (s.AnnoScadenza <= DateTime.Today)
                    sb.AppendLine(s.ToString());
            return sb.ToString();
        }

        public bool SalvataggioDati()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (var s in _strumenti)
                    sb.AppendLine(s.ToString());
                File.AppendAllText("dati.txt", sb.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RipristinoDati()
        {
            try
            {
                File.WriteAllText("dati.txt", "");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}