using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB02
{
    public partial class SearchScreen : Form
    {
        public SearchScreen()
        {
            InitializeComponent();
        }

        private void BtnStartA3_Click(object sender, EventArgs e)
        {
            var a = new ArraySearchUI(1000000, 54);
        }

        private void BtnStartA4_Click(object sender, EventArgs e)
        {

        }

        private void BtnStartA5_Click(object sender, EventArgs e)
        {

        }
    }
}
