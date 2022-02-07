using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Dziennik_Pracy
{
    class Pdf
    {
        private DateTime Open { get; set; }
        private DateTime Close { get; set; }
        private readonly string plik = "obecnosc.xml";
        /// <summary>
        /// Konstruktor sprawdzający większość parametrów, oraz razlizujący zapis po odczytaniu danych z pliku xml.
        /// </summary>
        /// <param name="open">DateTime określający początek przestrzeni czasowej.</param>
        /// <param name="close">DateTime określający koniec przestrzeni czasowej.</param>
        public Pdf(DateTime open, DateTime close)
        {
            if (open > close)
            {
                Open = close;
                Close = open;
            }
            else
            {
                Open = open;
                Close = close;
            }
            if (sprawdzenie_pliku())
            {
                zapis();
            }
            else
            {
                MessageBox.Show("Brak pliku obecnosc.xml.", "Błąd");
            }
        }
        /// <summary>
        /// Funkcja odpowiadająca za zapis do pliku po wczytaniu danych.
        /// </summary>
        private void zapis()
        {
            XmlTextReader reader = new XmlTextReader(plik);
            while (reader.Read())
            {
                if(reader.NodeType == XmlNodeType.Element && reader.Name == "Day" &&  DateTime.Parse(reader.GetAttribute("Date")) > Open && DateTime.Parse(reader.GetAttribute("Date")) < Close)
                {
                    MessageBox.Show("1",reader.Value.ToString());
                }
            }

        }
        /// <summary>
        /// Funkcja sprawdzająca czy plik istnieje.
        /// </summary>
        /// <returns>Zwraca true jeśli plik istnieje, a w przeciwnym razie zwraca false.</returns>
        private bool sprawdzenie_pliku()
        {
            if (!File.Exists(plik))
            {
                return false;
            }
            return true;
        }
    }
}
