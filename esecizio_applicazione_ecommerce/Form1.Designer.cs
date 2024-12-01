namespace esecizio_applicazione_ecommerce
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Prodotti_listBox1 = new ListBox();
            Carrello_listBox = new ListBox();
            Aggiungi_btn = new Button();
            rimuovi_btn = new Button();
            Svuota_btn = new Button();
            costoTotale_label = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Prodotti_listBox1
            // 
            Prodotti_listBox1.FormattingEnabled = true;
            Prodotti_listBox1.ItemHeight = 25;
            Prodotti_listBox1.Location = new Point(84, 73);
            Prodotti_listBox1.Name = "Prodotti_listBox1";
            Prodotti_listBox1.Size = new Size(275, 179);
            Prodotti_listBox1.TabIndex = 0;
            Prodotti_listBox1.SelectedIndexChanged += Prodotti_listBox1_SelectedIndexChanged;
            // 
            // Carrello_listBox
            // 
            Carrello_listBox.FormattingEnabled = true;
            Carrello_listBox.ItemHeight = 25;
            Carrello_listBox.Location = new Point(444, 73);
            Carrello_listBox.Name = "Carrello_listBox";
            Carrello_listBox.Size = new Size(262, 179);
            Carrello_listBox.TabIndex = 1;
            Carrello_listBox.SelectedIndexChanged += Carrello_listBox_SelectedIndexChanged;
            // 
            // Aggiungi_btn
            // 
            Aggiungi_btn.Location = new Point(351, 289);
            Aggiungi_btn.Name = "Aggiungi_btn";
            Aggiungi_btn.Size = new Size(112, 34);
            Aggiungi_btn.TabIndex = 2;
            Aggiungi_btn.Text = "Aggiungi";
            Aggiungi_btn.UseVisualStyleBackColor = true;
            Aggiungi_btn.Click += Aggiungi_btn_Click;
            // 
            // rimuovi_btn
            // 
            rimuovi_btn.Location = new Point(351, 345);
            rimuovi_btn.Name = "rimuovi_btn";
            rimuovi_btn.Size = new Size(112, 34);
            rimuovi_btn.TabIndex = 3;
            rimuovi_btn.Text = "Rimuovi";
            rimuovi_btn.UseVisualStyleBackColor = true;
            rimuovi_btn.Click += rimuovi_btn_Click;
            // 
            // Svuota_btn
            // 
            Svuota_btn.Location = new Point(351, 398);
            Svuota_btn.Name = "Svuota_btn";
            Svuota_btn.Size = new Size(112, 34);
            Svuota_btn.TabIndex = 4;
            Svuota_btn.Text = "Svuota";
            Svuota_btn.UseMnemonic = false;
            Svuota_btn.UseVisualStyleBackColor = true;
            Svuota_btn.Click += Svuota_btn_Click;
            // 
            // costoTotale_label
            // 
            costoTotale_label.AutoSize = true;
            costoTotale_label.Location = new Point(552, 264);
            costoTotale_label.Name = "costoTotale_label";
            costoTotale_label.Size = new Size(62, 25);
            costoTotale_label.TabIndex = 5;
            costoTotale_label.Text = "Totale:";
            costoTotale_label.Click += costoTotale_label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 264);
            label2.Name = "label2";
            label2.Size = new Size(220, 25);
            label2.TabIndex = 6;
            label2.Text = "informazioniProdotti_label";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(costoTotale_label);
            Controls.Add(Svuota_btn);
            Controls.Add(rimuovi_btn);
            Controls.Add(Aggiungi_btn);
            Controls.Add(Carrello_listBox);
            Controls.Add(Prodotti_listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Prodotti_listBox1;
        private ListBox Carrello_listBox;
        private Button Aggiungi_btn;
        private Button rimuovi_btn;
        private Button Svuota_btn;
        private Label costoTotale_label;
        private Label label2;
    }
}
