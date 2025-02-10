namespace PSPKerrdige;

public partial class ViewItems : Form
{
    public ViewItems()
    {
        InitializeComponent();
    }

    private void View_SelectedIndexChanged(object sender, EventArgs e)
    {
        View.Items.Clear();
        foreach (var item in Item.Items)
        {
            View.Items.Add(item.PrintItem());
        }
    }
}