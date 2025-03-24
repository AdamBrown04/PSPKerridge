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
            Nud_lorryNumber.Maximum = sortedLorrys.Count;
        }

        private void DisplayLorryItems()
        {
            if (int.TryParse(Nud_lorryNumber.Text, out int lorryNumber))
            {
                int index = lorryNumber - 1;

                if (index >= 0)
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

        private void btn_ShowLorry_Click(object sender, EventArgs e)
        {
            DisplayLorryItems();
        }

        private void ReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}