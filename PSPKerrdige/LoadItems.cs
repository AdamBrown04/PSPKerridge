using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PSPKerrdige
{
    public partial class LoadItems : Form
    {
        private List<Lorry> SortedLorrys;

        public LoadItems(List<Lorry> sortedLorrys)
        {
            InitializeComponent();
            this.SortedLorrys = sortedLorrys;
        }

        private string GetLorryItemsDisplay(int lorryNumber)
        {
            int index = lorryNumber - 1;
            if (index >= 0 && index < SortedLorrys.Count)
            {
                return SortedLorrys[index].DisplayResults();
            }

            return null;
        }

        private void btn_ShowLorry_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txb_LorryNumber.Text, out int lorryNumber))
            {
                string result = GetLorryItemsDisplay(lorryNumber);
                if (result != null)
                {
                    txb_ItemDetails.Text = result;
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

        private void btn_GenerateLoad_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txb_LorryNumber.Text, out int lorryNumber))
            {
                string instructions = LoadInstructions(lorryNumber);
                if (instructions != null)
                {
                    txb_ItemDetails.Text = instructions;
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

        private string LoadInstructions(int lorryNumber)
        {
            int index = lorryNumber - 1;
            if (index >= 0 && index < SortedLorrys.Count)
            {
                Lorry selectedLorry = SortedLorrys[index];
                List<Item> sortedItems = selectedLorry.LoadedItems.OrderByDescending(item => item.Weight / item.Volume)
                    .ToList();

                System.Text.StringBuilder instructions = new System.Text.StringBuilder();
                int Order = 1;
                foreach (Item item in sortedItems)
                {
                    instructions.AppendLine("Order " + Order.ToString() + " ID: " + item.Count_ID);
                    Order++;
                }

                return instructions.ToString();
            }

            return null;
        }

        private void txb_ItemDetails_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl_SaveToFile_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txb_LorryNumber.Text, out int lorryNumber))
            {
                string instructions = LoadInstructions(lorryNumber);
                if (instructions != null)
                {
                    SaveInstructionsToFile(instructions, lorryNumber);
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

        private void SaveInstructionsToFile(string instructions, int lorryNumber)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.InitialDirectory = "c:\\";
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                string fileName = "Lorry " + lorryNumber + " LoadInstructions.txt";
                FileStream outputSolution = new FileStream(Path.Combine(folderPath, fileName), FileMode.Create);
                StreamWriter writer = new StreamWriter(outputSolution);
                writer.Write(instructions);
                writer.Close();
                outputSolution.Close();
                MessageBox.Show("Instructions saved successfully.", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save instructions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}