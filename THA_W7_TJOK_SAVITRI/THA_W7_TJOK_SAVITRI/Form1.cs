using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_TJOK_SAVITRI
{
    public partial class Form1 : Form
    {
        string alph = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";       
            
        int angka = 0;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            bool ERROR = false;
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("INPUT KOSONG");
            }
            if (textBoxInput.Text != "")
            {
                foreach (char a in textBoxInput.Text)
                {            
                    if (alph.Contains(a))
                    {
                        ERROR = true;
                    }
                    if (ERROR == true)
                    {
                        MessageBox.Show("INPUT ANGKA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        angka = Convert.ToInt32(textBoxInput.Text);
                        if (angka >= 0)
                        {
                            Form2 form2 = new Form2(angka);
                            form2.Show();
                        }
                        else
                            MessageBox.Show("INPUT HARUS LEBIH BESAR DARI 0");
                    }
                }
            }
             
        }
    }
}
