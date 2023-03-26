using System;
using System.Drawing;
using System.Windows.Forms;

namespace THA_W4_TJOK_SAVITRI
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form1 firstForm;
        public Label output;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            output = labelOutput;
        }
        private void magicChecks(object sender, EventArgs e)
        {
            if (checkBoxAgreeTerms.Checked == true && checkBoxTheChoice.Checked == true)
            {
                btnMagic.Enabled = true;
            }
            else
            {
                btnMagic.Enabled = false;
            }
        }
        private void btnMagic_Click(object sender, EventArgs e)
        {
            if ((!radioButtonBgPink.Checked && !radioButtonBgBeige.Checked && !radioButtonBgHoney.Checked && !radioButtonBgRose.Checked && !radioButtonBgPeach.Checked) && (!radioButtonTextBrown.Checked && !radioButtonTextGray.Checked && !radioButtonTextRed.Checked))
                MessageBox.Show("PLEASE CHOOSE BACKGROUND COLOR & TEXT COLOR");

            else if (!radioButtonTextBrown.Checked && !radioButtonTextGray.Checked && !radioButtonTextRed.Checked)
                MessageBox.Show("PLEASE CHOOSE TEXT COLOR");

            else if (!radioButtonBgPink.Checked && !radioButtonBgBeige.Checked && !radioButtonBgHoney.Checked && !radioButtonBgRose.Checked && !radioButtonBgPeach.Checked)
                MessageBox.Show("PLEASE CHOOSE BACKGROUND COLOR");
            else
            {
                if (radioButtonBgPink.Checked)
                    firstForm.BackColor = Color.Pink;
                if (radioButtonBgBeige.Checked)
                    firstForm.BackColor = Color.Beige;
                if (radioButtonBgHoney.Checked)
                    firstForm.BackColor = Color.Honeydew;
                if (radioButtonBgRose.Checked)
                    firstForm.BackColor = Color.MistyRose;
                if (radioButtonBgPeach.Checked)
                    firstForm.BackColor = Color.PeachPuff;
                
                if (radioButtonTextBrown.Checked)
                    firstForm.ForeColor = Color.Brown;
                if (radioButtonTextGray.Checked)
                    firstForm.ForeColor = Color.Gray;
                if (radioButtonTextRed.Checked)
                    firstForm.ForeColor = Color.Red;
            }
        }
    }
}
