namespace PSPKerrdige
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Control declarations:
        private System.Windows.Forms.Button btn_FileSelect;
        private System.Windows.Forms.Button btn_FileSave;
        private System.Windows.Forms.Button btn_ExitProgram;
        private System.Windows.Forms.Button btn_CalculateLoads;
        private System.Windows.Forms.Button btn_SelectLorry;
        private System.Windows.Forms.Label lbl_FileSelected;
        private System.Windows.Forms.TextBox txb_FilePath;
        private System.Windows.Forms.RichTextBox txb_Solution;
        private System.Windows.Forms.Label lbl_Solution;
        private System.Windows.Forms.Label lbl_NumOfLorries;
        private System.Windows.Forms.Label lbl_TotalItems;
        private System.Windows.Forms.Label label1;

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

        private void InitializeComponent()
        {
            this.btn_FileSelect = new System.Windows.Forms.Button();
            this.btn_FileSave = new System.Windows.Forms.Button();
            this.btn_ExitProgram = new System.Windows.Forms.Button();
            this.btn_CalculateLoads = new System.Windows.Forms.Button();
            this.btn_SelectLorry = new System.Windows.Forms.Button();
            this.lbl_FileSelected = new System.Windows.Forms.Label();
            this.txb_FilePath = new System.Windows.Forms.TextBox();
            this.txb_Solution = new System.Windows.Forms.RichTextBox();
            this.lbl_Solution = new System.Windows.Forms.Label();
            this.lbl_NumOfLorries = new System.Windows.Forms.Label();
            this.lbl_TotalItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_FileSelect
            // 
            this.btn_FileSelect.BackColor = System.Drawing.SystemColors.Info;
            this.btn_FileSelect.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_FileSelect.Location = new System.Drawing.Point(632, 45);
            this.btn_FileSelect.Name = "btn_FileSelect";
            this.btn_FileSelect.Size = new System.Drawing.Size(353, 70);
            this.btn_FileSelect.TabIndex = 0;
            this.btn_FileSelect.Text = "Select File";
            this.btn_FileSelect.UseVisualStyleBackColor = false;
            this.btn_FileSelect.Click += new System.EventHandler(this.btn_FileSelect_Click);
            // 
            // btn_FileSave
            // 
            this.btn_FileSave.BackColor = System.Drawing.SystemColors.Info;
            this.btn_FileSave.Enabled = false;
            this.btn_FileSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_FileSave.Location = new System.Drawing.Point(632, 121);
            this.btn_FileSave.Name = "btn_FileSave";
            this.btn_FileSave.Size = new System.Drawing.Size(353, 70);
            this.btn_FileSave.TabIndex = 1;
            this.btn_FileSave.Text = "Save Output to File";
            this.btn_FileSave.UseVisualStyleBackColor = false;
            this.btn_FileSave.Click += new System.EventHandler(this.btn_FileSave_Click);
            // 
            // btn_SelectLorry
            // 
            this.btn_SelectLorry.BackColor = System.Drawing.SystemColors.Info;
            this.btn_SelectLorry.Enabled = false;
            this.btn_SelectLorry.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SelectLorry.Location = new System.Drawing.Point(632, 197);
            this.btn_SelectLorry.Name = "btn_SelectLorry";
            this.btn_SelectLorry.Size = new System.Drawing.Size(353, 70);
            this.btn_SelectLorry.TabIndex = 2;
            this.btn_SelectLorry.Text = "Select Lorry";
            this.btn_SelectLorry.UseVisualStyleBackColor = false;
            this.btn_SelectLorry.Click += new System.EventHandler(this.btn_SelectLorry_Click);
            // 
            // btn_CalculateLoads
            // 
            this.btn_CalculateLoads.BackColor = System.Drawing.SystemColors.Info;
            this.btn_CalculateLoads.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CalculateLoads.Location = new System.Drawing.Point(632, 430);
            this.btn_CalculateLoads.Name = "btn_CalculateLoads";
            this.btn_CalculateLoads.Size = new System.Drawing.Size(353, 70);
            this.btn_CalculateLoads.TabIndex = 3;
            this.btn_CalculateLoads.Text = "Calculate Optimum Loading Method";
            this.btn_CalculateLoads.UseVisualStyleBackColor = false;
            this.btn_CalculateLoads.Click += new System.EventHandler(this.btn_CalculateLoads_Click);
            // 
            // btn_ExitProgram
            // 
            this.btn_ExitProgram.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ExitProgram.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ExitProgram.Location = new System.Drawing.Point(632, 506);
            this.btn_ExitProgram.Name = "btn_ExitProgram";
            this.btn_ExitProgram.Size = new System.Drawing.Size(353, 70);
            this.btn_ExitProgram.TabIndex = 4;
            this.btn_ExitProgram.Text = "Exit Program";
            this.btn_ExitProgram.UseVisualStyleBackColor = false;
            this.btn_ExitProgram.Click += new System.EventHandler(this.btn_ExitProgram_Click);
            // 
            // lbl_FileSelected
            // 
            this.lbl_FileSelected.AutoSize = true;
            this.lbl_FileSelected.Location = new System.Drawing.Point(632, 15);
            this.lbl_FileSelected.Name = "lbl_FileSelected";
            this.lbl_FileSelected.Size = new System.Drawing.Size(96, 20);
            this.lbl_FileSelected.TabIndex = 5;
            this.lbl_FileSelected.Text = "File Selected:";
            // 
            // txb_FilePath
            // 
            this.txb_FilePath.Enabled = false;
            this.txb_FilePath.Location = new System.Drawing.Point(734, 12);
            this.txb_FilePath.Name = "txb_FilePath";
            this.txb_FilePath.ReadOnly = true;
            this.txb_FilePath.Size = new System.Drawing.Size(251, 27);
            this.txb_FilePath.TabIndex = 6;
            // 
            // txb_Solution
            // 
            this.txb_Solution.Location = new System.Drawing.Point(12, 12);
            this.txb_Solution.Name = "txb_Solution";
            this.txb_Solution.ReadOnly = true;
            this.txb_Solution.Size = new System.Drawing.Size(614, 522);
            this.txb_Solution.TabIndex = 7;
            this.txb_Solution.Text = "";
            // 
            // lbl_Solution
            // 
            this.lbl_Solution.AutoSize = true;
            this.lbl_Solution.Location = new System.Drawing.Point(12, 552);
            this.lbl_Solution.Name = "lbl_Solution";
            this.lbl_Solution.Size = new System.Drawing.Size(168, 20);
            this.lbl_Solution.TabIndex = 8;
            this.lbl_Solution.Text = "Total Amount of Lorries:";
            // 
            // lbl_NumOfLorries
            // 
            this.lbl_NumOfLorries.AutoSize = true;
            this.lbl_NumOfLorries.Location = new System.Drawing.Point(186, 552);
            this.lbl_NumOfLorries.Name = "lbl_NumOfLorries";
            this.lbl_NumOfLorries.Size = new System.Drawing.Size(30, 20);
            this.lbl_NumOfLorries.TabIndex = 9;
            this.lbl_NumOfLorries.Text = "NA";
            // 
            // lbl_TotalItems
            // 
            this.lbl_TotalItems.Location = new System.Drawing.Point(347, 552);
            this.lbl_TotalItems.Name = "lbl_TotalItems";
            this.lbl_TotalItems.Size = new System.Drawing.Size(100, 23);
            this.lbl_TotalItems.TabIndex = 10;
            this.lbl_TotalItems.Text = "NA";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(241, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Items: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(992, 581);
            this.Controls.Add(this.btn_SelectLorry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_TotalItems);
            this.Controls.Add(this.lbl_NumOfLorries);
            this.Controls.Add(this.lbl_Solution);
            this.Controls.Add(this.txb_Solution);
            this.Controls.Add(this.txb_FilePath);
            this.Controls.Add(this.lbl_FileSelected);
            this.Controls.Add(this.btn_CalculateLoads);
            this.Controls.Add(this.btn_ExitProgram);
            this.Controls.Add(this.btn_FileSave);
            this.Controls.Add(this.btn_FileSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

    }
}
