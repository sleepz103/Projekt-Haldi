using System.IO;
using System.Reflection;
namespace Buchungsatz_Trainer
{
    public partial class Form1 : Form
    {
        FormStatistiken dialogStatistiken = new FormStatistiken();
        FormEinstellungen dialogEinstellungen = new FormEinstellungen();

        string[] Aufgabe;
        int seitenverkehrt = 0;
        string seitenverkehrtText;



        public Form1()
        {
            InitializeComponent();
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

            comboBoxSoll.Items.Add("hello");
            comboBoxSoll.Items.Add("Suuuuuuuuuuuuuuu!!!!!!!!");

            Aufgabe = AufgabenGenerator();

            labelInhaltGeschäftsfall.Text = Aufgabe[0];
        }

        private void buttonStatistiken_Click(object sender, EventArgs e)
        {
            dialogStatistiken.Show();
        }

        private void buttonEinstellungen_Click(object sender, EventArgs e)
        {
            dialogEinstellungen.Show();
        }

        private void buttonHauptmenue_Click(object sender, EventArgs e)
        {
            labelTitel.Visible = true;
            buttonStart.Visible = true;
            buttonStatistiken.Visible = true;
            buttonEinstellungen.Visible = true;
            comboBoxSoll.Visible = false;
            comboBoxHaben.Visible = false;
            textBox1.Visible = false;
            textBetrag.Visible = false;

            buttonHauptmenue.Visible = false;
            buttonWeiter1.Visible = false;
            labelBuchungssatz.Visible = false;
            labelGeschäftsfall.Visible = false;
            labelInhaltGeschäftsfall.Visible = false;
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


            if (comboBoxSoll.Text == Aufgabe[2] && comboBoxHaben.Text == Aufgabe[1])
            {
                seitenverkehrt++;
                labelTest.Text = Convert.ToString(seitenverkehrt);
            }
            buttonWeiter1.Visible = false;
            buttonWeiter2.Visible = true;
        }

        private void buttonWeiter2_Click(object sender, EventArgs e)
        {
            buttonWeiter1.Visible = true;
            buttonWeiter2.Visible = false;

            comboBoxSoll.Text = "Soll";
            comboBoxHaben.Text = "Haben";
            textBetrag.Text = "Betrag";

            comboBoxSoll.BackColor = Color.White;
            comboBoxHaben.BackColor = Color.White;
            textBetrag.BackColor = Color.White;

            Aufgabe = AufgabenGenerator();

            labelInhaltGeschäftsfall.Text = Aufgabe[0];
        }
        static string ReaderAssemblyRessource(string fileName)
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
    }
}