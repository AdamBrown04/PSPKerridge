using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PSPKerrdige
{
    public partial class SelectLorryAndItem : Form
    {
        private List<Lorry> SortedLorrys;

        public SelectLorryAndItem(List<Lorry> sortedLorrys)
        {
            InitializeComponent();
            this.SortedLorrys = sortedLorrys;
        }

        private void DisplayLorryItems()
        {
            if (int.TryParse(txb_LorryNumber.Text, out int lorryNumber))
            {
                int index = lorryNumber - 1;

                if (index >= 0 && index < SortedLorrys.Count)
                {
                    txb_ItemDetails.Text = SortedLorrys[index].DisplayResults();
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

        private void DisplayItem()
        {
            if (int.TryParse(txb_ItemID.Text, out int itemId))
            {
                foreach (Lorry lorry in SortedLorrys)
                {
                    Item item = lorry.LoadedItems.FirstOrDefault(it => it.Count_ID == itemId);
                    if (item != null)
                    {
                        txb_ItemDetails.Text = item.DisplayItemDetails();
                        return;
                    }
                }

                MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please enter a valid item id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ShowLorry_Click(object sender, EventArgs e)
        {
            DisplayLorryItems();
        }

        private void btn_ShowItem_Click(object sender, EventArgs e)
        {
            DisplayItem();
        }
    }
}