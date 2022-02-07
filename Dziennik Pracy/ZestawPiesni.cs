using System;
using System.Collections.Generic;

namespace Dziennik_Pracy
{
    class ZestawPiesni
    {
        #region Zmienne klasowe
        public DateTime Data { get; }
        private List<PiesniGrane> Zestaw = new List<PiesniGrane>();
        public string name { get; }
        #endregion
        /// <summary>
        /// Konstruktor klasy ZestawPiesni, który przypisuje wartości stałe do obiektu i tworzy obiekt tej klasy.
        /// </summary>
        /// <param name="nazwa">String określający nazwę zestawu pieśni.</param>
        /// <param name="date">DateTime określający datę, do której zestaw jest przypisany.</param>
        public ZestawPiesni(string nazwa, DateTime date) {
            this.name = nazwa;
            this.Data = date;
        }
        /// <summary>
        /// Metoda dodająca piesn w formacie obiektu klasy PiesniGrane do listy zestawu.
        /// </summary>
        /// <param name="piesn">Parametr to obiekt klasy PiesniGrane.</param>
        public void DodajPiesn(PiesniGrane piesn)
        {
            Zestaw.Add(piesn);
        }
        /// <summary>
        /// Funkcja publiczna, której zadaniem jest zwrócenie zestawu pieśni.
        /// </summary>
        /// <returns>Zwraca zestaw pieśni, czyli listę obiektów klasy PiesniGrane.</returns>
        public List<PiesniGrane> DajPiesni()
        {
            return Zestaw;
        }
    }
}
