using System;

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

        public Strumento(string descrizione, double costo, DateTime annoDiAcquisizione)
        {
            _numeroIdentificativo = _id;
            _descrizione = descrizione;
            _costo = costo;
            _annoAcquisizione = annoDiAcquisizione;
            _anniGaranzia = new Random().Next(1, 5); // Genero una garazia che va da 1 a 4 anni
            _id++;
        }
    }
}