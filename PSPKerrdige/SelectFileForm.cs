using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSPKerrdige
{
    public partial class SelectFileForm : Form
    {
        public SelectFileForm()
        {
            InitializeComponent();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
