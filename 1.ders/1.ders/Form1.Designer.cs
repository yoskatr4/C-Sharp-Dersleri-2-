namespace _1.ders
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
            buttonMesajGörüntüle = new Button();
            textBoxMesaj = new TextBox();
            Sil = new Button();
            comboBoxIsimler = new ComboBox();
            ekleIIsim = new Button();
            labelYazılanİsim = new Label();
            buttonLabelDeğiştir = new Button();
            listBoxDersler = new ListBox();
            SuspendLayout();
            // 
            // buttonMesajGörüntüle
            // 
            buttonMesajGörüntüle.Location = new Point(60, 26);
            buttonMesajGörüntüle.Name = "buttonMesajGörüntüle";
            buttonMesajGörüntüle.Size = new Size(94, 29);
            buttonMesajGörüntüle.TabIndex = 0;
            buttonMesajGörüntüle.Text = "Mesaj Yaz";
            buttonMesajGörüntüle.UseVisualStyleBackColor = true;
            buttonMesajGörüntüle.Click += buttonMesajGörüntüle_Click;
            // 
            // textBoxMesaj
            // 
            textBoxMesaj.BackColor = Color.FromArgb(0, 0, 192);
            textBoxMesaj.ForeColor = Color.White;
            textBoxMesaj.Location = new Point(181, 26);
            textBoxMesaj.Name = "textBoxMesaj";
            textBoxMesaj.Size = new Size(348, 27);
            textBoxMesaj.TabIndex = 1;
            // 
            // Sil
            // 
            Sil.Location = new Point(60, 75);
            Sil.Name = "Sil";
            Sil.Size = new Size(94, 29);
            Sil.TabIndex = 2;
            Sil.Text = "Sil";
            Sil.UseVisualStyleBackColor = true;
            Sil.Click += Sil_Click;
            // 
            // comboBoxIsimler
            // 
            comboBoxIsimler.FormattingEnabled = true;
            comboBoxIsimler.Items.AddRange(new object[] { "Alı", "Veli", "Ozan" });
            comboBoxIsimler.Location = new Point(168, 119);
            comboBoxIsimler.Name = "comboBoxIsimler";
            comboBoxIsimler.Size = new Size(190, 28);
            comboBoxIsimler.TabIndex = 3;
            comboBoxIsimler.SelectedIndexChanged += comboBoxIsimler_SelectedIndexChanged;
            // 
            // ekleIIsim
            // 
            ekleIIsim.Location = new Point(194, 75);
            ekleIIsim.Name = "ekleIIsim";
            ekleIIsim.Size = new Size(94, 29);
            ekleIIsim.TabIndex = 4;
            ekleIIsim.Text = "Ekle";
            ekleIIsim.UseVisualStyleBackColor = true;
            ekleIIsim.Click += ekleIIsim_Click;
            // 
            // labelYazılanİsim
            // 
            labelYazılanİsim.AutoSize = true;
            labelYazılanİsim.BackColor = Color.Red;
            labelYazılanİsim.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelYazılanİsim.ForeColor = Color.White;
            labelYazılanİsim.Location = new Point(516, 86);
            labelYazılanİsim.Name = "labelYazılanİsim";
            labelYazılanİsim.Size = new Size(58, 18);
            labelYazılanİsim.TabIndex = 5;
            labelYazılanİsim.Text = "label1";
            // 
            // buttonLabelDeğiştir
            // 
            buttonLabelDeğiştir.Location = new Point(478, 119);
            buttonLabelDeğiştir.Name = "buttonLabelDeğiştir";
            buttonLabelDeğiştir.Size = new Size(141, 29);
            buttonLabelDeğiştir.TabIndex = 6;
            buttonLabelDeğiştir.Text = "Label Değiştir";
            buttonLabelDeğiştir.UseVisualStyleBackColor = true;
            buttonLabelDeğiştir.Click += buttonLabelDeğiştir_Click;
            // 
            // listBoxDersler
            // 
            listBoxDersler.FormattingEnabled = true;
            listBoxDersler.ItemHeight = 20;
            listBoxDersler.Items.AddRange(new object[] { "Matematik", "Fizik", "Kmya", "Biyoloji" });
            listBoxDersler.Location = new Point(350, 165);
            listBoxDersler.Name = "listBoxDersler";
            listBoxDersler.Size = new Size(150, 104);
            listBoxDersler.TabIndex = 8;
            listBoxDersler.SelectedIndexChanged += listBoxDersler_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(799, 450);
            Controls.Add(listBoxDersler);
            Controls.Add(buttonLabelDeğiştir);
            Controls.Add(labelYazılanİsim);
            Controls.Add(ekleIIsim);
            Controls.Add(comboBoxIsimler);
            Controls.Add(Sil);
            Controls.Add(textBoxMesaj);
            Controls.Add(buttonMesajGörüntüle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMesajGörüntüle;
        private TextBox textBoxMesaj;
        private Button Sil;
        private ComboBox comboBoxIsimler;
        private Button ekleIIsim;
        private Label labelYazılanİsim;
        private Button buttonLabelDeğiştir;
        private ListBox listBoxDersler;
    }
}