using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Demon
{
    public partial class Welcome_Form : Form
    {
        public Welcome_Form()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cptbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            Game_Form gf = new Game_Form();
            gf.Show();
        }

        private void cptbBird_Click(object sender, EventArgs e)
        {
            Game_Form gf = new Game_Form();
            gf.Show();
        }
    }
}
