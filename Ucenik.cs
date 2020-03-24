using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinNasljeđivanje
{
    class Ucenik : Osoba
    {
        private int razred;

        public int Razred { get => razred; set => razred = value; }
    }
}
