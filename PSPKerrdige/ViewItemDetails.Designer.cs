
namespace PSPKerrdige
{
    partial class ViewItemDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_ViewItem = new Button();
            nud_ItemID = new NumericUpDown();
            label1 = new Label();
            txb_ItemDetails = new RichTextBox();
            btn_ReturnToMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_ItemID).BeginInit();
            SuspendLayout();
            // 
            // btn_ViewItem
            // 
            btn_ViewItem.BackColor = SystemColors.Info;
            btn_ViewItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ViewItem.Location = new Point(404, 45);
            btn_ViewItem.Name = "btn_ViewItem";
            btn_ViewItem.Size = new Size(179, 72);
            btn_ViewItem.TabIndex = 0;
            btn_ViewItem.Text = "View Item";
            btn_ViewItem.UseVisualStyleBackColor = false;
            btn_ViewItem.Click += btn_ViewItem_Click;
            // 
            // nud_ItemID
            // 
            nud_ItemID.Location = new Point(485, 12);
            nud_ItemID.Name = "nud_ItemID";
            nud_ItemID.Size = new Size(98, 27);
            nud_ItemID.TabIndex = 1;
            nud_ItemID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(404, 12);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 2;
            label1.Text = "Item ID:";
            // 
            // txb_ItemDetails
            // 
            txb_ItemDetails.Location = new Point(12, 11);
            txb_ItemDetails.Name = "txb_ItemDetails";
            txb_ItemDetails.ReadOnly = true;
            txb_ItemDetails.Size = new Size(381, 194);
            txb_ItemDetails.TabIndex = 3;
            txb_ItemDetails.Text = "";
            // 
            // btn_ReturnToMenu
            // 
            btn_ReturnToMenu.BackColor = SystemColors.Info;
            btn_ReturnToMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ReturnToMenu.Location = new Point(406, 133);
            btn_ReturnToMenu.Name = "btn_ReturnToMenu";
            btn_ReturnToMenu.Size = new Size(179, 72);
            btn_ReturnToMenu.TabIndex = 4;
            btn_ReturnToMenu.Text = "Return to Menu";
            btn_ReturnToMenu.UseVisualStyleBackColor = false;
            btn_ReturnToMenu.Click += btn_ReturnToMenu_Click;
            // 
            // ViewItemDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 219);
            Controls.Add(btn_ReturnToMenu);
            Controls.Add(txb_ItemDetails);
            Controls.Add(label1);
            Controls.Add(nud_ItemID);
            Controls.Add(btn_ViewItem);
            Name = "ViewItemDetails";
            Text = "View Item Details";
            ((System.ComponentModel.ISupportInitialize)nud_ItemID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btn_ViewItem;
        private NumericUpDown nud_ItemID;
        private Label label1;
        private RichTextBox txb_ItemDetails;
        private Button btn_ReturnToMenu;
    }
}