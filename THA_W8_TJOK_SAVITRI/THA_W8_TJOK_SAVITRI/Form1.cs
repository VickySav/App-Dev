using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace THA_W8_TJOK_SAVITRI
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            instance = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.MdiParent = this;
            welcome.Dock = DockStyle.Fill;
            welcome.ControlBox = false;
            //  movie.TopLevel = false;
            welcome.Show();
        }
    }
}
