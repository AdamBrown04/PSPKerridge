using System.Security.Cryptography.X509Certificates;

namespace PSPKerrdige
{
    public partial class HomeForm : Form
    {
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
            System.Windows.Forms.Application.Exit();
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
                if (items == null)
                {
                    throw new Exception("Deserialized items are null.");
                }
                else
                {
                    // Create an instance of the ItemSort class and pass the items to the constructor
                    ItemSort itemSort = new ItemSort { Items = items };

                    //default values for the lorry maximum weight and volume (in CM^3)
                    float weight = 10000f;
                    float volume = 109760000f;

                    itemSort.Sort(weight, volume);

                    ItemSwap itemSwap = new ItemSwap { Items = items, Lorries = itemSort.Lorries };
                    
                    int iterations = 500000;
                    float finalFitnessValue = itemSwap.HillClimbing(iterations);

                    btn_FileSave.Enabled = true;
                    txb_Solution.Text = itemSort.DisplayResults();
                    lbl_NumOfLorries.Text = itemSort.DisplayTotalLorries();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_FileSave_Click(object sender, EventArgs e)
        {
            //creates an instance of the FolderBrowserDialog class and sets the initial directory to C drive
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.InitialDirectory = "c:\\";
            //opens the users folder browser
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //saves the location of the folder selected by the user 
                string folderPath = folderBrowserDialog.SelectedPath;
                string fileName = "solution.txt";
                //creates an instance of the FileStream class and writes the solution to the file selected by user
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
    }
}