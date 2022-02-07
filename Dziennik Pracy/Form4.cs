using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Dziennik_Pracy
{
    public partial class obecnosc : Form
    {
        private readonly string name = "obecnosc.xml";
        /// <summary>
        /// Konstruktor klasy obecnosc, w którym inicjalizowane są komponenty formularza i pobierana data aktualna.
        /// </summary>
        public obecnosc()
        {
            InitializeComponent();
            dataLabel.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
        /// <summary>
        /// Funkcja odpowiadająca za zamknięcie formularza, gdy wciśnięty zostanie przycisk canceledButton.
        /// </summary>
        private void canceledButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
        #region ZAZNACZENIE ZAWARTOŚCI W NUMERIC UP DOWN
        /// <summary>
        /// Funkcja zaznaczenia zawartości dla numeric up down o nazwie massUpDown.
        /// </summary>
        private void massUpDown_Enter(object sender, EventArgs e)
        {
            int select = massUpDown.ToString().Length;
            massUpDown.Select(0, select);
        }
        /// <summary>
        /// Funkcja zaznaczenia zawartości dla numeric up down o nazwie liturgicallUpDown.
        /// </summary>
        private void liturgicallUpDown_Enter(object sender, EventArgs e)
        {
            int select = liturgicallUpDown.ToString().Length;
            liturgicallUpDown.Select(0, select);
        }
        /// <summary>
        /// Funkcja zaznaczenia zawartości dla numeric up down o nazwie houerUpDown.
        /// </summary>
        private void houerUpDown_Enter(object sender, EventArgs e)
        {
            int select = houerUpDown.ToString().Length;
            houerUpDown.Select(0, select);
        }
        /// <summary>
        /// Funkcja zaznaczenia zawartości dla numeric up down o nazwie crossUpDown.
        /// </summary>
        private void crossUpDown_Enter(object sender, EventArgs e)
        {
            int select = crossUpDown.ToString().Length;
            crossUpDown.Select(0, select);
        }
        /// <summary>
        /// Funkcja zaznaczenia zawartości dla numeric up down o nazwie gorzkieUpDown.
        /// </summary>
        private void gorzkieUpDown_Enter(object sender, EventArgs e)
        {
            int select = gorzkieUpDown.ToString().Length;
            gorzkieUpDown.Select(0, select);
        }
        #endregion
        /// <summary>
        /// Funkcja realizująca utworzenie pliku xml.
        /// </summary>
        private void makeXml()
        {
            XmlTextWriter xmlTextWriter = new XmlTextWriter(name, Encoding.UTF8);
            xmlTextWriter.WriteStartElement("Days");
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.Close();
        }
        /// <summary>
        /// Funkcja realizująca zapis danych do istniejącego pliku xml.
        /// </summary>
        private void addToXml()
        {
            XmlDocument document = new XmlDocument();
            document.Load(name);
            XmlNode dzien = document.CreateElement("Day");
            XmlAttribute data = document.CreateAttribute("Date");
            XmlNode mass = document.CreateElement("Mass");
            XmlNode liturgicall = document.CreateElement("Devotion");
            XmlNode houer = document.CreateElement("Matins");
            XmlNode cross = document.CreateElement("Cross");
            XmlNode gorzkie = document.CreateElement("Bitter");
            data.InnerText = DateTime.Now.ToString("dd-MM-yyyy");
            mass.InnerText = massUpDown.Value.ToString();
            liturgicall.InnerText = liturgicallUpDown.Value.ToString();
            houer.InnerText = houerUpDown.Value.ToString();
            cross.InnerText = crossUpDown.Value.ToString();
            gorzkie.InnerText = gorzkieUpDown.Value.ToString();
            dzien.Attributes.Append(data);
            dzien.AppendChild(mass);
            dzien.AppendChild(liturgicall);
            dzien.AppendChild(houer);
            dzien.AppendChild(cross);
            dzien.AppendChild(gorzkie);
            document.DocumentElement.AppendChild(dzien);
            document.Save(name);
        }
        /// <summary>
        /// Funkcja przycisku zapisu; odpowiada za dezycję i sprawdzenie czy plik istnieje oraz czy da się zapisać. Po zakończeniu zamyka obecny formularz.
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(name))
                {
                    makeXml();
                }
                addToXml();
            }
            catch
            {
                MessageBox.Show("Nie można zapisać danych.", "Błąd zapisu!");
            }
            Form.ActiveForm.Close();
        }
    }
}
