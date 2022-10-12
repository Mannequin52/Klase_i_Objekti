using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseObjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciranje objekta 1

            Osoba osoba = new Osoba();
            osoba.SetIme("Pero");
            osoba.SetPrezime("Perić");
            osoba.SetGodinaRodjenja(2005);
            osoba.SetVisina(175);
            osoba.SetTezina(69);
            osoba.SetSpol('M');

             Console.WriteLine("Osoba 1:");
            /*Console.WriteLine("Ime i prezime: " + osoba.GetIme() + " " + osoba.GetPrezime()
                + "\r\nGodina rođenja:" + osoba.GetGodinaRodjenja()
                + "\r\nVisina:" + osoba.GetVisina()
                + "\r\nTezina:" + osoba.GetTezina()
                + "\r\nSpol:" + osoba.GetSpol()); */
            Console.WriteLine(osoba.Ispis());

            //instanciranje objekta 2
            Osoba osoba2 = new Osoba("Ana", "Anić", 2005, 164, 56, 'Ž');

            Console.WriteLine("Osoba 2:");
            Console.WriteLine(osoba2.Ispis());
            Console.WriteLine("Osoba 2: - override");
            Console.WriteLine(osoba2.ToString());



            Console.ReadKey();
        }
       

    }
    class Osoba {

        //svojstva
        string ime, prezime;
        int godinaRodjenja, visina, tezina;
        char spol;

        //metode

        //set metode
        public void SetIme(string ime)
        {
            this.ime = ime;
        }
        public void SetPrezime(string prezime)
        {
            this.prezime = prezime;
        }
        public void SetGodinaRodjenja(int godinaRodjenja)
        {
            this.godinaRodjenja = godinaRodjenja;
        }
        public void SetVisina(int visina)
        {
            this.visina = visina;
        }
        public void SetTezina(int tezina)
        {
            this.tezina = tezina;
        }
        public void SetSpol(char spol)
        {
            this.spol = spol;
        }

        //get metode - čitanje vrijednosti svojstava

        public string GetIme()
        {
            return this.ime;
        }
        public string GetPrezime()
        {
            return this.prezime;
        }
        public int GetGodinaRodjenja()
        {
            return this.godinaRodjenja;
        }
        public int GetVisina()
        {
            return this.visina;
        }
        public int GetTezina()
        {
            return this.tezina;
        }
        public char GetSpol()
        {
            return this.spol;
        }

        //metode za ispis
        public string Ispis() { 
        string ispis = ("Ime i prezime: " + this.GetIme() + " " + this.GetPrezime()
                + "\r\nGodina rođenja:" + this.GetGodinaRodjenja()
                + "\r\nVisina:" + this.GetVisina()
                + "\r\nTezina:" + this.GetTezina()
                + "\r\nSpol:" + this.GetSpol());
            return ispis;
            }
        public override string ToString()
        {
            string ispis = ("Ime i prezime: " + this.GetIme() + " " + this.GetPrezime()
                + "\r\nGodina rođenja:" + this.GetGodinaRodjenja()
                + "\r\nVisina:" + this.GetVisina()
                + "\r\nTezina:" + this.GetTezina()
                + "\r\nSpol:" + this.GetSpol());
            return ispis;
        }
        //konstruktori

        public Osoba()
        {

        }

        public Osoba(string ime, string prezime, int godinaRodjenja, int visina, int tezina, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godinaRodjenja = godinaRodjenja;
            this.visina = visina;
            this.tezina = tezina;
            this.spol = spol;

        }


    }
}
