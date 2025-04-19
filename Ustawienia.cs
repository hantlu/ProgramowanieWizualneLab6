using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramowanieWizualneLab6
{
    public partial class Ustawienia : Form
    {
        //private int x, y, dydelfy, krokodyle, czas;
        public int x { get; private set; } 
        public int y { get; private set; }
        public int dydelfy { get; private set; }
        public int krokodyle {  get; private set; }
        public int czas {  get; private set; }
        public int szopy {  get; private set; }



        public Ustawienia()
        {
            InitializeComponent();
        }

        private void czas_wpis_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (int.TryParse(czas_wpis.Text, out temp))
                czas = temp;
            else
                MessageBox.Show("Zla liczba", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);           
        }

        private void krokodyle_wpis_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (int.TryParse(krokodyle_wpis.Text, out temp))
                krokodyle = temp;
            else
                MessageBox.Show("Zla liczba", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void y_wpisywanie_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (int.TryParse(y_wpisywanie.Text, out temp))
                y = temp;
            else
                MessageBox.Show("Zla liczba", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void dydelfy_wpis_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (int.TryParse(dydelfy_wpis.Text, out temp))
                dydelfy = temp;
            else
                MessageBox.Show("Zla liczba", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void x_wpisywanie_TextChanged(object sender, EventArgs e) //wartosc x wpisywana przez uzytkownika
        {
            int temp;
            if(int.TryParse(x_wpisywanie.Text, out temp))
                x = temp;
            else
                MessageBox.Show("Zla liczba", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void szopy_wpis_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (int.TryParse(szopy_wpis.Text, out temp))
                szopy = temp;
            else
                MessageBox.Show("Zla liczba", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void zatwierdzanie_Click(object sender, EventArgs e)
        {
            if (x < 3 || x > 10)
                MessageBox.Show("X poza zakresem -> limit od 3 do 10", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (y < 3 || y > 10)
                MessageBox.Show("Y poza zakresem -> limit od 3 do 10", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (dydelfy < 1 || dydelfy > 6)
                MessageBox.Show("Dydelfy poza zakresem -> limit od 1 do 6", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (krokodyle < 0 || krokodyle > 1)
                MessageBox.Show("Krokodyle poza zakresem -> limit od 0 do 1", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (szopy < 3 || szopy > 8)
                MessageBox.Show("Szopy poza zakresem -> limit od 3 do 8", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (czas < 10 || czas > 60)
                MessageBox.Show("Czas poza zakresem -> limit od 10 do 60", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
            this.DialogResult = DialogResult.OK; //jesli wszystkie zmienne sa w dobrym zakresie to zamykamy okno
            //this.Close();
        }

        
    }
}
