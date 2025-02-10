namespace PSPKerrdige
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ViewItems_Click(object sender, EventArgs e)
        {
            ViewItems viewItems = new ViewItems();
            viewItems.Show();
        }
    }
}
