using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PSPKerrdige
{
    public partial class SelectLorry : Form
    {
        private List<Lorry> SortedLorrys;
        
        public SelectLorry(List<Lorry> sortedLorrys)
        {
            InitializeComponent();
            this.SortedLorrys = sortedLorrys;
            btn_ShowLorry.Click += Btn_ShowLorry_Click;
        }

        private void Btn_ShowLorry_Click(object sender, EventArgs e)
        {
            DisplayLorryItems();
        }

        private void DisplayLorryItems()
        {
            if (int.TryParse(txb_LorryNumber.Text, out int lorryNumber))
            {
                if (lorryNumber >= 0 && lorryNumber < SortedLorrys.Count)
                {
                    txb_ItemDetails.Text = string.Join(", ", SortedLorrys[lorryNumber].LoadedItems.Select(item => item.Count_ID.ToString()));
                }
                else
                {
                    txb_ItemDetails.Text = "Invalid lorry number";
                }
            }
            else
            {
                txb_ItemDetails.Text = "Please enter a valid number";
            }
        }
    }
}