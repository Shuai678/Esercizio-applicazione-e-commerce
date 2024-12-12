using eCommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esecizio_applicazione_ecommerce
{
    internal class ProdottoAlimentare : Prodotto
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
        }

        public override double Prezzo
        {
            get { return PrezzoBase * 0.8; } 
        }
        public ProdottoAlimentare(string marca, string modello, string identificativo, string tipo, double prezzo) : base(marca, modello, identificativo, prezzo)
        {
            
        }
    }
}
