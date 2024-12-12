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
            Prodotti_listBox3 = new ListBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Prodotti_listBox1
            // 
            Prodotti_listBox1.FormattingEnabled = true;
            Prodotti_listBox1.ItemHeight = 25;
            Prodotti_listBox1.Location = new Point(58, 105);
            Prodotti_listBox1.Name = "Prodotti_listBox1";
            Prodotti_listBox1.Size = new Size(275, 254);
            Prodotti_listBox1.TabIndex = 0;
            Prodotti_listBox1.SelectedIndexChanged += Prodotti_listBox1_SelectedIndexChanged;
            // 
            // Carrello_listBox
            // 
            Carrello_listBox.FormattingEnabled = true;
            Carrello_listBox.ItemHeight = 25;
            Carrello_listBox.Location = new Point(776, 239);
            Carrello_listBox.Name = "Carrello_listBox";
            Carrello_listBox.Size = new Size(262, 254);
            Carrello_listBox.TabIndex = 1;
            Carrello_listBox.SelectedIndexChanged += Carrello_listBox_SelectedIndexChanged;
            // 
            // Aggiungi_btn
            // 
            Aggiungi_btn.Location = new Point(461, 271);
            Aggiungi_btn.Name = "Aggiungi_btn";
            Aggiungi_btn.Size = new Size(151, 67);
            Aggiungi_btn.TabIndex = 2;
            Aggiungi_btn.Text = "Aggiungi";
            Aggiungi_btn.UseVisualStyleBackColor = true;
            Aggiungi_btn.Click += Aggiungi_btn_Click;
            // 
            // rimuovi_btn
            // 
            rimuovi_btn.Location = new Point(461, 403);
            rimuovi_btn.Name = "rimuovi_btn";
            rimuovi_btn.Size = new Size(151, 67);
            rimuovi_btn.TabIndex = 3;
            rimuovi_btn.Text = "Rimuovi";
            rimuovi_btn.UseVisualStyleBackColor = true;
            rimuovi_btn.Click += rimuovi_btn_Click;
            // 
            // Svuota_btn
            // 
            Svuota_btn.Location = new Point(461, 535);
            Svuota_btn.Name = "Svuota_btn";
            Svuota_btn.Size = new Size(151, 67);
            Svuota_btn.TabIndex = 4;
            Svuota_btn.Text = "Svuota";
            Svuota_btn.UseMnemonic = false;
            Svuota_btn.UseVisualStyleBackColor = true;
            Svuota_btn.Click += Svuota_btn_Click;
            // 
            // costoTotale_label
            // 
            costoTotale_label.AutoSize = true;
            costoTotale_label.Location = new Point(884, 526);
            costoTotale_label.Name = "costoTotale_label";
            costoTotale_label.Size = new Size(62, 25);
            costoTotale_label.TabIndex = 5;
            costoTotale_label.Text = "Totale:";
            costoTotale_label.Click += costoTotale_label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(431, 149);
            label2.Name = "label2";
            label2.Size = new Size(220, 25);
            label2.TabIndex = 6;
            label2.Text = "informazioniProdotti_label";
            label2.Click += label2_Click;
            // 
            // Prodotti_listBox3
            // 
            Prodotti_listBox3.FormattingEnabled = true;
            Prodotti_listBox3.ItemHeight = 25;
            Prodotti_listBox3.Location = new Point(58, 442);
            Prodotti_listBox3.Name = "Prodotti_listBox3";
            Prodotti_listBox3.Size = new Size(275, 254);
            Prodotti_listBox3.TabIndex = 7;
            Prodotti_listBox3.SelectedIndexChanged += Prodotti_listBox3_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 61);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 8;
            label1.Text = "Prodotti elettronici ";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 403);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 9;
            label3.Text = "Prodotti alimentari";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(776, 187);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 10;
            label4.Text = "Carrello";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 740);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Prodotti_listBox3);
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
        private ListBox Prodotti_listBox3;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}
