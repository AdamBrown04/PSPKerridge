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
            //update text box to show the file path 
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
                    
                    ItemSort itemSort = new ItemSort {Items = items };

                    float weight = 10000f;
                    float volume = 109760000f;

                    itemSort.FirstFitDecreasing(weight, volume);
                    
                    ItemSwap itemSwap = new ItemSwap {Items = items, Lorries = itemSort.Lorries};
                    
                    int iterations = 500000;
                   float finalFitnessValue = itemSwap.HillClimbing(iterations);

                    
                    txb_Solution.Text = itemSort.DisplayResults();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
