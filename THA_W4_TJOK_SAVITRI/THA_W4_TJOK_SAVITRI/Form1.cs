using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THA_W4_TJOK_SAVITRI
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1 firstForm;

        public string warna;
        bool klik = false;
      
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxFavArtist.Text) || (String.IsNullOrEmpty(textBoxName.Text) && String.IsNullOrEmpty(textBoxFavArtist.Text)))
            {
                MessageBox.Show("PLEASE FILL ALL INPUT", "", MessageBoxButtons.OK);
                //  } else if (klik == false)
                //  {
                //    MessageBox.Show("PLEASE CLICK OPEN NEXT WINDOW", "", MessageBoxButtons.OK);
            } else
            Form2.instance.output.Text = "Hi, my name is " + textBoxName.Text + " and my favorite artist is " + textBoxFavArtist.Text;
        }

        private void checkBoxTheContent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTheContent.Checked && klik == true)
            {
                btnSubmit.Enabled = true;
            }
            if (!checkBoxTheContent.Checked)
                btnSubmit.Enabled = false;
        }

        private void btnOpenNextForm_Click_1(object sender, EventArgs e)
        {
            klik = true;
            Form2 form2 = new Form2();
            form2.Show();

            form2.firstForm = this;

            if (checkBoxTheContent.Checked && klik == true)
            {
                btnSubmit.Enabled = true;
            }
            if (!checkBoxTheContent.Checked)
                btnSubmit.Enabled = false;
        }
    }
}
