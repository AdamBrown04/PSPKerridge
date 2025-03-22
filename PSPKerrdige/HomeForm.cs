using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

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

        private async void btn_CalculateLoads_Click(object sender, EventArgs e)
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

                    // Default values for lorry maximum weight and volume (in CM³)
                    float weight = 10000f;
                    float volume = 109760000f;

                    itemSort.Sort(weight, volume);

                    // Create the ItemSwap instance
                    ItemSwap itemSwap = new ItemSwap { Items = items, Lorries = itemSort.Lorries };
                    int iterations = 500000;

                    // Offload the hill climbing optimization to a background thread
                    float finalFitnessValue = await Task.Run(() => itemSwap.HillClimbing(iterations));

                    // Optionally sort the loaded items in each lorry by weight
                    foreach (var lorry in itemSwap.Lorries)
                    {
                        lorry.LoadedItems = lorry.LoadedItems.OrderByDescending(item => item.Weight).ToList();
                    }

                    // Store the sorted lorries for later use.
                    currentItemSort = itemSort;

                    // Enable the "Select Lorry" and "Save" buttons once optimization is done.
                    btn_SelectLorry.Enabled = true;
                    btn_FileSave.Enabled = true;

                    // Update the UI with the results (ensure this runs on the UI thread)
                    txb_Solution.Text = itemSort.DisplayResults();
                    lbl_NumOfLorries.Text = itemSort.DisplayTotalLorries();
                    lbl_TotalItems.Text = TotalItems.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load JSON file: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_FileSave_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Solution saved to solution.txt", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save solution to solution.txt", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_SelectLorry_Click(object sender, EventArgs e)
        {
            if (currentItemSort != null && currentItemSort.Lorries.Any())
            {
                SelectLorry selectLorryForm = new SelectLorry(currentItemSort.Lorries);
                selectLorryForm.Show();
            }
            else
            {
                MessageBox.Show("Please calculate loads first.", "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}