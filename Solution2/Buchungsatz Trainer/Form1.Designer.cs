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
            textBox2 = new TextBox();
            labelInhaltGeschäftsfall = new Label();
            labelGeschäftsfall = new Label();
            labelTest = new Label();
            buttonHauptmenue = new Button();
            buttonWeiter = new Button();
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
            // 
            // comboBoxSoll
            // 
            comboBoxSoll.FormattingEnabled = true;
            comboBoxSoll.Location = new Point(110, 370);
            comboBoxSoll.Name = "comboBoxSoll";
            comboBoxSoll.Size = new Size(154, 28);
            comboBoxSoll.TabIndex = 5;
            comboBoxSoll.Text = "Soll";
            comboBoxSoll.Visible = false;
            // 
            // comboBoxHaben
            // 
            comboBoxHaben.FormattingEnabled = true;
            comboBoxHaben.Location = new Point(296, 370);
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
            labelBuchungssatz.Location = new Point(101, 314);
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
            // textBox2
            // 
            textBox2.Location = new Point(696, 371);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 27);
            textBox2.TabIndex = 9;
            textBox2.Text = "Betrag";
            textBox2.Visible = false;
            // 
            // labelInhaltGeschäftsfall
            // 
            labelInhaltGeschäftsfall.AutoSize = true;
            labelInhaltGeschäftsfall.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelInhaltGeschäftsfall.Location = new Point(101, 153);
            labelInhaltGeschäftsfall.Name = "labelInhaltGeschäftsfall";
            labelInhaltGeschäftsfall.Size = new Size(117, 46);
            labelInhaltGeschäftsfall.TabIndex = 10;
            labelInhaltGeschäftsfall.Text = "label1";
            labelInhaltGeschäftsfall.Visible = false;
            // 
            // labelGeschäftsfall
            // 
            labelGeschäftsfall.AutoSize = true;
            labelGeschäftsfall.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelGeschäftsfall.Location = new Point(101, 118);
            labelGeschäftsfall.Name = "labelGeschäftsfall";
            labelGeschäftsfall.Size = new Size(128, 25);
            labelGeschäftsfall.TabIndex = 11;
            labelGeschäftsfall.Text = "Geschäftsfall:";
            labelGeschäftsfall.Visible = false;
            // 
            // labelTest
            // 
            labelTest.AutoSize = true;
            labelTest.Location = new Point(747, 152);
            labelTest.Name = "labelTest";
            labelTest.Size = new Size(50, 20);
            labelTest.TabIndex = 12;
            labelTest.Text = "label1";
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
            // buttonWeiter
            // 
            buttonWeiter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonWeiter.Location = new Point(696, 482);
            buttonWeiter.Name = "buttonWeiter";
            buttonWeiter.Size = new Size(178, 51);
            buttonWeiter.TabIndex = 14;
            buttonWeiter.Text = "Weiter";
            buttonWeiter.UseVisualStyleBackColor = true;
            buttonWeiter.Visible = false;
            buttonWeiter.Click += buttonWeiter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 591);
            Controls.Add(buttonWeiter);
            Controls.Add(buttonHauptmenue);
            Controls.Add(labelTest);
            Controls.Add(labelGeschäftsfall);
            Controls.Add(labelInhaltGeschäftsfall);
            Controls.Add(textBox2);
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
        private TextBox textBox2;
        private Label labelInhaltGeschäftsfall;
        private Label labelGeschäftsfall;
        private Label labelTest;
        private Button buttonHauptmenue;
        private Button buttonWeiter;
    }
}