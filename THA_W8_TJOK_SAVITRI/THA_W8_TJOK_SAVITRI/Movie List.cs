using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace THA_W8_TJOK_SAVITRI
{
    public partial class Movie_List : Form
    {
        public static Movie_List movie;
        public Movie_List()
        {
            InitializeComponent();
            movie = this;
        }
        int simpanAngka = 0;

        Button[] btnMovieTime;
        private Seat[] seatMovieTime;
        Label[] labeljudulMovie;
        PictureBox[] poster;

        string[] split;
        
        string text;
        private void Movie_List_Load(object sender, EventArgs e)
        {
            readMovie();
            this.Font = new Font("Gill Sans MT", 7);
            this.ForeColor = Color.DimGray;
            string image;

            seatMovieTime = new Seat[24];
            poster = new PictureBox[8];
            labeljudulMovie = new Label[8];
            btnMovieTime = new Button[24];

            // poster
            int x = 60; int y = 10; int angka = 8;
            for (int i=1;i<=poster.Length;i++)
            {
                poster[i - 1] = new PictureBox();
                poster[i-1].Tag = "poster" + (i - 1).ToString();
                poster[i - 1].Size = new Size(80, 100);
                poster[i - 1].Location = new Point(x, y);
                image = split[angka].Replace("\"", "");
                poster[i - 1].ImageLocation = image;
                poster[i - 1].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(poster[i - 1]);
                angka++;
                if (i%4 == 0)
                {
                    x = 60; y = 190;
                } else
                x += 130;
            }

            // judul
            x = 70; y = 120; angka = 8;
            for (int i = 1; i <= labeljudulMovie.Length; i++)
            {
                labeljudulMovie[i - 1] = new Label();
                labeljudulMovie[i - 1].Tag = "labeljudulMovie" + (i - 1).ToString();
                labeljudulMovie[i - 1].Text = split[i - 1];
                labeljudulMovie[i - 1].Size = new Size(80,15);
                labeljudulMovie[i - 1].Location = new Point(x, y);
                labeljudulMovie[i - 1].Font = new Font("Lucida Fax", 7, FontStyle.Bold);
                this.Controls.Add(labeljudulMovie[i - 1]);
                angka++;
                if (i % 4 == 0)
                {
                    x = 70; y = 300;
                } else if (i==5)
                {
                    x += 120;
                } else if (i==6)
                {
                    x += 145;
                }
                else
                    x += 130;
            }

            // button
            x = 40; y = 140; int time = 10;
            for (int i = 1; i <= 12; i++)
            {
                btnMovieTime[i-1] = new Button();
                btnMovieTime[i - 1].Tag = (i - 1).ToString();
                btnMovieTime[i - 1].Text = time.ToString() + ":00";
                btnMovieTime[i - 1].Size = new Size(40, 30);
                btnMovieTime[i - 1].Location = new Point(x, y);
                btnMovieTime[i - 1].Click += Seats;
                this.Controls.Add(btnMovieTime[i - 1]);
                time += 2;
                if (i % 3 == 0)
                {
                    time -= 4;
                    x += 50;
                }
                else 
                x += 40;
            }
            x = 40; y = 320; time = 11;
            for (int i = 13; i <= 24; i++)
            {
                btnMovieTime[i - 1] = new Button();
                btnMovieTime[i - 1].Tag = (i - 1).ToString();
                btnMovieTime[i - 1].Text = time.ToString() + ":00";
                btnMovieTime[i - 1].Size = new Size(40, 30);
                btnMovieTime[i - 1].Location = new Point(x, y);
                btnMovieTime[i - 1].Click += Seats;
                this.Controls.Add(btnMovieTime[i - 1]);
                time += 2;
                if (i % 3 == 0)
                {
                    time -= 4;
                    x += 50;
                }
                else
                    x += 40;
            }
            this.ActiveControl = poster[0]; //auto select
        }
       
        private void Seats(object sender, EventArgs e)
        {           
            int keberapa;
            Button time = (Button)sender;
            string showTime = time.Text;
            keberapa = Convert.ToInt32(time.Tag.ToString());
            
            cekJudul(keberapa);

            if (seatMovieTime[keberapa] == null)
                seatMovieTime[keberapa] = new Seat(split[simpanAngka], showTime);
            this.Hide();
            seatMovieTime[keberapa].MdiParent = Form1.instance;
            seatMovieTime[keberapa].Dock = DockStyle.Fill;
            seatMovieTime[keberapa].ControlBox = false;
            seatMovieTime[keberapa].Show();

            this.ActiveControl = poster[0]; // auto select        
        }
        void readMovie()
        {
            string textfile = "movie.txt";
            text = File.ReadAllText(textfile);
            split = text.Split(',');
        }
        void cekJudul(int keberapa)
        {
            if (keberapa < 3) // 1
            {
                simpanAngka = 0;
            }
            if (keberapa >= 3 && keberapa < 6) //2
            {
                simpanAngka = 1;
            }
            if (keberapa >= 6 && keberapa < 9) // 3
            {
                simpanAngka = 2;
            }
            if (keberapa >= 9 && keberapa < 12) // 4
            {
                simpanAngka = 3;
            }
            if (keberapa >= 12 && keberapa < 15) // 5
            {
                simpanAngka = 4;
            }
            if (keberapa >= 15 && keberapa < 18) // 6
            {
                simpanAngka = 5;
            }
            if (keberapa >= 18 && keberapa < 21) // 7
            {
                simpanAngka = 6;
            }
            if (keberapa >= 21 && keberapa < 24) // 8
            {
                simpanAngka = 7;
            }
        }
    }
}
