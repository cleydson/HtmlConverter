using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;

namespace HtmlConverter
{
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            txtTo.Text = HttpUtility.HtmlEncode(txtFrom.Text);
        }

      
    }
}
