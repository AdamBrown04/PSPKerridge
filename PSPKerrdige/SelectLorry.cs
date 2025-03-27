using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PSPKerrdige
{
    public partial class SelectLorry : Form
    {
        private List<Lorry> SortedLorrys;
        int index = 0;

        public SelectLorry(List<Lorry> sortedLorrys)
        {
            InitializeComponent();
            this.SortedLorrys = sortedLorrys;
            Nud_lorryNumber.Maximum = sortedLorrys.Count;
        }

        private void DisplayLorryItems()
        {
            if (int.TryParse(Nud_lorryNumber.Text, out int lorryNumber))
            {
                index = lorryNumber - 1;

                if (index >= 0)
                {
                    txb_LorryDetails.Text = SortedLorrys[index].DisplayResults(true);
                }
                else
                {
                    MessageBox.Show("Invalid lorry number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ShowLorry_Click(object sender, EventArgs e)
        {
            DisplayLorryItems();
            btn_saveLorry.Enabled = true;
        }

        private void ReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_saveLorry_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.InitialDirectory = "c:\\";
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            string fileName = $"Lorry{index+1}.txt";
            if (result == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;                
                FileStream outputSolution = new FileStream(folderPath + "\\" + fileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(outputSolution);
                writer.Write(txb_LorryDetails.Text);
                writer.Close();
                outputSolution.Close();
                MessageBox.Show($"Solution saved to {fileName}", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Failed to save solution to {fileName}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}