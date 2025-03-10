namespace AS2425._3F.INF.Prof.Stringhe
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
            label1 = new Label();
            txtNomeCognome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            groupBox1 = new GroupBox();
            btnAggiungi = new Button();
            cmbScelte = new ComboBox();
            btnVisualizza = new Button();
            lstElenco = new ListBox();
            label3 = new Label();
            txtParametro = new TextBox();
            groupBox2 = new GroupBox();
            cmbOpzioni = new ComboBox();
            chkSearchCase = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome e cognome";
            // 
            // txtNomeCognome
            // 
            txtNomeCognome.Location = new Point(172, 31);
            txtNomeCognome.Name = "txtNomeCognome";
            txtNomeCognome.Size = new Size(394, 27);
            txtNomeCognome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 80);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "EMail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(172, 82);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(394, 27);
            txtEmail.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAggiungi);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNomeCognome);
            groupBox1.Location = new Point(41, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(711, 171);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(293, 125);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(177, 29);
            btnAggiungi.TabIndex = 2;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // cmbScelte
            // 
            cmbScelte.FormattingEnabled = true;
            cmbScelte.Items.AddRange(new object[] { "Elenco contatti", "Elenco contatti contenenti il nome indicato", "Elenco contatti contenenti la email indicata" });
            cmbScelte.Location = new Point(29, 22);
            cmbScelte.Name = "cmbScelte";
            cmbScelte.Size = new Size(535, 28);
            cmbScelte.TabIndex = 3;
            // 
            // btnVisualizza
            // 
            btnVisualizza.Location = new Point(589, 19);
            btnVisualizza.Name = "btnVisualizza";
            btnVisualizza.Size = new Size(91, 34);
            btnVisualizza.TabIndex = 4;
            btnVisualizza.Text = "Visualizza";
            btnVisualizza.UseVisualStyleBackColor = true;
            btnVisualizza.Click += btnVisualizza_Click;
            // 
            // lstElenco
            // 
            lstElenco.FormattingEnabled = true;
            lstElenco.Location = new Point(30, 116);
            lstElenco.Name = "lstElenco";
            lstElenco.Size = new Size(650, 204);
            lstElenco.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 64);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 6;
            label3.Text = "Parametro di ricerca";
            // 
            // txtParametro
            // 
            txtParametro.Location = new Point(183, 65);
            txtParametro.Name = "txtParametro";
            txtParametro.Size = new Size(237, 27);
            txtParametro.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkSearchCase);
            groupBox2.Controls.Add(cmbOpzioni);
            groupBox2.Controls.Add(cmbScelte);
            groupBox2.Controls.Add(txtParametro);
            groupBox2.Controls.Add(btnVisualizza);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lstElenco);
            groupBox2.Location = new Point(41, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(711, 337);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // cmbOpzioni
            // 
            cmbOpzioni.FormattingEnabled = true;
            cmbOpzioni.Items.AddRange(new object[] { "Inizia per", "Finisce per", "Contiene" });
            cmbOpzioni.Location = new Point(426, 65);
            cmbOpzioni.Name = "cmbOpzioni";
            cmbOpzioni.Size = new Size(140, 28);
            cmbOpzioni.TabIndex = 8;
            // 
            // chkSearchCase
            // 
            chkSearchCase.AutoSize = true;
            chkSearchCase.Location = new Point(579, 69);
            chkSearchCase.Name = "chkSearchCase";
            chkSearchCase.Size = new Size(49, 24);
            chkSearchCase.TabIndex = 9;
            chkSearchCase.Text = "Aa";
            chkSearchCase.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 566);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Prof;Lab DV 2.12;10/03/25; rubrica con gestione stringhe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtNomeCognome;
        private Label label2;
        private TextBox txtEmail;
        private GroupBox groupBox1;
        private Button btnAggiungi;
        private ComboBox cmbScelte;
        private Button btnVisualizza;
        private ListBox lstElenco;
        private Label label3;
        private TextBox txtParametro;
        private GroupBox groupBox2;
        private ComboBox cmbOpzioni;
        private CheckBox chkSearchCase;
    }
}
