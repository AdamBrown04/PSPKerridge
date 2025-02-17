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

        private void btn_FileFind_Click(object sender, EventArgs e)
        {
            //Open file dialog and settings
            //source: https://www.csharp.com/UploadFile/mahesh/openfiledialog-in-C-Sharp/
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.RestoreDirectory = true;

            //Default file extension
            openFileDialog.DefaultExt = "JSON";
            //Filter files
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;

            //check file and path exists
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txb_FileSelected.Text = openFileDialog.FileName;
            }
        }
    }
}
