﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinNasljeđivanje
{
    class Osoba
    {
        string ime;
        string prezime;

        public string Prezime { get => prezime; set => prezime = value; }
        public string Ime { get => ime; set => ime = value; }
        public override string ToString()
        {
            string ispis = "Ime " + this.ime + " Prezime: " + this.prezime;
            return ispis;
        }
        public string DohvatiPodatke()
        {
            string ispis = "\nIme " + this.ime + " \nPrezime: " + this.prezime;
            return ispis;
        }
    }
}
