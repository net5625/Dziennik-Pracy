using System.Windows.Forms;
using System.IO;
using System;
using System.Xml;
using System.Collections.Generic;

namespace Dziennik_Pracy
{
    public partial class zestawy : Form
    {
        #region zmienne klasowe
        private readonly string name = "zestawy.xml";
        private XmlTextReader reader;
        private List<ZestawPiesni> listaZestawow = new List<ZestawPiesni>();
        #endregion
        /// <summary>
        /// Konstruktor klasy odpowiedzialny za odczyt danych lub wyjście z formularza jeśli danych brak.
        /// </summary>
        public zestawy()
        {
            InitializeComponent();
            if (!File.Exists(name))
            {
                CloseWindow();
            }
            try
            {
                if (Wczytywanie())
                {
                    Wyswietlenie();
                }
                else
                {
                    MessageBox.Show("Brak danych do wyświetlenia.");
                    CloseWindow();
                }
            }
            catch(Exception exeption)
            {
                MessageBox.Show("Brak pliku."+exeption.ToString());
            }
        }
        /// <summary>
        /// Podstawowa funkcja raluzująca zamknięcie formularza.
        /// </summary>
        private void CloseWindow()
        {
            ActiveForm.Close();
        }
        /// <summary>
        /// Funkcja odpowiadająca za wczytanie danych z pliku do obiektu.
        /// </summary>
        /// <returns>Przy poprawnym wczytaniu zwraca true a w przeciwnym razie false.</returns>
        private bool Wczytywanie()
        {
            try
            {
                reader = new XmlTextReader(name);
                string typ = "";
                string nazwa = "";
                DateTime data;
                string nazwaZestawu = "";
                while (reader.Read())
                {
                    //Sprawdzamy węzły po kolei...
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        //Węzeł Zestaw
                        if (reader.Name == "Zestaw")
                        {
                            nazwaZestawu = reader.GetAttribute("Nazwa");
                            data = DateTime.Parse(reader.GetAttribute("Data").ToString());
                            listaZestawow.Add(new ZestawPiesni(nazwaZestawu, data));
                        }
                        //Jeżeli węzeł Typ
                        else if (reader.Name == "Typ")
                        {
                            typ = reader.ReadString();
                        }
                        //Jeżeli węzeł Nazwa
                        else if (reader.Name == "Nazwa")
                        {
                            nazwa = reader.ReadString();
                            if (nazwa != "")
                            {
                                int index = listaZestawow.Count - 1;
                                listaZestawow[index].DodajPiesn(new PiesniGrane(typ, nazwa));
                                nazwa = "";
                                typ = "";
                            }
                        }
                    }
                }
                //Zamknięcie readera.
                reader.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Funkcja wczytuje dane w pętli forach bez żanych filtracji i sortowań.
        /// </summary>
        private void Wyswietlenie() 
        {
            foreach (ZestawPiesni zestaw in listaZestawow)
            {
                WyswietlZestaw(zestaw);
            }
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 2; // Z reguły 2 ostatnie całe widoczne na ekranie, w razie konieczności można zmienic na 1.
            dataGridView1.Refresh();
        }
        /// <summary>
        /// Funkcja odpowiedzalna za dodatnie do widoku DataGridView jednego zestawu pieśni.
        /// </summary>
        /// <param name="zestaw">Jako argument przyjmuje jeden zestaw pieśni.</param>
        private void WyswietlZestaw(ZestawPiesni zestaw)
        {
            string lista = "";
            string typy = "";
            foreach (PiesniGrane piesni in zestaw.DajPiesni())
            {
                if (lista != "" && typy != "")
                {
                    lista += Environment.NewLine;
                    typy += Environment.NewLine;
                }
                lista += piesni.Name;
                if (piesni.ShortType == "")
                {
                    //typy += "  "; // TODO: Poprawić wyświetlanie jeśli brak podanego typu...
                }
                else
                {
                    typy += piesni.ShortType;
                }
            }
            dataGridView1.Rows.Add(zestaw.name, zestaw.Data.ToString("yyyy-MM-dd"), typy, lista);
        }
        private void excButton_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        /// <summary>
        /// Funkcja odpowiada za akcje po przyciśnięciu przycisku szukaj.
        /// Funkcja odpowiada za podjęcie decyzji co do typu przeszukiwania, oraz za konsersję danych w przypadku wprowadzenia daty.
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (dataRadioB.Checked == true)
            {
                DateTime szukane;
                try
                {
                    szukane = DateTime.Parse(searchBox.Text);
                }
                catch
                {
                    MessageBox.Show("Błędny zapis daty", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                WyświetlDate(szukane);
            }
            else if(nazwaRadioB.Checked == true)
            {
                WyswietlNazwe(searchBox.Text);
            }
        }
        /// <summary>
        /// Funkcja odpowiadająca za wyszukanie podanego łańcucha znakowego wsród nazw zestawów piesni.
        /// </summary>
        /// <param name="text">Parametr funkcji, który jest łancuchem zakowym poszukiwanym wśród nazw zestawów pieśni.</param>
        private void WyswietlNazwe(string text)
        {
            dataGridView1.Rows.Clear();
            foreach (ZestawPiesni list in listaZestawow)
            {
                if(list.name.Contains(text))
                {
                    WyswietlZestaw(list);
                }
            }
        }
        /// <summary>
        /// Funkcja wyszukjąca zestawy w danych, za pomocą obiektu poszukiwań.
        /// </summary>
        /// <param name="szukane">Dane poszukiwane, w tym wypadku data w formacie DateTime.</param>
        private void WyświetlDate(DateTime szukane)
        {
            dataGridView1.Rows.Clear();
            foreach(ZestawPiesni list in listaZestawow)
            {
                if (list.Data == szukane)
                {
                    WyswietlZestaw(list);
                }
            }
        }
    }
}
