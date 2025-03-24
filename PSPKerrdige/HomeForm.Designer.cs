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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_FileSelect = new Button();
            btn_FileSave = new Button();
            btn_ExitProgram = new Button();
            btn_CalculateLoads = new Button();
            btn_SelectLorry = new Button();
            lbl_FileSelected = new Label();
            txb_FilePath = new TextBox();
            txb_Solution = new RichTextBox();
            lbl_Solution = new Label();
            lbl_NumOfLorries = new Label();
            lbl_TotalItems = new Label();
            label1 = new Label();
            lbl_ProgessLabel = new Label();
            lbl_Progress = new Label();
            btn_ShowItemDetails = new Button();
            SuspendLayout();
            // 
            // btn_FileSelect
            // 
            btn_FileSelect.BackColor = SystemColors.Info;
            btn_FileSelect.Font = new Font("Segoe UI", 10.8F);
            btn_FileSelect.Location = new Point(632, 45);
            btn_FileSelect.Name = "btn_FileSelect";
            btn_FileSelect.Size = new Size(370, 70);
            btn_FileSelect.TabIndex = 0;
            btn_FileSelect.Text = "Select File";
            btn_FileSelect.UseVisualStyleBackColor = false;
            btn_FileSelect.Click += btn_FileSelect_Click;
            // 
            // btn_FileSave
            // 
            btn_FileSave.BackColor = SystemColors.Info;
            btn_FileSave.Enabled = false;
            btn_FileSave.Font = new Font("Segoe UI", 10.8F);
            btn_FileSave.Location = new Point(632, 121);
            btn_FileSave.Name = "btn_FileSave";
            btn_FileSave.Size = new Size(370, 70);
            btn_FileSave.TabIndex = 1;
            btn_FileSave.Text = "Save Output to File";
            btn_FileSave.UseVisualStyleBackColor = false;
            btn_FileSave.Click += btn_FileSave_Click;
            // 
            // btn_ExitProgram
            // 
            btn_ExitProgram.BackColor = SystemColors.Info;
            btn_ExitProgram.Font = new Font("Segoe UI", 10.8F);
            btn_ExitProgram.Location = new Point(632, 499);
            btn_ExitProgram.Name = "btn_ExitProgram";
            btn_ExitProgram.Size = new Size(370, 70);
            btn_ExitProgram.TabIndex = 4;
            btn_ExitProgram.Text = "Exit Program";
            btn_ExitProgram.UseVisualStyleBackColor = false;
            btn_ExitProgram.Click += btn_ExitProgram_Click;
            // 
            // btn_CalculateLoads
            // 
            btn_CalculateLoads.BackColor = SystemColors.Info;
            btn_CalculateLoads.Font = new Font("Segoe UI", 10.8F);
            btn_CalculateLoads.Location = new Point(632, 423);
            btn_CalculateLoads.Name = "btn_CalculateLoads";
            btn_CalculateLoads.Size = new Size(370, 70);
            btn_CalculateLoads.TabIndex = 3;
            btn_CalculateLoads.Text = "Calculate Optimum Loading Method";
            btn_CalculateLoads.UseVisualStyleBackColor = false;
            btn_CalculateLoads.Click += btn_CalculateLoads_Click;
            // 
            // btn_SelectLorry
            // 
            btn_SelectLorry.BackColor = SystemColors.Info;
            btn_SelectLorry.Enabled = false;
            btn_SelectLorry.Font = new Font("Segoe UI", 10.8F);
            btn_SelectLorry.Location = new Point(632, 197);
            btn_SelectLorry.Name = "btn_SelectLorry";
            btn_SelectLorry.Size = new Size(370, 70);
            btn_SelectLorry.TabIndex = 2;
            btn_SelectLorry.Text = "Select Lorry";
            btn_SelectLorry.UseVisualStyleBackColor = false;
            btn_SelectLorry.Click += btn_SelectLorry_Click;
            // 
            // lbl_FileSelected
            // 
            lbl_FileSelected.AutoSize = true;
            lbl_FileSelected.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FileSelected.Location = new Point(632, 11);
            lbl_FileSelected.Name = "lbl_FileSelected";
            lbl_FileSelected.Size = new Size(113, 25);
            lbl_FileSelected.TabIndex = 5;
            lbl_FileSelected.Text = "File Selected:";
            // 
            // txb_FilePath
            // 
            txb_FilePath.Enabled = false;
            txb_FilePath.Location = new Point(751, 12);
            txb_FilePath.Name = "txb_FilePath";
            txb_FilePath.ReadOnly = true;
            txb_FilePath.Size = new Size(251, 27);
            txb_FilePath.TabIndex = 6;
            // 
            // txb_Solution
            // 
            txb_Solution.Location = new Point(12, 12);
            txb_Solution.Name = "txb_Solution";
            txb_Solution.ReadOnly = true;
            txb_Solution.Size = new Size(614, 522);
            txb_Solution.TabIndex = 7;
            txb_Solution.Text = "";
            // 
            // lbl_Solution
            // 
            lbl_Solution.AutoSize = true;
            lbl_Solution.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Solution.Location = new Point(12, 547);
            lbl_Solution.Name = "lbl_Solution";
            lbl_Solution.Size = new Size(202, 25);
            lbl_Solution.TabIndex = 8;
            lbl_Solution.Text = "Total Amount of Lorries:";
            // 
            // lbl_NumOfLorries
            // 
            lbl_NumOfLorries.AutoSize = true;
            lbl_NumOfLorries.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NumOfLorries.Location = new Point(220, 547);
            lbl_NumOfLorries.Name = "lbl_NumOfLorries";
            lbl_NumOfLorries.Size = new Size(37, 25);
            lbl_NumOfLorries.TabIndex = 9;
            lbl_NumOfLorries.Text = "NA";
            // 
            // lbl_TotalItems
            // 
            lbl_TotalItems.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TotalItems.Location = new Point(396, 547);
            lbl_TotalItems.Name = "lbl_TotalItems";
            lbl_TotalItems.Size = new Size(71, 23);
            lbl_TotalItems.TabIndex = 10;
            lbl_TotalItems.Text = "NA";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 547);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 11;
            label1.Text = "Total Items: ";
            label1.Click += label1_Click;
            // 
            // lbl_ProgessLabel
            // 
            lbl_ProgessLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ProgessLabel.Location = new Point(473, 547);
            lbl_ProgessLabel.Name = "lbl_ProgessLabel";
            lbl_ProgessLabel.Size = new Size(84, 28);
            lbl_ProgessLabel.TabIndex = 12;
            lbl_ProgessLabel.Text = "Progess:";
            // 
            // lbl_Progress
            // 
            lbl_Progress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Progress.Location = new Point(563, 547);
            lbl_Progress.Name = "lbl_Progress";
            lbl_Progress.Size = new Size(63, 22);
            lbl_Progress.TabIndex = 13;
            lbl_Progress.Text = "NA";
            lbl_Progress.Click += lbl_Progress_Click;
            // 
            // btn_ShowItemDetails
            // 
            btn_ShowItemDetails.BackColor = SystemColors.Info;
            btn_ShowItemDetails.Enabled = false;
            btn_ShowItemDetails.Font = new Font("Segoe UI", 10.8F);
            btn_ShowItemDetails.Location = new Point(632, 273);
            btn_ShowItemDetails.Name = "btn_ShowItemDetails";
            btn_ShowItemDetails.Size = new Size(370, 70);
            btn_ShowItemDetails.TabIndex = 14;
            btn_ShowItemDetails.Text = "View an Item's details";
            btn_ShowItemDetails.UseVisualStyleBackColor = false;
            btn_ShowItemDetails.Click += btn_ShowItemDetails_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1007, 573);
            Controls.Add(btn_ShowItemDetails);
            Controls.Add(lbl_Progress);
            Controls.Add(lbl_ProgessLabel);
            Controls.Add(btn_SelectLorry);
            Controls.Add(label1);
            Controls.Add(lbl_TotalItems);
            Controls.Add(lbl_NumOfLorries);
            Controls.Add(lbl_Solution);
            Controls.Add(txb_Solution);
            Controls.Add(txb_FilePath);
            Controls.Add(lbl_FileSelected);
            Controls.Add(btn_CalculateLoads);
            Controls.Add(btn_ExitProgram);
            Controls.Add(btn_FileSave);
            Controls.Add(btn_FileSelect);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomeForm";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lbl_ProgessLabel;
        private System.Windows.Forms.Label lbl_Progress;

        #endregion

        private Button btn_ShowItemDetails;
    }
}
