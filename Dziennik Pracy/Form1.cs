using System;
using System.IO;
using System.Windows.Forms;

namespace Dziennik_Pracy
{
    /// <summary>
    /// Klasa Home reprezentuje menu aplikacji.
    /// </summary>
    public partial class Home : Form
    {
        /// <summary>
        /// Konstruktor inicjalizuje odpowiednie komponenty.
        /// </summary>
        public Home()
        {
            InitializeComponent();
        }
        #region Przyciski MENU
        /// <summary>
        /// Akcja - Utwórz zestaw pieśni.
        /// </summary>
        private void buttonZestaw_Click(object sender, EventArgs e)
        {
            UtworzZestaw zestaw = new UtworzZestaw();
            zestaw.Show();
        }
        /// <summary>
        /// Akcja - zapisz obecność na stanowisku pracy.
        /// </summary>
        private void buttonObecnosc_Click(object sender, EventArgs e)
        {
            obecnosc obecnosc = new obecnosc();
            obecnosc.Show();
        }
        /// <summary>
        /// Akcja - wyświetla zestawy. - TYMCZASOWO WYŁĄCZONA
        /// </summary>
        private void buttonDane_Click(object sender, EventArgs e)
        {
            if (File.Exists("zestawy.xml"))
            {
                zestawy zestawy = new zestawy();
                zestawy.Show();
            }
            else
            {
                MessageBox.Show("Brak danych!", "Plik nie istnieje!");
            }
        }
        /// <summary>
        /// Utworzenie sprawozdania jeśli istnieje plik obecnosc.xml
        /// </summary>
        private void buttonSprawozdanie_Click(object sender, EventArgs e)
        {
            if (File.Exists("obecnosc.xml"))
            {
                Sprawozdanie sprawozdanie = new Sprawozdanie();
                sprawozdanie.Show();
            }
            else
            {
                MessageBox.Show("Brak danych!", "Plik nie istnieje!");
            }
        }
        /// <summary>
        /// Prymitywne ustawienia aplikacji czyli ustawienie ścieżki
        /// ze slajdami.
        /// </summary>
        private void settingsButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.Ustawienie = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// Przycisk odpowiedzialny za zamknięcie aplikacji.
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
