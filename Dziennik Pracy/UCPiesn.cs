using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Dziennik_Pracy
{
    public partial class UCPiesn : UserControl
    {
        public UCPiesn()
        {
            InitializeComponent();
            #region ITEMS SHORTBOX-A
            shortBox.Items.Add("N");
            shortBox.Items.Add("W");
            shortBox.Items.Add("PD");
            shortBox.Items.Add("K");
            shortBox.Items.Add("D");
            shortBox.Items.Add("R");
            shortBox.Items.Add("A");
            shortBox.Items.Add("B");
            #endregion
        }
        #region Properties
        private string _short;
        private string _category;
        private string _nameof;

        public event EventHandler ChooseCategory;

        protected virtual void OnChooseCategory(EventArgs e)
        {
            ChooseCategory?.Invoke(this.CatBox.Text, e);
        }

        [Category("Własne ustawienia")]
        public string Short
        {
            get { return _short; }
            set { _short = value; shortBox.Text = value; }
        }

        [Category("Własne ustawienia")]
        public string Category
        {
            get { return _category; }
            set { _category = value; CatBox.Text = value; }
        }

        [Category("Własne ustawienia")]
        public string Nameof
        {
            get { return _nameof; }
            set { _nameof = value; NameBox.Text = value; }
        }

        [Category("Własne ustawienia")]
        public Piesni Piesni { get; set; }
        #endregion
        /// <summary>
        /// Funkca odpowiedzialna za odświżenie kontrolek i ich zawartości.
        /// </summary>
        /// <param name="list">Lista obiektów klasy Piesni.</param>
        public void refreshing(List<Piesni> list)
        {
            CatBox.Items.Clear();
            // Czyszczenie podpowiadania dla pola CatBox
            CatBox.AutoCompleteCustomSource.Clear();
            NameBox.Items.Clear();
            // Czyszczenie podpowiadania dla pola NameBox
            NameBox.AutoCompleteCustomSource.Clear();
            foreach(Piesni obiekt in list)
            {
                dodajKategorie(obiekt);
            }
        }
        /// <summary>
        /// Funkcja odpowiedzialna za dodanie do kontroli CatBox nazw kategori, oraz dodanie do listy podpowiadającej.
        /// </summary>
        /// <param name="piesni">Obiekt klasy Piesni.</param>
        private void dodajKategorie(Piesni piesni)
        {
            CatBox.Items.Add(piesni.nazwa);
            CatBox.AutoCompleteCustomSource.Add(piesni.nazwa);
        }
        /// <summary>
        /// Funkcja dodająca do kontrolki NameBox nazwy pieśni. Dodatkowo funkcja ta dodaje tę nazwę do listy odpowiadającej za podpowiadanie.
        /// </summary>
        public void pokazNazwy()
        {
            foreach(String name in Piesni.list)
            {
                NameBox.Items.Add(name);
                NameBox.AutoCompleteCustomSource.Add(name);
            }
        }
        /// <summary>
        /// Funkcja wywoływana, gdy kategoria zostanie zmieniona.
        /// </summary>
        private void CatBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameBox.Items.Clear();
            // Czyszczenie podpowiedzi dla pola NameBox
            NameBox.AutoCompleteCustomSource.Clear();
            if(NameBox.Text != "")
            {
                NameBox.Text = "";
                _nameof = "";
            }
            if (CatBox.Text == "")
            {
                NameBox.Enabled = false;
                _category = "";
                return;
            }
            if (NameBox.Enabled != true)
            {
                NameBox.Enabled = true;
            }
            _category = CatBox.Text;
            try
            {
                OnChooseCategory(EventArgs.Empty);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Funkcja przy zmianie indexu kontrolki NameBox zapisuje nazwę do zmiennej klasy.
        /// </summary>
        private void NameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _nameof = NameBox.Text;
        }
        /// <summary>
        /// Funkca przy zmianie indexu kontrolki shortBox zapisuje ją do zmiennej klasy.
        /// </summary>
        private void shortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _short = shortBox.Text;
        }
        /// <summary>
        /// Po opuszczeniu kontrolki shortBox wartość wproawdzona przez użytkownika jest sprawdzana.
        /// </summary>
        private void shortBox_Leave(object sender, EventArgs e)
        {
            this.shortBox.Text = shortBox.Text.ToUpper();
            string tekst = shortBox.Text;
            #region Zabezpieczenie przed nieodpowiednią treścią
            if (tekst == "N")
            {
                shortBox.SelectedIndex = 0;
            }
            else if(tekst == "W"){
                shortBox.SelectedIndex = 1;
            }
            else if(tekst == "PD" || tekst == "P")
            {
                shortBox.SelectedIndex = 2;
            }
            else if(tekst == "K")
            {
                shortBox.SelectedIndex = 3;
            }
            else if( tekst == "D")
            {
                shortBox.SelectedIndex = 4;
            }
            else if(tekst == "R")
            {
                shortBox.SelectedIndex = 5;
            }
            else if(tekst == "B")
            {
                shortBox.SelectedIndex = 7;
            }
            else if(tekst == "A")
            {
                shortBox.SelectedIndex = 6;
            }
            else
            {
                shortBox.SelectedIndex = 0;
            }
            #endregion
        }
    }
}
