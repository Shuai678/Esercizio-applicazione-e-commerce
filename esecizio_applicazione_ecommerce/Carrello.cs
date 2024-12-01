namespace eCommerce
{
    class Carrello
    {
        private string identificativo;

        private List<Prodotto> prodottiCarrello;

        public List<Prodotto> ProdottiCarrello
        {
            get { return prodottiCarrello; }
        }
        public string Identificativo
        {
            get { return identificativo; }
        }
        public void aggiungiProdotto(Prodotto prodotto)
        {
            if (prodotto == null)
                return;
            prodottiCarrello.Add(prodotto);
        }
        public void rimuoviProdotto(Prodotto prodotto)
        {
            if (prodotto == null)
                return;
            prodottiCarrello.Remove(prodotto);
        }
        /*
        public void rimuoviProdottoVistaInClasse(Prodotto prodotto)
        {
            if (prodotto == null)
                return;
            int pos = prodottiCarrello.IndexOf(prodotto);
            if (pos != -1)
                prodottiCarrello.RemoveAt(pos);
        }*/
        public void svuotaCarrello()
        {
            prodottiCarrello.Clear();
        }

        public Carrello(string identificativo)
        {
            this.identificativo = identificativo;
            prodottiCarrello = new List<Prodotto>();
        }
    }
}
