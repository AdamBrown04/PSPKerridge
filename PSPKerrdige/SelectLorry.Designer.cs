namespace PSPKerrdige
{
    partial class SelectLorry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Control declarations using consistent naming.
        private System.Windows.Forms.TextBox txb_LorryNumber;
        private System.Windows.Forms.Button btn_ShowLorry;
        private System.Windows.Forms.RichTextBox txb_ItemDetails;

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

        private void InitializeComponent()
        {
            this.txb_LorryNumber = new System.Windows.Forms.TextBox();
            this.btn_ShowLorry = new System.Windows.Forms.Button();
            this.txb_ItemDetails = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txb_LorryNumber
            // 
            this.txb_LorryNumber.Location = new System.Drawing.Point(143, 40);
            this.txb_LorryNumber.Name = "txb_LorryNumber";
            this.txb_LorryNumber.Size = new System.Drawing.Size(229, 27);
            this.txb_LorryNumber.TabIndex = 0;
            // 
            // btn_ShowLorry
            // 
            this.btn_ShowLorry.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ShowLorry.Location = new System.Drawing.Point(158, 73);
            this.btn_ShowLorry.Name = "btn_ShowLorry";
            this.btn_ShowLorry.Size = new System.Drawing.Size(199, 73);
            this.btn_ShowLorry.TabIndex = 1;
            this.btn_ShowLorry.Text = "Display Items";
            this.btn_ShowLorry.UseVisualStyleBackColor = false;
            // 
            // txb_ItemDetails
            // 
            this.txb_ItemDetails.Location = new System.Drawing.Point(91, 168);
            this.txb_ItemDetails.Name = "txb_ItemDetails";
            this.txb_ItemDetails.ReadOnly = true;
            this.txb_ItemDetails.Size = new System.Drawing.Size(355, 209);
            this.txb_ItemDetails.TabIndex = 2;
            this.txb_ItemDetails.Text = "";
            // 
            // SelectLorry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 448);
            this.Controls.Add(this.txb_ItemDetails);
            this.Controls.Add(this.btn_ShowLorry);
            this.Controls.Add(this.txb_LorryNumber);
            this.Name = "SelectLorry";
            this.Text = "Select Lorry";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
