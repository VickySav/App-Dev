using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace THA_W8_TJOK_SAVITRI
{
    public partial class Seat : Form
    {
        public static Seat instance;
        string title, showTime;
        public Seat(string judul, string jam)
        {
            instance = this;
            title = judul;
            showTime = jam;
            InitializeComponent();
        }
        List<Button> seats = new List<Button>();
        Button[] seat;

        private void Seat_Load(object sender, EventArgs e)
        {
            string alphabets = "ABCDEFGHIJ";
            int angka = 1;
            int index = 0;
            int x = 60; int y = 5;
            seat = new Button[101];

            for (int i = 1; i <= 100; i++)
            {
                seat[i] = new Button();
                seat[i].Tag = i.ToString();
                seat[i].Text = alphabets[index].ToString() + angka.ToString(); // cek
                seat[i].Size = new Size(35, 35);
                seat[i].Location = new Point(x, y);
                seat[i].BackColor = Color.White;
                seats.Add(seat[i]);

                this.Controls.Add(seat[i]);

                angka++;
                if (i % 10 == 0 && i != 0)
                {
                    index++;
                    y += 35;
                    x = 60;
                }
                if (angka == 11)
                {
                    angka = 1;
                }
                else
                    x += 35;
            }
            foreach (Button button in seats)
            {
                button.Click += seatdiClick;
            }
            RandomSeat();
            labelJudul.Text = title;
            labelJam.Text = showTime;
            this.ActiveControl = labelJam;
            this.Font = new Font("Lucida Fax", 7);
        }
        private void seatdiClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.Beige)
            {
                button.BackColor = Color.White;
            } else
              button.BackColor = Color.Beige;

        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.ActiveControl = labelJam;
            Movie_List.movie.Show();
            this.Hide();

            foreach (Button button in seats)
            {
                if (button.BackColor == Color.Beige)
                {
                    button.BackColor = Color.White;
                }
            }
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            bool ada = false;
            foreach (Button button in seats)
            {
                if (button.BackColor == Color.Beige) // yg diclick
                {
                    ada = true;
                    button.BackColor = Color.Gray;
                    button.Enabled = false;
                }
            }
            if (ada == false)
            {
                MessageBox.Show("Pilih seat terlebih dahulu", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (Button button in seats)  // RESET SMUA KURSI
            {             
              button.BackColor = Color.White;
              button.Enabled = true;
            }
        }

        void RandomSeat()
        {
            int count = 0;
            List<int> simpanAngka = new List<int>();
            Random rnd = new Random();
            int random1 = rnd.Next(1, 70); // random 1-70%
            Random randomseat = new Random();
            for (int i = 0; i < random1; i++)
            {
                int random2 = randomseat.Next(0, 100);
                if (simpanAngka.Contains(random2))
                {
                    i--;
                }
                else
                    simpanAngka.Add(random2);
            }
            foreach (Button button in seats)
            {

                if (simpanAngka.Contains(count))
                {
                    button.Enabled = false;
                    button.BackColor = Color.Gray;
                }
                else
                {
                    button.Enabled = true;
                    button.BackColor = Color.White;
                }
                count++;
            }
        }
    }
}
