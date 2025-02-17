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

        public void getData(string passThrough)
        {
            txb_FilePath.Text = passThrough;
        }
    }
}
