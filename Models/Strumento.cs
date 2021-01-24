using System;
using System.Text;

namespace AS2021_TPSIT_4H_BartoliniLiam_laboratorio.Models
{
    class Strumento
    {
        static int _id;
        int _numeroIdentificativo;
        string _descrizione;
        double _costo;
        DateTime _annoAcquisizione;
        int _anniGaranzia;
        DateTime _scadenzaGaranzia;

        public int NumeroIdentificativo{ get => _numeroIdentificativo; }
        public string Ddescrizione{ get => _descrizione; }
        public DateTime AnnoAcquisizione { get => _annoAcquisizione; }
        public Double Costo { get => _costo; }
        public DateTime AnnoScadenza { get => _scadenzaGaranzia; }
        
        public Strumento(string descrizione, double costo, DateTime annoDiAcquisizione)
        {
            _numeroIdentificativo = _id;
            _descrizione = descrizione;
            _costo = costo;
            _annoAcquisizione = annoDiAcquisizione;
            _anniGaranzia = new Random().Next(1, 5); // Genero una garazia che va da 1 a 4 anni
            _scadenzaGaranzia = _annoAcquisizione.AddYears(_anniGaranzia);
            _id++;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Identificativo:\t{_numeroIdentificativo}");
            sb.AppendLine($"Descrizione:\t\t{_descrizione}");
            sb.AppendLine($"Costo:\t\t\t{_costo} euro");
            sb.AppendLine($"Anno di acquisto:\t{_annoAcquisizione:dd/MM/yyyy}");
            sb.AppendLine($"Anno di scadenza:\t{_scadenzaGaranzia:dd/MM/yyyy}");
            return sb.ToString();
        }
    }
}