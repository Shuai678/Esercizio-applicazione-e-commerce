using eCommerce;
using System;
using System.Windows.Forms;

namespace esecizio_applicazione_ecommerce
{
    public partial class Form1 : Form
    {
        private List<Prodotto> prodottiDisponibili = new List<Prodotto>();

        private Carrello carrello = new Carrello("C001");

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            prodottiDisponibili.Add(new Elettronica("Apple", "iPhone 16", "001", "Elettronico", 999.99));
            prodottiDisponibili.Add(new Elettronica("Apple", "iPhone 16 Pro", "002", "Elettronico", 1239));
            prodottiDisponibili.Add(new Elettronica("Samsung", "Galaxy S24", "003", "Elettronico", 899.99));
            prodottiDisponibili.Add(new Elettronica("Google", "Pixel 8", "004", "Elettronico", 799.99));
            prodottiDisponibili.Add(new ProdottoAlimentare("Aia", "Fette di pollo", "005", "Alimentare", 100));
            prodottiDisponibili.Add(new ProdottoAlimentare("Conad", "Acqua naturale", "006", "Alimentare", 1.60));
            prodottiDisponibili.Add(new ProdottoAlimentare("Monster", "Mango loco", "007", "Alimentare", 2.50));
            prodottiDisponibili.Add(new ProdottoAlimentare("Melinda", "Mele verdi", "008", "Alimentare", 2.30));


            foreach (Prodotto prodotto in prodottiDisponibili)
            {
                if (prodotto is Elettronica)
                    Prodotti_listBox1.Items.Add($"{prodotto.Marca} {prodotto.Modello} - €{prodotto.PrezzoBase}");
            }
            foreach (Prodotto prodotto in prodottiDisponibili)
            {
                if (prodotto is ProdottoAlimentare)
                    Prodotti_listBox3.Items.Add($"{prodotto.Marca} {prodotto.Modello} - €{prodotto.PrezzoBase:F2}");
            }
        }

        private void Prodotti_listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prodotti_listBox3.ClearSelected();
            int index = Prodotti_listBox1.SelectedIndex;
            if (index >= 0 && index < prodottiDisponibili.Count)
            {
                Prodotto prodotto = prodottiDisponibili[index];
                label2.Text = $"Marca: {prodotto.Marca}\nModello: {prodotto.Modello}\nPrezzo scontato: €{prodotto.Prezzo:F2}";

            }

        }
        private void Prodotti_listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prodotti_listBox1.ClearSelected();
            List<Prodotto> prodottiAlimentari = new List<Prodotto>();

            for (int i = 0; i < prodottiDisponibili.Count; i++)
            {
                if (prodottiDisponibili[i] is ProdottoAlimentare)
                {
                    prodottiAlimentari.Add(prodottiDisponibili[i]);
                }
            }

            int index = Prodotti_listBox3.SelectedIndex;

            if (index >= 0 && index < prodottiAlimentari.Count)
            {
                Prodotto prodotto = prodottiAlimentari[index];
                label2.Text = $"Marca: {prodotto.Marca}\nModello: {prodotto.Modello}\nPrezzo scontato: €{prodotto.Prezzo:F2}";

            }

        }

        private void Carrello_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Carrello_listBox.SelectedIndex;
            if (index >= 0 && index < carrello.ProdottiCarrello.Count)
            {
                Prodotto prodotto = carrello.ProdottiCarrello[index];
                label2.Text = $"Selezionato dal carrello:\nMarca: {prodotto.Marca}\nModello: {prodotto.Modello}\nPrezzo scontato: €{prodotto.Prezzo}";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rimuovi_btn_Click(object sender, EventArgs e)
        {
            int index = Carrello_listBox.SelectedIndex;
            if (index >= 0 && index < carrello.ProdottiCarrello.Count)
            {
                Prodotto prodotto = carrello.ProdottiCarrello[index];
                carrello.rimuoviProdotto(prodotto);
                Carrello_listBox.Items.RemoveAt(index);
                AggiornaTotale();
            }
            else
            {
                MessageBox.Show("Seleziona un prodotto dal carrello da rimuovere.");
            }
        }

        private void Svuota_btn_Click(object sender, EventArgs e)
        {
            carrello.svuotaCarrello();
            Carrello_listBox.Items.Clear();
            AggiornaTotale();
        }

        private void AggiornaTotale()
        {
            double totale = 0;
            foreach (Prodotto prodotto in carrello.ProdottiCarrello)
            {
                totale += prodotto.Prezzo;
            }
            costoTotale_label.Text = $"Totale: €{totale:F2}";
        }

        private void costoTotale_label_Click(object sender, EventArgs e)
        {

        }

        private void Aggiungi_btn_Click(object sender, EventArgs e)
        {

            bool prodottoAggiunto = false;

            
            int index1 = Prodotti_listBox1.SelectedIndex;
            if (index1 >= 0 && index1 < prodottiDisponibili.Count)
            {
                Prodotto prodotto = prodottiDisponibili[index1];
                carrello.aggiungiProdotto(prodotto);
                Carrello_listBox.Items.Add($"{prodotto.Marca} {prodotto.Modello} - €{prodotto.Prezzo:F2}");
                prodottoAggiunto = true;
            }

            int index2 = Prodotti_listBox3.SelectedIndex;
            List<Prodotto> prodottiAlimentari = new List<Prodotto>();
            for (int i = 0; i < prodottiDisponibili.Count; i++)
            {
                if (prodottiDisponibili[i] is ProdottoAlimentare)
                {
                    prodottiAlimentari.Add(prodottiDisponibili[i]);
                }
            }

            if (index2 >= 0 && index2 < prodottiAlimentari.Count)
            {
                Prodotto prodotto = prodottiAlimentari[index2];
                carrello.aggiungiProdotto(prodotto);
                Carrello_listBox.Items.Add($"{prodotto.Marca} {prodotto.Modello} - €{prodotto.Prezzo:F2}");
                prodottoAggiunto = true;
            }

            
            if (!prodottoAggiunto)
            {
                MessageBox.Show("Seleziona un prodotto da aggiungere al carrello.");
            }

            
            if (prodottoAggiunto)
            {
                AggiornaTotale();
            }
            Prodotti_listBox3.ClearSelected();
            Prodotti_listBox1.ClearSelected();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
