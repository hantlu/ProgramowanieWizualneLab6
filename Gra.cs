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
    public partial class Gra : Form
    {
        public int x, y, krokodyle, dydelfy, czas, szopy;
        Button[,] przyciski;
        string[,] zawartosc;
        Timer timerczas;
        int czaspozostaly;

        public Gra(int x, int y, int krokodyle, int dydelfy, int czas, int szopy)
        {
            InitializeComponent();
            this.x = x;
            this.y = y;
            this.krokodyle = krokodyle;
            this.dydelfy = dydelfy;
            this.czas = czas;
            this.szopy = szopy;

            przyciski = new Button[x, y];
            zawartosc = new string[x, y];
            Plansza();
            Losuj();

            czaspozostaly = czas;
            sekundy.Text = "Pozostalo: " + czaspozostaly + " sekundy";
            sekundy.AutoSize = true;
            sekundy.Location = new Point((panel_plansza.Width - sekundy.Width) / 2, panel_plansza.Bottom + 10);
            this.Controls.Add(sekundy);

            timerczas = new Timer();
            timerczas.Interval = 1000;
            timerczas.Tick += Timerczas_Tick;
            timerczas.Start();
        }

        private void Plansza()
        {
            panel_plansza.Controls.Clear();
            panel_plansza.Width = x * 50;
            panel_plansza.Height = y * 50;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Button przycisk = new Button();
                    przycisk.Width = 50;
                    przycisk.Height = 50;
                    przycisk.Left = i * 50;
                    przycisk.Top = j * 50;
                    przycisk.BackColor = Color.Gray;
                    przycisk.Tag = new Point(i, j);
                    przycisk.Click += przycisk_click;
                    panel_plansza.Controls.Add(przycisk);
                    przyciski[i, j] = przycisk;
                }
            }
        }

        private void Losuj()
        {
            Random random = new Random();
            List<Point> pola = new List<Point>();

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    pola.Add(new Point(i, j));

            pola.OrderBy(p => random.Next()).ToList();

            for (int i = 0; i < dydelfy; i++)
                zawartosc[pola[i].X, pola[i].Y] = "Dydelf";

            for (int i = 0; i < szopy; i++)
                zawartosc[pola[i].X, pola[i].Y] = "Szop";

            for (int i = 0; i < krokodyle; i++)
                zawartosc[pola[i].X, pola[i].Y] = "Krokodyl";

        }

        private void przycisk_click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            Point punkt = (Point)przycisk.Tag;

            if (przycisk.Enabled == false) return;

            if (zawartosc[punkt.X, punkt.Y] == null)
            {
                przycisk.BackColor = Color.White;
                przycisk.Enabled = false;
            }
            else if (zawartosc[punkt.X, punkt.Y] == "Dydelf")
            {
                MessageBox.Show("Znalazles Dydelfa!");
                przycisk.BackColor = Color.Green;
                przycisk.Text = "D";
                przycisk.Enabled = false;
            }
            else if (zawartosc[punkt.X, punkt.Y] == "Szop")
            {
                MessageBox.Show("Znalazles Szopa!");
                przycisk.BackColor = Color.Blue;
                przycisk.Text = "S";
                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, ev) =>
                {
                    timer.Stop();
                    zamknijSzopa(punkt);
                };
                timer.Start();
            }
            else if (zawartosc[punkt.X, punkt.Y] == "Krokodyl")
            {
                MessageBox.Show("Znalazles Krokodyla!");
                przycisk.BackColor = Color.Red;
                przycisk.Text = "K";
                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, ev) =>
                {
                    timer.Stop();
                    if (przycisk.Text == "K")
                    {
                        MessageBox.Show("Zginąłeś! Koniec gry!");
                        this.Close();
                    }
                };
                timer.Start();
            }
        }

        private void zamknijSzopa(Point punkt)
        {
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    int nx = punkt.X + dx;
                    int ny = punkt.Y + dy;

                    if (nx >= 0 && nx < x && ny >= 0 && ny < y)
                    {
                        Button b = przyciski[nx, ny];
                        b.BackColor = Color.Gray;
                        b.Text = "";
                        b.Enabled = true;
                    }
                }
            }
        }

        private void Timerczas_Tick(object sender, EventArgs e)
        {
            czaspozostaly--;
            sekundy.Text = "Pozostalo: " + czaspozostaly + " sekundy";
            if (czaspozostaly <= 0)
            {
                timerczas.Stop();
                MessageBox.Show("Czas minął! Koniec gry!");
                this.Close();
            }
        }
    }
}
