using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PSPKerrdige
{
    public partial class SelectLorry : Form
    {
        // List of sorted lorries
        private List<Lorry> SortedLorrys;

        public SelectLorry(List<Lorry> SortedLorrys)
        {
            InitializeComponent();
            this.SortedLorrys = SortedLorrys;
            btn_ShowLorry.Click += btn_ShowLorry_Click;
        }

        private void DisplayLorryItems()
        {
            if (int.TryParse(txt_LorryNumber.Text, out int lorryNumber))
            {
                // Check if the lorry number is within the range of the SortedLorrys list
                if (lorryNumber >= 0 && lorryNumber < SortedLorrys.Count)
                {
                    rtxt_ItemDetails.Text = string.Join(Environment.NewLine, SortedLorrys[lorryNumber].LoadedItems.Select(item => item.Count_ID.ToString()));
                }
                else
                {
                    rtxt_ItemDetails.Text = "Invalid lorry number.";
                }
            }
            else
            {
                rtxt_ItemDetails.Text = "Please enter a valid number.";
            }
        }

        private void btn_ShowLorry_Click(object sender, EventArgs e)
        {
            // Display the items in the lorry
            DisplayLorryItems();
        }
    }
}