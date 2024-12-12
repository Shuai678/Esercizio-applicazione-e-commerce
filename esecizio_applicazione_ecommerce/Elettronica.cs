using eCommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esecizio_applicazione_ecommerce
{
    internal class Elettronica : Prodotto
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
        }

        public override double Prezzo
        {
            get { return PrezzoBase * 0.9; }
        }

        public Elettronica(string marca, string modello, string identificativo, string tipo, double prezzoBase) : base(marca, modello, identificativo, prezzoBase)
        {

        }


    }
}
