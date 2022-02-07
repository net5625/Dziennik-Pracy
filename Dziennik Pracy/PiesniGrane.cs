
namespace Dziennik_Pracy
{
    /// <summary>
    /// Klasa określająca zestaw danych Pieśń - Typ(moment wykonania).
    /// </summary>
    class PiesniGrane
    {
        public string ShortType { get; }
        public string Name { get; }
        /// <summary>
        /// Konstruktor klasy PiesniGrane, który inicjuje wartości typu i nazwy pieśni.
        /// </summary>
        /// <param name="type">Określa typ dla użytej pieśni, wykorzystując specyfikację czasową. ex.A, B, D, K, N, PD, R, W.</param>
        /// <param name="name">Określa nazwę pieśni.</param>
        public PiesniGrane(string type, string name)
        {
            this.ShortType = type;
            this.Name = name;
        }
    }
}
