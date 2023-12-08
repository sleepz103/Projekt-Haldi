namespace Buchungsatz_Trainer
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
            buttonStart = new Button();
            buttonEinstellungen = new Button();
            buttonStatistiken = new Button();
            labelTitel = new Label();
            comboBoxSoll = new ComboBox();
            comboBoxHaben = new ComboBox();
            labelBuchungssatz = new Label();
            textBox1 = new TextBox();
            textBetrag = new TextBox();
            labelInhaltGeschäftsfall = new Label();
            labelGeschäftsfall = new Label();
            labelSollFehler = new Label();
            buttonHauptmenue = new Button();
            buttonWeiter1 = new Button();
            buttonWeiter2 = new Button();
            labelHabenFehler = new Label();
            labelKomplettFehler = new Label();
            labelSeitenverkehrtFehler = new Label();
            labelSeitenverkehrtFehlerText = new Label();
            labelSollFehlerText = new Label();
            labelKomplettFehlerText = new Label();
            labelHabenFehlerText = new Label();
            labelEasterEgg = new Label();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(296, 143);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(360, 80);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonEinstellungen
            // 
            buttonEinstellungen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEinstellungen.Location = new Point(296, 433);
            buttonEinstellungen.Name = "buttonEinstellungen";
            buttonEinstellungen.Size = new Size(360, 80);
            buttonEinstellungen.TabIndex = 2;
            buttonEinstellungen.Text = "Einstellungen";
            buttonEinstellungen.UseVisualStyleBackColor = true;
            buttonEinstellungen.Click += buttonEinstellungen_Click;
            // 
            // buttonStatistiken
            // 
            buttonStatistiken.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStatistiken.Location = new Point(296, 288);
            buttonStatistiken.Name = "buttonStatistiken";
            buttonStatistiken.Size = new Size(360, 80);
            buttonStatistiken.TabIndex = 3;
            buttonStatistiken.Text = "Statitiken";
            buttonStatistiken.UseVisualStyleBackColor = true;
            buttonStatistiken.Click += buttonStatistiken_Click;
            // 
            // labelTitel
            // 
            labelTitel.AutoSize = true;
            labelTitel.Font = new Font("Calibri", 32F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitel.ForeColor = Color.Black;
            labelTitel.Location = new Point(240, 43);
            labelTitel.Name = "labelTitel";
            labelTitel.Size = new Size(485, 66);
            labelTitel.TabIndex = 4;
            labelTitel.Text = "Buchungssatztrainer";
            labelTitel.Click += labelTitel_Click;
            // 
            // comboBoxSoll
            // 
            comboBoxSoll.FormattingEnabled = true;
            comboBoxSoll.Location = new Point(95, 371);
            comboBoxSoll.Name = "comboBoxSoll";
            comboBoxSoll.Size = new Size(154, 28);
            comboBoxSoll.TabIndex = 5;
            comboBoxSoll.Text = "Soll";
            comboBoxSoll.Visible = false;
            // 
            // comboBoxHaben
            // 
            comboBoxHaben.FormattingEnabled = true;
            comboBoxHaben.Location = new Point(296, 371);
            comboBoxHaben.Name = "comboBoxHaben";
            comboBoxHaben.Size = new Size(154, 28);
            comboBoxHaben.TabIndex = 6;
            comboBoxHaben.Text = "Haben";
            comboBoxHaben.Visible = false;
            // 
            // labelBuchungssatz
            // 
            labelBuchungssatz.AutoSize = true;
            labelBuchungssatz.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelBuchungssatz.Location = new Point(86, 315);
            labelBuchungssatz.Name = "labelBuchungssatz";
            labelBuchungssatz.Size = new Size(139, 25);
            labelBuchungssatz.TabIndex = 7;
            labelBuchungssatz.Text = "Buchungssatz:";
            labelBuchungssatz.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(497, 370);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 8;
            textBox1.Text = "Text (optional)";
            textBox1.Visible = false;
            // 
            // textBetrag
            // 
            textBetrag.BackColor = SystemColors.Window;
            textBetrag.ForeColor = SystemColors.WindowText;
            textBetrag.Location = new Point(696, 371);
            textBetrag.Name = "textBetrag";
            textBetrag.Size = new Size(157, 27);
            textBetrag.TabIndex = 9;
            textBetrag.Text = "Betrag";
            textBetrag.Visible = false;
            // 
            // labelInhaltGeschäftsfall
            // 
            labelInhaltGeschäftsfall.AutoSize = true;
            labelInhaltGeschäftsfall.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelInhaltGeschäftsfall.Location = new Point(86, 147);
            labelInhaltGeschäftsfall.Name = "labelInhaltGeschäftsfall";
            labelInhaltGeschäftsfall.Size = new Size(59, 25);
            labelInhaltGeschäftsfall.TabIndex = 10;
            labelInhaltGeschäftsfall.Text = "label1";
            labelInhaltGeschäftsfall.Visible = false;
            // 
            // labelGeschäftsfall
            // 
            labelGeschäftsfall.AutoSize = true;
            labelGeschäftsfall.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelGeschäftsfall.Location = new Point(86, 112);
            labelGeschäftsfall.Name = "labelGeschäftsfall";
            labelGeschäftsfall.Size = new Size(128, 25);
            labelGeschäftsfall.TabIndex = 11;
            labelGeschäftsfall.Text = "Geschäftsfall:";
            labelGeschäftsfall.Visible = false;
            // 
            // labelSollFehler
            // 
            labelSollFehler.AutoSize = true;
            labelSollFehler.Location = new Point(355, 104);
            labelSollFehler.Name = "labelSollFehler";
            labelSollFehler.Size = new Size(145, 20);
            labelSollFehler.TabIndex = 12;
            labelSollFehler.Text = "Noch keine Eingabe!";
            labelSollFehler.Visible = false;
            // 
            // buttonHauptmenue
            // 
            buttonHauptmenue.AccessibleName = "";
            buttonHauptmenue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHauptmenue.Location = new Point(86, 482);
            buttonHauptmenue.Name = "buttonHauptmenue";
            buttonHauptmenue.Size = new Size(178, 51);
            buttonHauptmenue.TabIndex = 13;
            buttonHauptmenue.Text = "Hauptmenü";
            buttonHauptmenue.UseVisualStyleBackColor = true;
            buttonHauptmenue.Visible = false;
            buttonHauptmenue.Click += buttonHauptmenue_Click;
            // 
            // buttonWeiter1
            // 
            buttonWeiter1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonWeiter1.Location = new Point(696, 482);
            buttonWeiter1.Name = "buttonWeiter1";
            buttonWeiter1.Size = new Size(178, 51);
            buttonWeiter1.TabIndex = 14;
            buttonWeiter1.Text = "Weiter";
            buttonWeiter1.UseVisualStyleBackColor = true;
            buttonWeiter1.Visible = false;
            buttonWeiter1.Click += buttonWeiter_Click;
            // 
            // buttonWeiter2
            // 
            buttonWeiter2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonWeiter2.Location = new Point(696, 482);
            buttonWeiter2.Name = "buttonWeiter2";
            buttonWeiter2.Size = new Size(178, 51);
            buttonWeiter2.TabIndex = 15;
            buttonWeiter2.Text = "Weiter";
            buttonWeiter2.UseVisualStyleBackColor = true;
            buttonWeiter2.Visible = false;
            buttonWeiter2.Click += buttonWeiter2_Click;
            // 
            // labelHabenFehler
            // 
            labelHabenFehler.AutoSize = true;
            labelHabenFehler.Location = new Point(355, 195);
            labelHabenFehler.Name = "labelHabenFehler";
            labelHabenFehler.Size = new Size(145, 20);
            labelHabenFehler.TabIndex = 16;
            labelHabenFehler.Text = "Noch keine Eingabe!";
            labelHabenFehler.Visible = false;
            // 
            // labelKomplettFehler
            // 
            labelKomplettFehler.AutoSize = true;
            labelKomplettFehler.Location = new Point(355, 293);
            labelKomplettFehler.Name = "labelKomplettFehler";
            labelKomplettFehler.Size = new Size(145, 20);
            labelKomplettFehler.TabIndex = 17;
            labelKomplettFehler.Text = "Noch keine Eingabe!";
            labelKomplettFehler.Visible = false;
            // 
            // labelSeitenverkehrtFehler
            // 
            labelSeitenverkehrtFehler.AutoSize = true;
            labelSeitenverkehrtFehler.Location = new Point(355, 396);
            labelSeitenverkehrtFehler.Name = "labelSeitenverkehrtFehler";
            labelSeitenverkehrtFehler.Size = new Size(145, 20);
            labelSeitenverkehrtFehler.TabIndex = 18;
            labelSeitenverkehrtFehler.Text = "Noch keine Eingabe!";
            labelSeitenverkehrtFehler.Visible = false;
            // 
            // labelSeitenverkehrtFehlerText
            // 
            labelSeitenverkehrtFehlerText.AutoSize = true;
            labelSeitenverkehrtFehlerText.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelSeitenverkehrtFehlerText.Location = new Point(86, 392);
            labelSeitenverkehrtFehlerText.Name = "labelSeitenverkehrtFehlerText";
            labelSeitenverkehrtFehlerText.Size = new Size(265, 25);
            labelSeitenverkehrtFehlerText.TabIndex = 19;
            labelSeitenverkehrtFehlerText.Text = "Seitenverkehrte Buchungen:";
            labelSeitenverkehrtFehlerText.Visible = false;
            // 
            // labelSollFehlerText
            // 
            labelSollFehlerText.AutoSize = true;
            labelSollFehlerText.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelSollFehlerText.Location = new Point(86, 100);
            labelSollFehlerText.Name = "labelSollFehlerText";
            labelSollFehlerText.Size = new Size(183, 25);
            labelSollFehlerText.TabIndex = 20;
            labelSollFehlerText.Text = "Soll-Konten Fehler:";
            labelSollFehlerText.Visible = false;
            // 
            // labelKomplettFehlerText
            // 
            labelKomplettFehlerText.AutoSize = true;
            labelKomplettFehlerText.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelKomplettFehlerText.Location = new Point(86, 290);
            labelKomplettFehlerText.Name = "labelKomplettFehlerText";
            labelKomplettFehlerText.Size = new Size(263, 25);
            labelKomplettFehlerText.TabIndex = 21;
            labelKomplettFehlerText.Text = "Komplett Falsch Buchungen:";
            labelKomplettFehlerText.Visible = false;
            // 
            // labelHabenFehlerText
            // 
            labelHabenFehlerText.AutoSize = true;
            labelHabenFehlerText.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelHabenFehlerText.Location = new Point(86, 191);
            labelHabenFehlerText.Name = "labelHabenFehlerText";
            labelHabenFehlerText.Size = new Size(209, 25);
            labelHabenFehlerText.TabIndex = 22;
            labelHabenFehlerText.Text = "Haben-Konten Fehler:";
            labelHabenFehlerText.Visible = false;
            // 
            // labelEasterEgg
            // 
            labelEasterEgg.AutoSize = true;
            labelEasterEgg.Location = new Point(384, 228);
            labelEasterEgg.Name = "labelEasterEgg";
            labelEasterEgg.Size = new Size(163, 140);
            labelEasterEgg.TabIndex = 23;
            labelEasterEgg.Text = "für haldi <3\r\nversion unreleased\r\nCredits\r\nIhor: Alphatester\r\nArvin: nicht Alphatester\r\nSzymon: Programmerin\r\nRobin: Programmer";
            labelEasterEgg.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 591);
            Controls.Add(labelEasterEgg);
            Controls.Add(labelHabenFehlerText);
            Controls.Add(labelKomplettFehlerText);
            Controls.Add(labelSollFehlerText);
            Controls.Add(labelSeitenverkehrtFehlerText);
            Controls.Add(labelSeitenverkehrtFehler);
            Controls.Add(labelKomplettFehler);
            Controls.Add(labelHabenFehler);
            Controls.Add(buttonWeiter2);
            Controls.Add(buttonWeiter1);
            Controls.Add(buttonHauptmenue);
            Controls.Add(labelSollFehler);
            Controls.Add(labelGeschäftsfall);
            Controls.Add(labelInhaltGeschäftsfall);
            Controls.Add(textBetrag);
            Controls.Add(textBox1);
            Controls.Add(labelBuchungssatz);
            Controls.Add(comboBoxHaben);
            Controls.Add(comboBoxSoll);
            Controls.Add(labelTitel);
            Controls.Add(buttonStatistiken);
            Controls.Add(buttonEinstellungen);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Buchungssatztrainer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Button buttonEinstellungen;
        private Button buttonStatistiken;
        private Label labelTitel;
        private ComboBox comboBoxSoll;
        private ComboBox comboBoxHaben;
        private Label labelBuchungssatz;
        private TextBox textBox1;
        private TextBox textBetrag;
        private Label labelInhaltGeschäftsfall;
        private Label labelGeschäftsfall;
        private Label labelSollFehler;
        private Button buttonHauptmenue;
        private Button buttonWeiter1;
        private Button buttonWeiter2;
        private Label labelHabenFehler;
        private Label labelKomplettFehler;
        private Label labelSeitenverkehrtFehler;
        private Label labelSeitenverkehrtFehlerText;
        private Label labelSollFehlerText;
        private Label labelKomplettFehlerText;
        private Label labelHabenFehlerText;
        private Label labelEasterEgg;
    }
}