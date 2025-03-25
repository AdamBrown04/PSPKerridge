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
                    ItemSort itemSort = new ItemSort { Items = items };

                    float weight = 10000f;
                    float volume = 109760000f;
                    itemSort.Sort(weight, volume);

                    ItemSwap itemSwap = new ItemSwap { Items = items, Lorries = itemSort.Lorries };
                    int iterations = 750000;

                    // Create a progress object to update the UI with the current progress
                    Progress<int> progress = new Progress<int>(percent =>
                    {
                        if (percent >= 99)
                        {
                            lbl_Progress.Text = "NA";
                        }
                        else
                        {
                            lbl_Progress.Text = percent.ToString() + "%";
                        }
                    });

                    // Offload the hill climbing optimization to a background thread.
                    float finalFitnessValue = await Task.Run(() => itemSwap.HillClimbing(iterations, progress));

                    // Optionally sort the loaded items in each lorry by weight.
                    foreach (var lorry in itemSwap.Lorries)
                    {
                        lorry.LoadedItems = lorry.LoadedItems.OrderByDescending(item => item.Weight / item.Volume)
                            .ToList();
                    }

                    currentItemSort = itemSort;
                    btn_SelectLorry.Enabled = true;
                    btn_FileSave.Enabled = true;
                    btn_ShowItemDetails.Enabled = true;
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

        private void lbl_Progress_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btn_ShowItemDetails_Click(object sender, EventArgs e)
        {
            if (currentItemSort != null)
            {
                ViewItemDetails viewItemDetails = new ViewItemDetails(currentItemSort.Items);
                viewItemDetails.Show();
            }
        }
    }
}