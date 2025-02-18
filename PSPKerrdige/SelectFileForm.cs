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

        //create an instantce of the HomeForm class to be able to move data between forms
        private HomeForm homeForm;
        public SelectFileForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;

        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_FileFind_Click(object sender, EventArgs e)
        {
            //Open file dialog and settings
            //code source: https://www.csharp.com/UploadFile/mahesh/openfiledialog-in-C-Sharp/

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

            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {
                txb_FileSelected.Text = openFileDialog.FileName;
            }
        }


        private void btn_FileConfirm_Click(object sender, EventArgs e)
        {
            //validation to ensure that the user has selected a file
            if(txb_FileSelected.Text == "")
            {
                //throws an error and informs the user to select a file
                MessageBox.Show("Please select a file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //calls the getData method from the HomeForm class and passes the file path
                homeForm.getData(txb_FileSelected.Text);
                this.Close();
            }
            
        }

    }
}
