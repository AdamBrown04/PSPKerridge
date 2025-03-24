namespace PSPKerrdige
{
    partial class LoadItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Control declarations
        private System.Windows.Forms.TextBox txb_LorryNumber;
        private System.Windows.Forms.Button btn_ShowLorry;
        private System.Windows.Forms.Button btn_GenerateLoad;
        private System.Windows.Forms.RichTextBox txb_ItemDetails;
        private System.Windows.Forms.Label lbl_LorryNumber;

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
            btn_GenerateLoad = new System.Windows.Forms.Button();
            txb_ItemDetails = new System.Windows.Forms.RichTextBox();
            lbl_LorryNumber = new System.Windows.Forms.Label();
            lbl_SaveToFile = new System.Windows.Forms.Button();
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
            btn_ShowLorry.Location = new System.Drawing.Point(263, 84);
            btn_ShowLorry.Name = "btn_ShowLorry";
            btn_ShowLorry.Size = new System.Drawing.Size(232, 35);
            btn_ShowLorry.TabIndex = 1;
            btn_ShowLorry.Text = "Show Lorry";
            btn_ShowLorry.UseVisualStyleBackColor = false;
            btn_ShowLorry.Click += btn_ShowLorry_Click;
            // 
            // btn_GenerateLoad
            // 
            btn_GenerateLoad.BackColor = System.Drawing.SystemColors.Info;
            btn_GenerateLoad.Location = new System.Drawing.Point(25, 84);
            btn_GenerateLoad.Name = "btn_GenerateLoad";
            btn_GenerateLoad.Size = new System.Drawing.Size(229, 35);
            btn_GenerateLoad.TabIndex = 2;
            btn_GenerateLoad.Text = "Generate Load";
            btn_GenerateLoad.UseVisualStyleBackColor = false;
            btn_GenerateLoad.Click += btn_GenerateLoad_Click;
            // 
            // txb_ItemDetails
            // 
            txb_ItemDetails.Location = new System.Drawing.Point(25, 140);
            txb_ItemDetails.Name = "txb_ItemDetails";
            txb_ItemDetails.ReadOnly = true;
            txb_ItemDetails.Size = new System.Drawing.Size(470, 258);
            txb_ItemDetails.TabIndex = 3;
            txb_ItemDetails.Text = "";
            txb_ItemDetails.TextChanged += txb_ItemDetails_TextChanged;
            // 
            // lbl_LorryNumber
            // 
            lbl_LorryNumber.AutoSize = true;
            lbl_LorryNumber.Location = new System.Drawing.Point(25, 43);
            lbl_LorryNumber.Name = "lbl_LorryNumber";
            lbl_LorryNumber.Size = new System.Drawing.Size(103, 20);
            lbl_LorryNumber.TabIndex = 4;
            lbl_LorryNumber.Text = "Lorry Number:";
            // 
            // lbl_SaveToFile
            // 
            lbl_SaveToFile.BackColor = System.Drawing.SystemColors.Info;
            lbl_SaveToFile.Location = new System.Drawing.Point(143, 416);
            lbl_SaveToFile.Name = "lbl_SaveToFile";
            lbl_SaveToFile.Size = new System.Drawing.Size(229, 35);
            lbl_SaveToFile.TabIndex = 5;
            lbl_SaveToFile.Text = "Save To File";
            lbl_SaveToFile.UseVisualStyleBackColor = false;
            lbl_SaveToFile.Click += lbl_SaveToFile_Click;
            // 
            // LoadItems
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(520, 483);
            Controls.Add(lbl_SaveToFile);
            Controls.Add(lbl_LorryNumber);
            Controls.Add(txb_ItemDetails);
            Controls.Add(btn_GenerateLoad);
            Controls.Add(btn_ShowLorry);
            Controls.Add(txb_LorryNumber);
            Text = "Load Items";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button lbl_SaveToFile;

        #endregion
    }
}