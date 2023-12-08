using System.IO;
using System.Reflection;
using System.Resources;

namespace Buchungsatz_Trainer
{
    public partial class Form1 : Form
    {
        string[] Aufgabe; //0=Satz, 1=Soll 2=Haben 3=Betrag

        int seitenverkehrtFehler;
        int komplettFehler;
        int sollFehler;
        int habenFehler;
        int ee = 0;
        string fehlerText;
        string[] fehlerText2;

        string seitenverkehrtText;

        public Form1()
        {
            InitializeComponent();

            string rawKonten = ReaderAssemblyRessource2("rawkonten.txt");
            string[] konten = rawKonten.Split(",");

            for (int i = 0; i < konten.Length; i++)
            {
                comboBoxSoll.Items.Add(konten[i]);
                comboBoxHaben.Items.Add(konten[i]);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelTitel.Visible = false;
            buttonStart.Visible = false;
            buttonStatistiken.Visible = false;
            buttonEinstellungen.Visible = false;
            comboBoxSoll.Visible = true;
            comboBoxHaben.Visible = true;
            textBox1.Visible = true;
            textBetrag.Visible = true;

            buttonHauptmenue.Visible = true;
            buttonWeiter1.Visible = true;
            labelBuchungssatz.Visible = true;
            labelGeschäftsfall.Visible = true;
            labelInhaltGeschäftsfall.Visible = true;

            comboBoxSoll.Text = "Soll";
            comboBoxHaben.Text = "Haben";
            textBox1.Text = "Text (optional)";
            textBetrag.Text = "Betrag";

            Aufgabe = AufgabenGenerator();

            labelInhaltGeschäftsfall.Text = Aufgabe[0];
        }

        private void buttonStatistiken_Click(object sender, EventArgs e)
        {
            labelTitel.Visible = false;
            buttonStart.Visible = false;
            buttonStatistiken.Visible = false;
            buttonEinstellungen.Visible = false;

            labelSollFehlerText.Visible = true;
            labelSollFehler.Visible = true;
            labelHabenFehlerText.Visible = true;
            labelHabenFehler.Visible = true;
            labelKomplettFehlerText.Visible = true;
            labelKomplettFehler.Visible = true;
            labelSeitenverkehrtFehlerText.Visible = true;
            labelSeitenverkehrtFehler.Visible = true;

            buttonHauptmenue.Visible = true;

            fehlerText = ReaderAssemblyRessource(GetPath());
            fehlerText2 = fehlerText.Split(",");

            sollFehler = Convert.ToInt32(fehlerText2[0]);
            habenFehler = Convert.ToInt32(fehlerText2[1]);
            komplettFehler = Convert.ToInt32(fehlerText2[2]);
            seitenverkehrtFehler = Convert.ToInt32(fehlerText2[3]);

            labelSollFehler.Text = sollFehler.ToString();
            labelHabenFehler.Text = habenFehler.ToString();
            labelKomplettFehler.Text = komplettFehler.ToString();
            labelSeitenverkehrtFehler.Text = seitenverkehrtFehler.ToString();
        }

        private void buttonEinstellungen_Click(object sender, EventArgs e)
        {

        }

        private void buttonHauptmenue_Click(object sender, EventArgs e)
        {
            labelTitel.Visible = true;
            labelEasterEgg.Visible = false;
            buttonStart.Visible = true;
            buttonStatistiken.Visible = true;
            buttonEinstellungen.Visible = true;

            comboBoxSoll.Visible = false;
            comboBoxHaben.Visible = false;
            textBox1.Visible = false;
            textBetrag.Visible = false;

            buttonHauptmenue.Visible = false;
            buttonWeiter1.Visible = false;
            buttonWeiter2.Visible = false;

            labelBuchungssatz.Visible = false;
            labelGeschäftsfall.Visible = false;
            labelInhaltGeschäftsfall.Visible = false;

            labelSollFehlerText.Visible = false;
            labelSollFehler.Visible = false;
            labelHabenFehlerText.Visible = false;
            labelHabenFehler.Visible = false;
            labelKomplettFehlerText.Visible = false;
            labelKomplettFehler.Visible = false;
            labelSeitenverkehrtFehlerText.Visible = false;
            labelSeitenverkehrtFehler.Visible = false;
            //Inhalt auf Variablen speichern
        }

        private void buttonWeiter_Click(object sender, EventArgs e)
        {
            if (comboBoxSoll.Text == Aufgabe[1])
            {
                comboBoxSoll.BackColor = Color.Lime;
            }
            else
            {
                comboBoxSoll.BackColor = Color.Red;
            }

            if (comboBoxHaben.Text == Aufgabe[2])
            {
                comboBoxHaben.BackColor = Color.Lime;
            }
            else
            {
                comboBoxHaben.BackColor = Color.Red;
            }

            if (textBetrag.Text == Aufgabe[3])
            {
                textBetrag.BackColor = Color.Lime;
            }
            else
            {
                textBetrag.BackColor = Color.Red;
            }

            //Fehler auslesen
            fehlerText = ReaderAssemblyRessource(GetPath());
            fehlerText2 = fehlerText.Split(",");

            sollFehler = Convert.ToInt32(fehlerText2[0]);
            habenFehler = Convert.ToInt32(fehlerText2[1]);
            komplettFehler = Convert.ToInt32(fehlerText2[2]);
            seitenverkehrtFehler = Convert.ToInt32(fehlerText2[3]);

            labelSollFehler.Text = sollFehler.ToString();
            labelHabenFehler.Text = habenFehler.ToString();
            labelKomplettFehler.Text = komplettFehler.ToString();
            labelSeitenverkehrtFehler.Text = seitenverkehrtFehler.ToString();

            //Fehlerarten
            if (comboBoxSoll.Text != Aufgabe[1])
            {
                sollFehler++;
                labelSollFehler.Text = sollFehler.ToString();
            }

            if (comboBoxHaben.Text != Aufgabe[2])
            {
                habenFehler++;
                labelHabenFehler.Text = habenFehler.ToString();
            }

            if (comboBoxSoll.Text != Aufgabe[1] && comboBoxHaben.Text != Aufgabe[2] && textBetrag.Text != Aufgabe[3])
            {
                komplettFehler++;
                labelKomplettFehler.Text = komplettFehler.ToString();
            }

            if (comboBoxSoll.Text == Aufgabe[2] && comboBoxHaben.Text == Aufgabe[1])
            {
                seitenverkehrtFehler++;
                labelSeitenverkehrtFehler.Text = seitenverkehrtFehler.ToString();
            }



            //Fehler speichern
            string path = GetPath();
            string fehlerString = sollFehler.ToString() + "," + habenFehler.ToString() + "," + komplettFehler.ToString() + "," + seitenverkehrtFehler.ToString();
            File.WriteAllText(path, fehlerString);




            buttonWeiter1.Visible = false;
            buttonWeiter2.Visible = true;
        }

        private void buttonWeiter2_Click(object sender, EventArgs e)
        {
            buttonWeiter1.Visible = true;
            buttonWeiter2.Visible = false;

            comboBoxSoll.Text = "Soll";
            comboBoxHaben.Text = "Haben";
            textBox1.Text = "Text (optional)";
            textBetrag.Text = "Betrag";

            comboBoxSoll.BackColor = Color.White;
            comboBoxHaben.BackColor = Color.White;
            textBetrag.BackColor = Color.White;

            Aufgabe = AufgabenGenerator();

            labelInhaltGeschäftsfall.Text = Aufgabe[0];
        }
        static string GetPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "fehler.txt");
        }
        static string ReaderAssemblyRessource(string fileName)
        {
            if (File.Exists(fileName))
            {
                return File.ReadAllText(fileName);
            }
            return "0,0,0,0";

        }
        static string ReaderAssemblyRessource2(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"Buchungsatz_Trainer.{fileName}";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        static string[] AufgabenGenerator()
        {
            Random rnd = new Random();

            string content = ReaderAssemblyRessource("content.txt");

            string[] Faellen = content.Split("\r\n");
            int num = rnd.Next(0, Faellen.Length);
            string[] AufgabeAlt = Faellen[num].Split(';');
            return AufgabeAlt;
            //string[] name = FallAuswahl()
        }

        private void labelTitel_Click(object sender, EventArgs e)
        {
            ee++;
            if (ee >= 5)
            {
                labelTitel.Visible = false;
                buttonStart.Visible = false;
                buttonStatistiken.Visible = false;
                buttonEinstellungen.Visible = false;
                buttonHauptmenue.Visible = true;
                labelEasterEgg.Visible = true;
                ee = 0;
            }
        }
    }
}