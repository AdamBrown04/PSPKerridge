using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSPKerrdige
{
    public partial class ViewItemDetails : Form
    {
        private List<Item> items;
        public ViewItemDetails(List<Item> items)
        {
            InitializeComponent();
            this.items = items;
            nud_ItemID.Maximum = items.Count;
        }

        private void btn_ViewItem_Click(object sender, EventArgs e)
        {
            txb_ItemDetails.Text = items[(int)nud_ItemID.Value - 1].DisplayItemDetails();
        }

        private void btn_ReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
