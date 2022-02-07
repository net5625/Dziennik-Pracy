using System;

public class Piesni
{
	protected list<string> list = new list<string>();
	void dodaj(string nazwa)
    {
        list.Add(nazwa);
    }
    void sortuj_rosnaco()
    {
        list.sort();
    }
}
