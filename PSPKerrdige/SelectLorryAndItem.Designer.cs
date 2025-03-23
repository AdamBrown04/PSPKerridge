namespace PSPKerrdige
{
    partial class SelectLorryAndItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Control declarations
        private System.Windows.Forms.TextBox txb_LorryNumber;
        private System.Windows.Forms.Button btn_ShowLorry;
        private System.Windows.Forms.RichTextBox txb_ItemDetails;
        private System.Windows.Forms.Label lbl_LorryNumber;
        private System.Windows.Forms.Label lbl_ItemID;
        private System.Windows.Forms.TextBox txb_ItemID;
        private System.Windows.Forms.Button btn_ShowItem;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
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
            txb_LorryNumber = new System.Windows.Forms.TextBox();
            btn_ShowLorry = new System.Windows.Forms.Button();
            txb_ItemDetails = new System.Windows.Forms.RichTextBox();
            lbl_LorryNumber = new System.Windows.Forms.Label();
            lbl_ItemID = new System.Windows.Forms.Label();
            txb_ItemID = new System.Windows.Forms.TextBox();
            btn_ShowItem = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txb_LorryNumber
            // 
            txb_LorryNumber.Location = new System.Drawing.Point(143, 40);
            txb_LorryNumber.Name = "txb_LorryNumber";
            txb_LorryNumber.Size = new System.Drawing.Size(229, 27);
            txb_LorryNumber.TabIndex = 0;
            // 
            // btn_ShowLorry
            // 
            btn_ShowLorry.BackColor = System.Drawing.SystemColors.Info;
            btn_ShowLorry.Location = new System.Drawing.Point(378, 40);
            btn_ShowLorry.Name = "btn_ShowLorry";
            btn_ShowLorry.Size = new System.Drawing.Size(110, 27);
            btn_ShowLorry.TabIndex = 1;
            btn_ShowLorry.Text = "Show Lorry";
            btn_ShowLorry.UseVisualStyleBackColor = false;
            btn_ShowLorry.Click += btn_ShowLorry_Click;
            // 
            // txb_ItemDetails
            // 
            txb_ItemDetails.Location = new System.Drawing.Point(25, 168);
            txb_ItemDetails.Name = "txb_ItemDetails";
            txb_ItemDetails.ReadOnly = true;
            txb_ItemDetails.Size = new System.Drawing.Size(470, 230);
            txb_ItemDetails.TabIndex = 2;
            txb_ItemDetails.Text = "";
            // 
            // lbl_LorryNumber
            // 
            lbl_LorryNumber.AutoSize = true;
            lbl_LorryNumber.Location = new System.Drawing.Point(25, 43);
            lbl_LorryNumber.Name = "lbl_LorryNumber";
            lbl_LorryNumber.Size = new System.Drawing.Size(103, 20);
            lbl_LorryNumber.TabIndex = 3;
            lbl_LorryNumber.Text = "Lorry Number:";
            // 
            // lbl_ItemID
            // 
            lbl_ItemID.AutoSize = true;
            lbl_ItemID.Location = new System.Drawing.Point(67, 87);
            lbl_ItemID.Name = "lbl_ItemID";
            lbl_ItemID.Size = new System.Drawing.Size(61, 20);
            lbl_ItemID.TabIndex = 4;
            lbl_ItemID.Text = "Item ID:";
            // 
            // txb_ItemID
            // 
            txb_ItemID.Location = new System.Drawing.Point(143, 87);
            txb_ItemID.Name = "txb_ItemID";
            txb_ItemID.Size = new System.Drawing.Size(229, 27);
            txb_ItemID.TabIndex = 5;
            // 
            // btn_ShowItem
            // 
            btn_ShowItem.BackColor = System.Drawing.SystemColors.Info;
            btn_ShowItem.Location = new System.Drawing.Point(378, 87);
            btn_ShowItem.Name = "btn_ShowItem";
            btn_ShowItem.Size = new System.Drawing.Size(110, 27);
            btn_ShowItem.TabIndex = 6;
            btn_ShowItem.Text = "Show Item";
            btn_ShowItem.UseVisualStyleBackColor = false;
            btn_ShowItem.Click += btn_ShowItem_Click;
            // 
            // SelectLorryAndItem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(520, 420);
            Controls.Add(btn_ShowItem);
            Controls.Add(txb_ItemID);
            Controls.Add(lbl_ItemID);
            Controls.Add(lbl_LorryNumber);
            Controls.Add(txb_ItemDetails);
            Controls.Add(btn_ShowLorry);
            Controls.Add(txb_LorryNumber);
            Text = "Select Lorry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
