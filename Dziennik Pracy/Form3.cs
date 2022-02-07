using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik_Pracy
{
    /// <summary>
    /// Klasa reprezentująca formularz ładowania w trakcie wykonywania akcji.
    /// </summary>
    public partial class tworzenie_listy : Form
    {
        public Action Reaction { get; set; }
        /// <summary>
        /// Konstruktor obiektu klasy tworzenie_listy; W swoim ciele inicjalizuje komponenty oraz przyjmuje funkcję do wykonania.
        /// </summary>
        /// <param name="action">Parametr akcji, który oznacza czynność do wykonania w trakcie życia formularza.</param>
        public tworzenie_listy(Action action)
        {
            InitializeComponent();
            if(action == null)
            {
                return;
            }
            Reaction = action;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 10;
        }
        /// <summary>
        /// Funkcja zajmująca się oddzielnym "wątkiem", który w tle ładowania wykonuje funkcję; a po jej zakończeniu zamyka formularz.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Reaction).ContinueWith(t => { Invoke(new Action(Close)); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
