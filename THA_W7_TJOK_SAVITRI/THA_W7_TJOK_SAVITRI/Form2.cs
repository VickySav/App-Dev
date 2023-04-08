using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace THA_W7_TJOK_SAVITRI
{
    public partial class Form2 : Form
    {
        bool menang = false;
        string guess;
        string[] split;

        List<char> listHurufCek = new List<char>();
        List<char> listHurufGuess = new List<char>();
        Button[,] button;
        int size;
        int count = 0;
        List<Button> listButton = new List<Button>();
        string text;
        public Form2(int angka)
        {
            InitializeComponent();
            size = angka;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RandomWord();
            MessageBox.Show(guess); // jawaban
            foreach (char a in guess)
            {
                listHurufGuess.Add(a);
            }
            int x = 10;
            int y = 10;
            button = new Button[size, 5];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Size = new Size(50, 50);
                    button[i, j].Location = new Point(x, y);
                    button[i, j].Tag = i.ToString() + "," + j.ToString();
                    listButton.Add(button[i, j]);
                    this.Controls.Add(button[i, j]);
                    x += 50;
                }
                x = 10;
                y += 50;
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            Button huruf = (Button)sender;
            bool done = false;
            if (!menang)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (button[count, j].Text == "")
                    {
                        button[count, j].Text = huruf.Text;
                        done = true;
                    }
                    if (done == true)
                    {
                        break;
                    }
                }

            }
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            List<char> hurufKembar = new List<char>();
            List<char> hurufBenar = new List<char>();
            int angka = 0;
            string checkKata = "";
            bool error = false; bool lanjut = false; bool benar = false; bool ada = false;
            if (!menang)
            {
                for (int j = 0; j < 5; j++)
                {
                    // MessageBox.Show(count.ToString());
                    if (button[count, j].Text == "")
                    {
                        error = true;
                    }
                    if (button[count, j].Text != "")
                    {
                        checkKata += button[count, j].Text;
                        lanjut = true;
                    }
                }
                if (error == true)
                {
                    for (int a = 0; a < split.Length; a++)
                    {
                        if (split[a].Contains(checkKata.ToLower()))
                        {
                            ada = true;
                        }
                    }
                    if (ada == true)
                    {
                        count++;
                    }
                    else
                    {
                        MessageBox.Show(checkKata + " is not in the word list");
                    }

                   
                }
                else if (lanjut == true)
                {
                    for (int a = 0; a < split.Length; a++)
                    {
                        if (split[a].Contains(checkKata.ToLower()))
                        {
                            benar = true;
                        }
                    }
                    if (benar == true)
                    {
                        PecahKata(checkKata.ToLower());
                        // cara 1
                        foreach (char a in listHurufCek)
                        {
                            if (a == listHurufGuess[angka])
                            {
                                button[count, angka].BackColor = Color.LightGreen;

                            }
                            else if (listHurufGuess.Contains(a))
                            {
                                button[count, angka].BackColor = Color.Beige;
                            }
                            angka++;
                        }
                        /*foreach (char a in listHurufCek)
                        {
                            if (a == listHurufGuess[angka])
                            {
                                hurufBenar.Add(a);
                                // listHurufGuess.RemoveAt(angka);
                                button[count, angka].BackColor = Color.LightGreen;
                            }
                            else if (listHurufGuess.Contains(a))
                            {
                                if ((!hurufKembar.Contains(a) && (!hurufBenar.Contains(a))))
                                {
                                    hurufKembar.Add(a);
                                    button[count, angka].BackColor = Color.Beige;
                                }
                            }
                            angka++;
                        }*/
                        if (checkKata.ToLower() == guess)
                        {
                            MessageBox.Show("YOU WIN!");
                            menang = true;
                        }
                        if (count == size - 1 && menang == false)
                        {
                            MessageBox.Show("The word is " + guess + ". YOU LOSE!");
                        }
                        count++;
                        listHurufCek.Clear(); // hurufKembar.Clear(); hurufBenar.Clear();
                    }
                    else
                    {
                        MessageBox.Show(checkKata + " is not in the word list");
                    }
                }
            }

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int j = 4; j >= 0; j--)
            {
                if (button[count, j].Text != "")
                {
                    button[count, j].Text = "";
                    break;
                }
            }
        }
        void RandomWord()
        {
            string textfile = "Wordle Word List.txt";
            text = File.ReadAllText(textfile);
            // text = File.ReadAllText(@"C:\! UC\Tugas Apdev\WEEK 7\THA_W7_TJOK_SAVITRI\Wordle Word List.txt");
            split = text.Split(',');
            string jmlh = split.Count().ToString(); //14913 // MessageBox.Show(jmlh);
            Random rnd = new Random();
            int num = rnd.Next(1, 14913);
            guess = (split[num]);
        }
        void PecahKata(string kata)
        {
            foreach (char a in kata)
            {
                listHurufCek.Add(a);
            }
        }
    }
}
