using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Dziennik_Pracy
{
    public class Piesni : ISerializable
    {
        public List<string> list = new List<string>();
        public string nazwa = "";
        /// <summary>
        /// Konstruktor klasowy, który tworzy obiek i przypisuje mu nazwę.
        /// </summary>
        /// <param name="nazwa">String określający nazwę obiektu.</param>
        public Piesni(string nazwa)
        {
            this.nazwa = nazwa;
        }
        /// <summary>
        /// Funkcja realizująca dodanie do listy pieśni nazwy pieśni.
        /// </summary>
        /// <param name="nazwa">Nazwa pieśni w formacie string.</param>
        public void dodaj(string nazwa)
        {
            list.Add(nazwa);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //Nothing
        }
        /// <summary>
        /// Sortowanie rosnąco pieśni.
        /// </summary>
        public void sortuj_rosnaco()
        {
            list.Sort();
        }
        /// <summary>
        /// Funkcja zwraca nazwy pieśni z listy obiektu..
        /// </summary>
        /// <returns>Zwraca string z nazwami pieśni.</returns>
        public string wyswietl()
        {
            string lista = "";
            foreach(string nazwa in list)
            {
                lista += nazwa;
            }
            return lista;
        }
        /// <summary>
        /// Funkcja realizująca zapis pieśni w formie serializacji pieśni do pliku o rozszerzeniu *.bin.
        /// </summary>
        public void Zapis()
        {
            String plik = this.nazwa + ".bin";
            if (File.Exists(plik))
            {
                File.Delete(plik);
            }
            try
            {
                Stream SaveFileStream = File.Create(plik);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, this.list);
                SaveFileStream.Close();
            }
            catch
            {
                MessageBox.Show("Wystąpił problem z zapisem pieśni.", "Błąd");
            }
        }
        /// <summary>
        /// Funkcja realizująca odczyt pieśni z pliku o rozszerzeniu *.bin, gdzie są serializowane pieśni.
        /// </summary>
        public void Odczyt()
        {
            String plik = this.nazwa + ".bin";
            if (!File.Exists(plik))
            {
                return;
            }
            try
            {
                Stream openFileStream = File.OpenRead(plik);
                BinaryFormatter deserializer = new BinaryFormatter();
                this.list = (List<string>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();
            }
            catch
            {
                MessageBox.Show("Wystąpił problem z odczytem pieśni.", "Błąd");
            }
        }
    }
}