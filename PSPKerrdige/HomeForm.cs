using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PSPKerrdige
{
    public partial class HomeForm : Form
    {
        // Class-level variable to hold the sorted lorries.
        private ItemSort currentItemSort;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void btn_FileSelect_Click(object sender, EventArgs e)
        {
            SelectFileForm selectFileForm = new SelectFileForm(this);
            selectFileForm.Show();
        }

        private void btn_ExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void getData(string filePath)
        {
            txb_FilePath.Text = filePath;
        }

        private void btn_CalculateLoads_Click(object sender, EventArgs e)
        {
            try
            {
                var items = LoadFile.LoadItemsFromJson(txb_FilePath.Text);
                int TotalItems = items.Count;
                if (items == null)
                {
                    throw new Exception("Deserialized items are null.");
                }
                else
                {
                    // Create an instance of the ItemSort class and pass the items.
                    ItemSort itemSort = new ItemSort { Items = items };

                    // Default values for the lorry maximum weight and volume (in CM³)
                    float weight = 10000f;
                    float volume = 109760000f;

                    itemSort.Sort(weight, volume);

                    ItemSwap itemSwap = new ItemSwap { Items = items, Lorries = itemSort.Lorries };
                    
                    int iterations = 500000;
                    float finalFitnessValue = itemSwap.HillClimbing(iterations);

                    // Set the currentItemSort to the sorted items.
                    currentItemSort = itemSort;
                    // Enable the Select Lorry button and the Save File button.
                    btn_SelectLorry.Enabled = true;
                    btn_FileSave.Enabled = true;
                    
                    txb_Solution.Text = itemSort.DisplayResults();
                    lbl_NumOfLorries.Text = itemSort.DisplayTotalLorries();
                    lbl_TotalItems.Text = TotalItems.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_FileSave_Click(object sender, EventArgs e)
        {
            // Create an instance of the FolderBrowserDialog class and set the initial directory to C:\
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.InitialDirectory = "c:\\";
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                string fileName = "solution.txt";
                FileStream outputSolution = new FileStream(folderPath + "\\" + fileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(outputSolution);
                writer.Write(txb_Solution.Text);
                writer.Close();
                outputSolution.Close();
                MessageBox.Show("Solution saved to solution.txt", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save solution to solution.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the "Select Lorry" button.
        private void btn_SelectLorry_Click(object sender, EventArgs e)
        {
            if (currentItemSort != null && currentItemSort.Lorries.Any())
            {
                // Create and show the SelectLorry form, passing the sorted lorries.
                SelectLorry selectLorryForm = new SelectLorry(currentItemSort.Lorries);
                selectLorryForm.Show();
            }
            else
            {
                MessageBox.Show("Please calculate loads first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

