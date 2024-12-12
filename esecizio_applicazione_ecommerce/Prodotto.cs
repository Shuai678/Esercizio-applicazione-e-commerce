namespace eCommerce
{
    public class Prodotto
    {
        private string marca;
        private string modello;
        private double prezzoBase;
        private string identificativo;

        public string Marca
        {
            get { return marca; }
        }

        public string Modello
        {
            get { return modello; }
        }

        public virtual double Prezzo
        {
            get { return prezzoBase; }
        }

        public string Identificativo
        {
            get { return identificativo; }
        }

        public double PrezzoBase
        {
            get { return prezzoBase; }
        }

        public Prodotto(string marca, string modello, string identificativo, double prezzoBase)
        {
            this.marca = marca;
            this.modello = modello;
            this.identificativo = identificativo;
            this.prezzoBase = prezzoBase;
        }
    }
}
