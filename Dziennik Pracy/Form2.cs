using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Dziennik_Pracy
{
    public partial class UtworzZestaw : Form
    {
        #region Tworzenie obiektów klasy Piesni
        Piesni Adwentowe = new Piesni("Adwentowe");
        Piesni Narodzenie = new Piesni("Bożo Narodzeniowe");
        Piesni Wielkopostne = new Piesni("Wielkopostne");
        Piesni Wielkanocne = new Piesni("Wielkanocne");
        Piesni Milosierne = new Piesni("Do Miłosierdzia Bożego");
        Piesni Duchowe = new Piesni("Do Ducha Świętego");
        Piesni Serca = new Piesni("Do Serca Pana Jezusa");
        Piesni Kaplana = new Piesni("Do Jezusa Chrystusa Najwyższego i wiecznego kapłana");
        Piesni Maryjne = new Piesni("Maryjne");
        Piesni Eucharystyczne = new Piesni("Eucharystyczne");
        Piesni Przygodne = new Piesni("Przygodne");
        Piesni Saint = new Piesni("Ku czci Świętych");
        Piesni Michael = new Piesni("Do św. Michała Archanioła");
        Piesni Bronislaw = new Piesni("Do bł. Bronisława Markiewicza");
        Piesni Pozostale = new Piesni("Pozostałe");
        #endregion
        /// <summary>
        /// Konstruktor klasy UtworzZestaw, która odpowiada za formularz
        /// w którym tworzony jest przez użytkownika zestaw pieśni na dany dzień.
        /// </summary>
        public UtworzZestaw()
        {
            InitializeComponent();
            Decyzja();
        }
        /// <summary>
        /// Funkcja odpowiadająca za wczytanie list pieśni z plików - jesli istnieją 
        /// a w przeciwnym razie odczytanie pieśni z lokalizacji podanej w ustawieniach(lub domyślnej) i zapis tych plików.
        /// </summary>
        private void Decyzja()
        {
            if ((!File.Exists(Adwentowe.nazwa + ".bin"))|| (!File.Exists(Narodzenie.nazwa + ".bin")) 
                || (!File.Exists(Wielkopostne.nazwa + ".bin")) || (!File.Exists(Wielkanocne.nazwa + ".bin")) 
                || (!File.Exists(Milosierne.nazwa + ".bin")) || (!File.Exists(Duchowe.nazwa + ".bin")) 
                || (!File.Exists(Serca.nazwa + ".bin")) || (!File.Exists(Kaplana.nazwa + ".bin")) 
                || (!File.Exists(Maryjne.nazwa + ".bin")) || (!File.Exists(Eucharystyczne.nazwa + ".bin")) 
                || (!File.Exists(Przygodne.nazwa + ".bin")) || (!File.Exists(Saint.nazwa + ".bin")) 
                || (!File.Exists(Michael.nazwa + ".bin")) || (!File.Exists(Bronislaw.nazwa + ".bin")) 
                || (!File.Exists(Pozostale.nazwa + ".bin")))
            {
                using (tworzenie_listy tworzenie = new tworzenie_listy(Lista))
                {
                    tworzenie.ShowDialog(this);
                }
                DecyzjaPiesni();
            }
            else
            {
                Adwentowe.Odczyt();
                Narodzenie.Odczyt();
                Wielkopostne.Odczyt();
                Wielkanocne.Odczyt();
                Milosierne.Odczyt();
                Duchowe.Odczyt();
                Serca.Odczyt();
                Kaplana.Odczyt();
                Maryjne.Odczyt();
                Eucharystyczne.Odczyt();
                Przygodne.Odczyt();
                Saint.Odczyt();
                Michael.Odczyt();
                Bronislaw.Odczyt();
                Pozostale.Odczyt();
                Dodanie_do_kontrolek();
            }
        }
        /// <summary>
        /// Funkcja lista odpowiedzialna za przeszukiwanie folderu w poszukiwaniu pieśni o danych tagach.
        /// </summary>
        private void Lista()
        {
            //Ścieżka do slajdów wprost z ustawień aplikacji
            string path = Properties.Settings.Default.Ustawienie;
            try
            {
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    //PowerPoint *.PPTX
                    if (file.Contains(".pptx"))
                    {
                        try
                        {
                            var presentation = new Aspose.Slides.Presentation(file);
                            //Adwent
                            if (presentation.DocumentProperties.Keywords == "Pieśni Adwentowe")
                            {
                                Adwentowe.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Boże Narodzenie
                            else if (presentation.DocumentProperties.Keywords == "Pieśni na Boże Narodzenie")
                            {
                                Narodzenie.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Wielki Post
                            else if (presentation.DocumentProperties.Keywords == "Pieśni Wielkopostne")
                            {
                                Wielkopostne.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Wielkanoc
                            else if (presentation.DocumentProperties.Keywords == "Pieśni Wielkanocne")
                            {
                                Wielkanocne.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Przygodne
                            else if (presentation.DocumentProperties.Keywords == "Pieśni Przygodne")
                            {
                                Przygodne.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Do Ducha Świętego
                            else if (presentation.DocumentProperties.Keywords == "Pieśni do Ducha Świętego")
                            {
                                Duchowe.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Do Serca Pana Jezusa
                            else if (presentation.DocumentProperties.Keywords == "Pieśni do Serca Pana Jezusa")
                            {
                                Serca.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Do Miłosierdzia
                            else if (presentation.DocumentProperties.Keywords == "Pieśni do Miłosierdzia Bożego")
                            {
                                Milosierne.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Maryjne
                            else if (presentation.DocumentProperties.Keywords == "Pieśni Maryjne")
                            {
                                Maryjne.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Eucharystyczne
                            else if (presentation.DocumentProperties.Keywords == "Pieśni Eucharystyczne")
                            {
                                Eucharystyczne.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Do Jezusa Chrystusa Najwyższego i wiecznego kapłana
                            else if (presentation.DocumentProperties.Keywords == "Pieśni do JCh Najwyższego i Wiecznego Kapłana")
                            {
                                Kaplana.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Do Świętych
                            else if (presentation.DocumentProperties.Keywords == "Pieśni ku czci Świętych")
                            {
                                Saint.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Do Michała
                            else if (presentation.DocumentProperties.Keywords == "Pieśni ku czci św. Michała Archanioła")
                            {
                                Michael.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Do Bronisława
                            else if (presentation.DocumentProperties.Keywords == "Pieśni ku czci bł. Bronisława Markiewicza")
                            {
                                Bronislaw.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                            //Pozostałe
                            else
                            {
                                Pozostale.dodaj(file.Replace(path + "\\", "").Replace(".pptx", ""));
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
                Adwentowe.Zapis();
                Narodzenie.Zapis();
                Wielkopostne.Zapis();
                Wielkanocne.Zapis();
                Milosierne.Zapis();
                Duchowe.Zapis();
                Serca.Zapis();
                Kaplana.Zapis();
                Maryjne.Zapis();
                Eucharystyczne.Zapis();
                Przygodne.Zapis();
                Saint.Zapis();
                Michael.Zapis();
                Bronislaw.Zapis();
                Pozostale.Zapis();
            }
            catch(Exception e)
            {
                string error = e.Message.ToString(); // TODO: Logowanie błędów zamiast wyświetlania w MSBox
                MessageBox.Show(new Form { TopMost = true }, "Brak plików w podanej w ustawieniach ścieżce.\nSprawdź plik ustawień i spróbuj ponownie.", "Błąd", MessageBoxButtons.OK);
                MessageBox.Show(new Form { TopMost = true }, error, "Błąd - informacja programistyczna", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Funkcja tworząca listę pieśni na podstawie obiektów klasy pieśni i dodając do kontrolek typu uCPiesn.
        /// </summary>
        private void Dodanie_do_kontrolek()
        {
            List<Piesni> listaPiesni = new List<Piesni>();
            if (Adwentowe.list.Count != 0)
                listaPiesni.Add(Adwentowe);
            if (Narodzenie.list.Count != 0)
                listaPiesni.Add(Narodzenie);
            if (Wielkopostne.list.Count != 0)
                listaPiesni.Add(Wielkopostne);
            if (Wielkanocne.list.Count != 0)
                listaPiesni.Add(Wielkanocne);
            if (Milosierne.list.Count != 0)
                listaPiesni.Add(Milosierne);
            if (Duchowe.list.Count != 0)
                listaPiesni.Add(Duchowe);
            if (Serca.list.Count != 0)
                listaPiesni.Add(Serca);
            if (Kaplana.list.Count != 0)
                listaPiesni.Add(Kaplana);
            if (Maryjne.list.Count != 0)
                listaPiesni.Add(Maryjne);
            if (Eucharystyczne.list.Count != 0)
                listaPiesni.Add(Eucharystyczne);
            if (Przygodne.list.Count != 0)
                listaPiesni.Add(Przygodne);
            if (Saint.list.Count != 0)
                listaPiesni.Add(Saint);
            if (Michael.list.Count != 0)
                listaPiesni.Add(Michael);
            if (Bronislaw.list.Count != 0)
                listaPiesni.Add(Bronislaw);
            if (Pozostale.list.Count != 0)
                listaPiesni.Add(Pozostale);

            ucPiesn1.refreshing(listaPiesni);
            ucPiesn2.refreshing(listaPiesni);
            ucPiesn3.refreshing(listaPiesni);
            ucPiesn4.refreshing(listaPiesni);
            ucPiesn5.refreshing(listaPiesni);
            ucPiesn6.refreshing(listaPiesni);
            ucPiesn7.refreshing(listaPiesni);
            ucPiesn8.refreshing(listaPiesni);
            ucPiesn9.refreshing(listaPiesni);
            ucPiesn10.refreshing(listaPiesni);
            ucPiesn11.refreshing(listaPiesni);
            ucPiesn12.refreshing(listaPiesni);
            ucPiesn13.refreshing(listaPiesni);
            ucPiesn14.refreshing(listaPiesni);
            ucPiesn15.refreshing(listaPiesni);
        }
        /// <summary>
        /// Funkcja realizująca zamknięcie formularza.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
        /// <summary>
        /// Funkcja przycisku zapisu, który sprawdza czy wprowadzono dane i jeśli wprowadzono uruchamia proces zapisywania.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Boxempty() == true)
            {
                MessageBox.Show("Brak danych.\nNie doddano żadnej pieśni.", "Uzupełnij pola!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Zapis();
            }
        }
        /// <summary>
        /// Funkcja sprawdzająca czy kontrolki są uzupełnione.
        /// </summary>
        /// <returns>Jeżeli puste zwraca true. Jeżeli nie zwraca false.</returns>
        private bool Boxempty()
        {
            if (ucPiesn1.Nameof == null && ucPiesn2.Nameof == null && ucPiesn3.Nameof == null && ucPiesn4.Nameof == null && ucPiesn5.Nameof == null
                && ucPiesn6.Nameof == null && ucPiesn7.Nameof == null && ucPiesn8.Nameof == null && ucPiesn9.Nameof == null && ucPiesn10.Nameof == null
                && ucPiesn11.Nameof == null && ucPiesn12.Nameof == null && ucPiesn13.Nameof == null && ucPiesn14.Nameof == null && ucPiesn15.Nameof == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Funkcja odpowiedzialna za utworzenie pliku - jeśli nie istnieje - oraz za zapis do tego pliku lub istniejącego pliku.
        /// </summary>
        private void Zapis()
        {
            string zestawy = "zestawy.xml";
            if (!File.Exists(zestawy))
            {
                MakeXml(zestawy);
                OwerwriteXml(zestawy);
            }
            else
            {
                OwerwriteXml(zestawy);
            }
        }
        /// <summary>
        /// Funkcja odpowiedzialna za tworzenie pliku xml.
        /// </summary>
        /// <param name="nazwa">Parametr określający nazwę typu string w formacie nazwa.xml dla pliku.</param>
        private void MakeXml(string nazwa)
        {
            XmlTextWriter xmlTextWriter = new XmlTextWriter(nazwa,Encoding.UTF8);
            xmlTextWriter.WriteStartElement("Zestawy");
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.Close();
        }
        /// <summary>
        /// Funkcja realizująca nadpisanie istniejącego pliku xml.
        /// </summary>
        /// <param name="nazwa">Jako parametr typu string funkcja przyjmuje nazwę pliku jako nazwa.xml.</param>
        private void OwerwriteXml(string nazwa)
        {
            XmlDocument document = new XmlDocument();
            document.Load(nazwa);
            XmlNode zestaw = document.CreateElement("Zestaw");
            XmlAttribute nazwaZestawu = document.CreateAttribute("Nazwa");
            nazwaZestawu.InnerText = NazwaBox.Text;
            XmlAttribute data = document.CreateAttribute("Data");
            data.InnerText = DateTime.Today.ToString("yyyy.MM.dd");
            zestaw.Attributes.Append(nazwaZestawu);
            zestaw.Attributes.Append(data);

            List<UCPiesn> linie = new List<UCPiesn>();
            linie.Add(ucPiesn1);
            linie.Add(ucPiesn2);
            linie.Add(ucPiesn3);
            linie.Add(ucPiesn4);
            linie.Add(ucPiesn5);
            linie.Add(ucPiesn6);
            linie.Add(ucPiesn7);
            linie.Add(ucPiesn8);
            linie.Add(ucPiesn9);
            linie.Add(ucPiesn10);
            linie.Add(ucPiesn11);
            linie.Add(ucPiesn12);
            linie.Add(ucPiesn13);
            linie.Add(ucPiesn14);
            linie.Add(ucPiesn15);

            foreach(UCPiesn piesn in linie)
            {
                if (piesn.Nameof != null)
                {
                    XmlNode ID = document.CreateElement("Typ");
                    XmlNode CATEGORY = document.CreateElement("Kategoria");
                    XmlNode NAME = document.CreateElement("Nazwa");
                    ID.InnerText = piesn.Short;
                    CATEGORY.InnerText = piesn.Category;
                    NAME.InnerText = piesn.Nameof;
                    zestaw.AppendChild(ID);
                    zestaw.AppendChild(CATEGORY);
                    zestaw.AppendChild(NAME);
                }
            }
            document.DocumentElement.AppendChild(zestaw);
            document.Save(nazwa);
            MessageBox.Show("Poprawnie zapisano dane.", "Powodzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form.ActiveForm.Close();
        }
        /// <summary>
        /// Funkcja realizująca ponowne wczytanie dostępnych na dysku pieśni.
        /// </summary>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            //Czyszczenie list obiektów klas pieśni
            Adwentowe.list.Clear();
            Narodzenie.list.Clear();
            Wielkopostne.list.Clear();
            Wielkanocne.list.Clear();
            Milosierne.list.Clear();
            Duchowe.list.Clear();
            Serca.list.Clear();
            Kaplana.list.Clear();
            Maryjne.list.Clear();
            Eucharystyczne.list.Clear();
            Przygodne.list.Clear();
            Saint.list.Clear();
            Michael.list.Clear();
            Bronislaw.list.Clear();
            Pozostale.list.Clear();
            //Odświeżeie list obiektów klas pieśni
            using(tworzenie_listy tworzenie = new tworzenie_listy(Lista))
            {
                tworzenie.ShowDialog(this);
            }
            DecyzjaPiesni();
        }
        /// <summary>
        /// Funkcja decydująca czy są pieśni w listach - jeśli nie zamyka formularz w przeciwnym razie dodaje do kontrolek
        /// </summary>
        private void DecyzjaPiesni()
        {
            // Jeśli nie ma pieśni zamknięcie formularza
            if (Adwentowe.list.Count == 0 && Narodzenie.list.Count == 0 && Wielkopostne.list.Count == 0 && Wielkanocne.list.Count == 0
                   && Milosierne.list.Count == 0 && Duchowe.list.Count == 0 && Serca.list.Count == 0 && Kaplana.list.Count == 0
                   && Maryjne.list.Count == 0 && Eucharystyczne.list.Count == 0 && Przygodne.list.Count == 0 && Saint.list.Count == 0
                   && Michael.list.Count == 0 && Bronislaw.list.Count == 0 && Pozostale.list.Count == 0)
            {
                //TopMost zapobiegający schowanemu MsBox
                MessageBox.Show(new Form { TopMost = true }, "Brak dostępnych pieśni.\nSprawdź lokalizację podaną w ustawieniach i spróbuj ponownie.", "Błąd", MessageBoxButtons.OK);
                Form.ActiveForm.Close();
            }
            // W przeciwnym razie dodanie danych do kontrolek
            else
            {
                Dodanie_do_kontrolek();
            }
        }
        /// <summary>
        /// Funkcja realizująca przypisanie pieśni do kontrolki uCPiesn
        /// </summary>
        /// <param name="uCPiesn">Kontrolka, której należy przypisać.</param>
        /// <param name="sender">Obiekt, który ma zostać przypisany.</param>
        private void SendCategory(UCPiesn uCPiesn, object sender)
        {
            uCPiesn.Piesni = WhatObject(sender);
            uCPiesn.pokazNazwy();
        }
        /// <summary>
        /// Funkcja sprawdzająca kategorie pieśni
        /// </summary>
        /// <param name="sender">Obiekt z nazwą kategorii.</param>
        /// <returns>Zwraca obiekt klasy Piesni</returns>
        private Piesni WhatObject(object sender)
        {
            if(sender.ToString() == Adwentowe.nazwa)
            {
                return Adwentowe;
            }
            else if(sender.ToString()== Narodzenie.nazwa)
            {
                return Narodzenie;
            }
            else if (sender.ToString() == Wielkopostne.nazwa)
            {
                return Wielkopostne;
            }
            else if (sender.ToString() == Wielkanocne.nazwa)
            {
                return Wielkanocne;
            }
            else if (sender.ToString() == Milosierne.nazwa)
            {
                return Milosierne;
            }
            else if (sender.ToString() == Duchowe.nazwa)
            {
                return Duchowe;
            }
            else if (sender.ToString() == Serca.nazwa)
            {
                return Serca;
            }
            else if (sender.ToString() == Kaplana.nazwa)
            {
                return Kaplana;
            }
            else if (sender.ToString() == Maryjne.nazwa)
            {
                return Maryjne;
            }
            else if (sender.ToString() == Eucharystyczne.nazwa)
            {
                return Eucharystyczne;
            }
            else if (sender.ToString() == Przygodne.nazwa)
            {
                return Przygodne;
            }
            else if (sender.ToString() == Saint.nazwa)
            {
                return Saint;
            }
            else if (sender.ToString() == Michael.nazwa)
            {
                return Michael;
            }
            else if (sender.ToString() == Bronislaw.nazwa)
            {
                return Bronislaw;
            }
            else
            {
                return Pozostale;
            }
        }
        #region ChooseCategory
        private void UcPiesn1_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn1, sender);
        }

        private void UcPiesn2_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn2, sender);
        }

        private void UcPiesn3_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn3, sender);
        }

        private void UcPiesn4_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn4, sender);
        }

        private void UcPiesn5_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn5, sender);
        }

        private void UcPiesn6_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn6, sender);
        }

        private void UcPiesn7_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn7, sender);
        }

        private void UcPiesn8_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn8, sender);
        }

        private void UcPiesn9_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn9, sender);
        }

        private void UcPiesn10_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn10, sender);
        }

        private void UcPiesn11_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn11, sender);
        }

        private void UcPiesn12_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn12, sender);
        }

        private void UcPiesn13_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn13, sender);
        }

        private void UcPiesn14_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn14, sender);
        }

        private void UcPiesn15_ChooseCategory(object sender, EventArgs e)
        {
            SendCategory(ucPiesn15, sender);
        }
        #endregion
    }
}
