using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevOpsDemoPrj01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = (Convert.ToInt32(txtValue1.Text) + Convert.ToInt32(txtValue2.Text)).ToString();
            lblResult.ForeColor = Color.Yellow;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblResult.Text = (Convert.ToInt32(txtValue1.Text) * Convert.ToInt32(txtValue2.Text)).ToString();
            lblResult.ForeColor = Color.Green;
        }
    }
}
