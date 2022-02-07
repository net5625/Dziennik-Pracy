using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Dziennik_Pracy
{
    /// <summary>
    /// Klasa odpowiadająca jednemu dniu w sprawozdaniu.
    /// </summary>
    public class Dzien
    {
        /// <summary>
        /// Zmienna Data odpowiedzialna za przechowywanie daty dnia sprawozdania.
        /// </summary>
        public string Data { get;}
        /// <summary>
        /// Zmienna Ilosc odpowiedzialna za przechowywanie ilość pracy na dzień sprawozdania.
        /// </summary>
        public string Ilosc { get; set; }
        /// <summary>
        /// Klasa Dzien opisuje dzień do sprawozdania z wykonanej pracy.
        /// </summary>
        /// <param name="data">Data dnia sprawozdnia.</param>
        /// <param name="ilosc">Ilość sztuk wykonanej pracy w formie string do sprawozdania.</param>
        public Dzien(string data, string ilosc)
        {
            this.Data = data;
            this.Ilosc = ilosc;
        }
    }
    /// <summary>
    /// Klasa sprawozdanie odpowiedzialna za tworzenie sprawozdania z pracy w formacie *.pdf.
    /// </summary>
    public partial class Sprawozdanie : Form
    {
        #region zmienne
        private static string path = "obecnosc.xml";
        public List<Dzien> sprawozdanie = new List<Dzien>();
        public List<DateTime> dniWolne = new List<DateTime>();
        private XmlTextReader reader;
        #endregion

        public Sprawozdanie()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Akcja zamknięcia formularza.
        /// </summary>
        /// <param name="sender">Obiekt</param>
        /// <param name="e">Argument</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
        /// <summary>
        /// Akcja zapisu z do pdf.
        /// </summary>
        /// <param name="sender">Obiekt</param>
        /// <param name="e">Argument</param>
        private void Button2_Click(object sender, EventArgs e)
        {
            TimeSpan date = koncowaData.Value - poczatkowaData.Value;
            int ilosc = date.Days;
            if (ilosc <= 0 || ilosc > 14)
            {
                MessageBox.Show("Wybrano błędny odstęp czasu.\nPrawidłowy zakres dat znajduje się w granicu 1 - 14 dni.", "Ostrzeżenie", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (SavePdfFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4, 7f, 5f, 5f, 0f);
                try
                {
                    BaseColor white = new BaseColor(System.Drawing.ColorTranslator.FromHtml("#fff"));
                    BaseColor black = new BaseColor(System.Drawing.ColorTranslator.FromHtml("#222"));
                    int italicStyle = iTextSharp.text.Font.ITALIC;
                    Font mainFont = FontFactory.GetFont("Century Gothic", 22, white);
                    Font normalFont = FontFactory.GetFont("Century Gothic", 18, white);
                    Font normalFontBlack = FontFactory.GetFont(BaseFont.COURIER, BaseFont.CP1257, 12, 0, black);
                    Font smallItalitcFont = FontFactory.GetFont("Century Gothic", 10, italicStyle, black);
                    PdfWriter.GetInstance(doc, new FileStream(SavePdfFileDialog.FileName, FileMode.Create));
                    doc.Open();
                    
                    PdfPTable tabela = new PdfPTable(2);
                    //Nagłówek
                    PdfPCell head = new PdfPCell(new Phrase("Sprawozdanie \nod " + poczatkowaData.Value.ToString("yyyy-MM-dd") + " do " 
                        + koncowaData.Value.ToString("yyyy-MM-dd"),mainFont));
                    head.Colspan = 2;
                    head.HorizontalAlignment = 1;
                    head.Padding = 4;
                    head.PaddingTop = 2;
                    head.BackgroundColor = new BaseColor(88,176,156);
                    tabela.AddCell(head);
                    //Treść tabeli
                    //Odczyt danych z pliku obecnosc.xml jeżeli się da - w innym wypadku throw...
                    if (!Dane(poczatkowaData.Value,koncowaData.Value))
                    {
                        throw new Exception("Błąd odczytu danych.");
                    }
                    //Dodanie danych pobranych z pliku lub poinformowanie o ich braku
                    if(sprawozdanie.Count!=0)
                    {
                        #region Dni wolne
                        //Podstawowe dni wolne od pracy /nie ruchome/
                        //Nowy rok
                        dniWolne.Add(new DateTime(DateTime.Now.Year,1,1));
                        //Objawienie Pańskie
                        dniWolne.Add(new DateTime(DateTime.Today.Year,1,6));
                        //Uroczystość bł. Bronisława Markiewicza
                        dniWolne.Add(new DateTime(DateTime.Today.Year,1,30));
                        //Święto Ofiarowania Pańskiego
                        dniWolne.Add(new DateTime(DateTime.Today.Year, 2, 2));
                        //Święto Państwowe
                        dniWolne.Add(new DateTime(DateTime.Today.Year,5,1));
                        //Święto Narodowe Trzeciego Maja; Uroczystość MB Królowej Korony Polskiej
                        dniWolne.Add(new DateTime(DateTime.Today.Year,5,3));
                        //Wniebowzięcie NMP
                        dniWolne.Add(new DateTime(DateTime.Today.Year,8,15));
                        //Wszystkich Świętych
                        dniWolne.Add(new DateTime(DateTime.Today.Year,11,1));
                        //Narodowe Święto Niepodległości
                        dniWolne.Add(new DateTime(DateTime.Today.Year,11,11));
                        //Boże Narodzenie
                        dniWolne.Add(new DateTime(DateTime.Today.Year,12,25));
                        //Święto św. Szczepana - drugi dzień Bożego Narodzenia
                        dniWolne.Add(new DateTime(DateTime.Today.Year,12,26));
                        #endregion
                        // TODO: Dlaczego 1.1 nie jest na czerwono?
                        foreach (Dzien day in sprawozdanie)
                        {
                            BaseColor kolor_zwykly = new BaseColor(61,64,91);
                            BaseColor kolor_swiateczny = new BaseColor(200,62,77);
                            BaseColor kolor = kolor_zwykly;
                            if (DateTime.Parse(day.Data).DayOfWeek == DayOfWeek.Sunday || SwietoOrNot(DateTime.Parse(day.Data)))
                            {
                                kolor = kolor_swiateczny;
                            }
                            PdfPCell prawa = new PdfPCell(new Phrase(day.Data, normalFont));
                            prawa.BackgroundColor = kolor;
                            prawa.Padding = 2;
                            prawa.PaddingBottom = 4;
                            tabela.AddCell(prawa);
                            PdfPCell lewa = new PdfPCell(new Phrase(day.Ilosc, normalFont));
                            lewa.BackgroundColor = kolor;
                            lewa.Padding = 2;
                            lewa.PaddingBottom = 4;
                            tabela.AddCell(lewa);
                            kolor = kolor_zwykly;
                        }
                    }
                    else
                    {
                        tabela.AddCell(new Phrase("Brak danych do wyświetlenia."));
                    }
                    //Dodanie zawartości
                    doc.Add(tabela);
                    doc.Add(new Phrase("Oznaczenia: \nM - Msza; \nN - Nabożeństwo; \nG - Godzinki; \nDK - Droga Krzyżowa; \nNP - Nabożeństwo Pasyjne.\n\n", normalFontBlack));
                    doc.Add(new Phrase("Utworzono dnia: " + DateTime.Now.ToString("yyyy-MM-dd") + " przy pomocy programu Dziennik Organisty", smallItalitcFont));
                    doc.AddCreationDate();
                    doc.AddTitle("Sprawozdanie od " + poczatkowaData.Value.ToString() + "do " + koncowaData.Value.ToString());
                    doc.AddKeywords("Sprawozdanie;Czas pracy;Organista");
                    doc.AddLanguage("PL");
                    doc.AddAuthor("Sylwester Zimka");
                }
                catch
                {
                    if (doc.IsOpen())
                    {
                        PdfPTable tabela = new PdfPTable(1);
                        PdfPCell head = new PdfPCell(new Phrase("Error! Can't save information to this file."));
                        tabela.AddCell(head);
                        doc.Add(tabela);
                    }
                    MessageBox.Show("Błąd podczas zapisu pliku PDF.", "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally{
                    if(doc.IsOpen() == true)
                    {
                        doc.Close();
                    }
                    
                    MessageBox.Show("Zakończono proces zapisywania", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form.ActiveForm.Close();
                }
            }
        }
        /// <summary>
        /// Funkcja realizująca wymuszenie na użytkowniku zakresu nie większego niż 14 dni. 
        /// </summary>
        private void poczatkowaData_ValueChanged(object sender, EventArgs e)
        {
            koncowaData.MaxDate = poczatkowaData.Value.AddDays(13);
            koncowaData.MinDate = poczatkowaData.Value;
        }
        /// <summary>
        /// Funkcja realizująca wymuszenie na użytkowniku zakresu nie większego niż 14 dni.
        /// </summary>
        private void koncowaData_ValueChanged(object sender, EventArgs e)
        {
            poczatkowaData.MinDate = koncowaData.Value.AddDays(-13);
            poczatkowaData.MaxDate = koncowaData.Value;
        }
        /// <summary>
        /// Funkcja pobierające informacje o obecności na stonowisku pracy pomiędzy dwiema datami.
        /// </summary>
        /// <param name="start">Parametr określający początek zakresu czasu.</param>
        /// <param name="stop">Parametr określający koniec zakresu czasu.</param>
        /// <returns>Po wykonaniu zadania zwraca true.</returns>
        private bool Dane(DateTime start, DateTime stop)
        {
            reader = new XmlTextReader(path);
            string ilosc = "";
            string data = "";
            bool poprawna = false;
            while (reader.Read())
            {
                //Sprawdzamy węzły po kolei...
                if (reader.NodeType == XmlNodeType.Element) {
                    //Węzeł Day
                    if (reader.Name == "Day")
                    {
                        DateTime dzien = DateTime.Parse(reader.GetAttribute("Date").ToString());
                        //Dzień pomiędzy początkiem okresu sprawozdawczego a końcem?
                        if (dzien.Date >= start.Date && dzien.Date <= stop.Date)
                        {
                            data += dzien.ToString("yyyy-MM-dd");
                            poprawna = true;
                        }
                        else
                        {
                            poprawna = false;
                        }
                    }
                    //Jeżeli węzeł Mass
                    else if (reader.Name == "Mass")
                    {
                        int wynik = int.Parse(reader.ReadString());
                        if (poprawna)
                        {
                            //Jeśli data poprawna, pobierzmy ilość M
                            if (wynik != 0 && wynik > 0)
                            {
                                for (int i = 0; i < wynik; i++)
                                {
                                    ilosc += "M, ";
                                }
                            }
                        }
                    }
                    //Jeżeli węzeł Devotion
                    else if (reader.Name == "Devotion")
                    {
                        int wynik = int.Parse(reader.ReadString());
                        if (poprawna)
                        {
                            //Jeśli data poprawna, pobierzmy ilość N
                            if (wynik != 0 && wynik > 0)
                            {
                                for (int i = 0; i < wynik; i++)
                                {
                                    ilosc += "N, ";
                                }
                            }
                        }
                    }
                    //Jeżeli węzeł Matins
                    else if (reader.Name == "Matins")
                    {
                        int wynik = int.Parse(reader.ReadString());
                        if (poprawna)
                        {
                            //Jeśli data poprawna, pobierzmy ilość G
                            if (wynik != 0 && wynik > 0)
                            {
                                for (int i = 0; i < wynik; i++)
                                {
                                    ilosc += "G, ";
                                }
                            }
                        } 
                    }
                    //Jeżeli węzeł Cross
                    else if (reader.Name == "Cross")
                    {
                        int wynik = int.Parse(reader.ReadString());
                        if (poprawna)
                        {
                            //Jeśli data poprawna, pobierzmy ilość DK
                            if (wynik != 0 && wynik > 0)
                            {
                                for (int i = 0; i < wynik; i++)
                                {
                                    ilosc += "DK, ";
                                }
                            }
                        }
                    }
                    //Jeżeli węzeł Bitter
                    else if (reader.Name == "Bitter")
                    {
                        int wynik = int.Parse(reader.ReadString());
                        if (poprawna)
                        {
                            //Jeśli data poprawna, pobierzmy ilość Gorzkich Żali i zapisujemy jako Nabożeństwo pasyjne.
                            if (wynik != 0 && wynik > 0)
                            {
                                for (int i = 0; i < wynik; i++)
                                {
                                    ilosc += "NP, ";
                                }
                            }
                            //Zapis danych
                            CheckAndSave(data,ilosc);
                        }
                        data = "";
                        ilosc = "";
                        poprawna = false;
                    }
                }
            }
            //Zamknięcie readera.
            reader.Close();
            return true;
        }
        /// <summary>
        /// Funkcja sprawdzająca czy data podana jako argument jest dniem zdefiniowanym w liście dni świątecznych.
        /// </summary>
        /// <param name="data">Parametr przyjęty do sprawdzenia czy jest to dzień świąteczny.</param>
        /// <returns>Zwraca true jeśli dzień ten należy do listy dni świątecznych. W przeciwnym racie zwraca false.</returns>
        private bool SwietoOrNot(DateTime data)
        {
            if(dniWolne.FindIndex(x => x.DayOfYear.ToString() == data.DayOfYear.ToString()) != -1)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Funkcja realizująca złączenie jeśli dzień istnieje już w liście sprawozdanie.
        /// </summary>
        /// <param name="data">Parametr string określa dzień obiektu Dzien.</param>
        /// <param name="ilosc">Parametr string określa ilość obiektu Dzien.</param>
        private void CheckAndSave(string data, string ilosc)
        {
            //Jezeli istnieje już
            if (sprawozdanie.Find(x => x.Data == data) != null)
            {
                int index;
                index = sprawozdanie.FindIndex(x => x.Data == data);
                sprawozdanie[index].Ilosc += ilosc;
            }
            //W przeciwnym razie
            else
            {
                sprawozdanie.Add(new Dzien(data, ilosc));
            }
        }
    }
}
