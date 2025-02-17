using System.Collections.Generic;
using System.Windows.Forms;

namespace PSPKerrdige
{
    public partial class Form1 : Form
    {
        public Form1(List<Item> items)
        {
            InitializeComponent();
            PopulateListBox(items);
        }

        private void PopulateListBox(List<Item> items)
        {
            foreach (var item in items)
            {
                listBox1.Items.Add($"ID: {item.Count_ID}, Type: {item.Type}, Volume: {item.Volume}, Weight: {item.Weight}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}