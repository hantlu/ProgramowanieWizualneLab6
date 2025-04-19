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
    public partial class Menu : Form
    {
        public int x, y, krokodyle, dydelfy, czas, szopy;

        private void koniec_przycisk_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        public Menu()
        {
            InitializeComponent();
        }
        private void ustawienia_przycisk_Click(object sender, EventArgs e)
        {
            Ustawienia ustawienia = new Ustawienia();
            if (ustawienia.ShowDialog() == DialogResult.OK)
            {
                this.x = ustawienia.x;
                this.y = ustawienia.y;
                this.dydelfy = ustawienia.dydelfy;
                this.krokodyle = ustawienia.krokodyle;
                this.czas = ustawienia.czas;
                this.szopy = ustawienia.szopy;
            }
        }

        private void start_przucisk_Click(object sender, EventArgs e)
        {
            if (x == 0 || y == 0 || krokodyle == 0 || dydelfy == 0 || czas == 0 || szopy == 0)
            {
                MessageBox.Show("Nie ustawiono wszystkich zmiennych", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Gra gra = new Gra(x, y, krokodyle, dydelfy, czas, szopy);
                gra.Show();
                this.Hide();
            }
        }

        
    }
}
