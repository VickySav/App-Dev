using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W8_TJOK_SAVITRI
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1; // auto select
        }

        private void ClickMe_Click(object sender, EventArgs e)
        {
            Movie_List movie = new Movie_List();
            movie.MdiParent = Form1.instance;
            movie.Dock = DockStyle.Fill;
            movie.ControlBox = false;
            this.Hide();
            movie.Show();
        }
    }
}
