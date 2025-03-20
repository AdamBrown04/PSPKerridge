
namespace PSPKerrdige
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            btn_FileSelect = new System.Windows.Forms.Button();
            btn_FileSave = new System.Windows.Forms.Button();
            btn_ExitProgram = new System.Windows.Forms.Button();
            btn_CalculateLoads = new System.Windows.Forms.Button();
            lbl_FileSelected = new System.Windows.Forms.Label();
            txb_FilePath = new System.Windows.Forms.TextBox();
            txb_Solution = new System.Windows.Forms.RichTextBox();
            lbl_Solution = new System.Windows.Forms.Label();
            lbl_NumOfLorries = new System.Windows.Forms.Label();
            lbl_TotalItems = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btn_SelectLorry = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btn_FileSelect
            // 
            btn_FileSelect.BackColor = System.Drawing.SystemColors.Info;
            btn_FileSelect.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btn_FileSelect.Location = new System.Drawing.Point(632, 45);
            btn_FileSelect.Name = "btn_FileSelect";
            btn_FileSelect.Size = new System.Drawing.Size(353, 70);
            btn_FileSelect.TabIndex = 1;
            btn_FileSelect.Text = "Select File";
            btn_FileSelect.UseVisualStyleBackColor = false;
            btn_FileSelect.Click += btn_FileSelect_Click;
            // 
            // btn_FileSave
            // 
            btn_FileSave.BackColor = System.Drawing.SystemColors.Info;
            btn_FileSave.Enabled = false;
            btn_FileSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btn_FileSave.Location = new System.Drawing.Point(632, 121);
            btn_FileSave.Name = "btn_FileSave";
            btn_FileSave.Size = new System.Drawing.Size(353, 70);
            btn_FileSave.TabIndex = 2;
            btn_FileSave.Text = "Save Output to File";
            btn_FileSave.UseVisualStyleBackColor = false;
            btn_FileSave.Click += btn_FileSave_Click;
            // 
            // btn_ExitProgram
            // 
            btn_ExitProgram.BackColor = System.Drawing.SystemColors.Info;
            btn_ExitProgram.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btn_ExitProgram.Location = new System.Drawing.Point(632, 506);
            btn_ExitProgram.Name = "btn_ExitProgram";
            btn_ExitProgram.Size = new System.Drawing.Size(353, 70);
            btn_ExitProgram.TabIndex = 3;
            btn_ExitProgram.Text = "Exit Program";
            btn_ExitProgram.UseVisualStyleBackColor = false;
            btn_ExitProgram.Click += btn_ExitProgram_Click;
            // 
            // btn_CalculateLoads
            // 
            btn_CalculateLoads.BackColor = System.Drawing.SystemColors.Info;
            btn_CalculateLoads.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btn_CalculateLoads.Location = new System.Drawing.Point(632, 430);
            btn_CalculateLoads.Name = "btn_CalculateLoads";
            btn_CalculateLoads.Size = new System.Drawing.Size(353, 70);
            btn_CalculateLoads.TabIndex = 4;
            btn_CalculateLoads.Text = "Calculate Optimum Loading Method";
            btn_CalculateLoads.UseVisualStyleBackColor = false;
            btn_CalculateLoads.Click += btn_CalculateLoads_Click;
            // 
            // lbl_FileSelected
            // 
            lbl_FileSelected.AutoSize = true;
            lbl_FileSelected.Location = new System.Drawing.Point(632, 15);
            lbl_FileSelected.Name = "lbl_FileSelected";
            lbl_FileSelected.Size = new System.Drawing.Size(96, 20);
            lbl_FileSelected.TabIndex = 5;
            lbl_FileSelected.Text = "File Selected:";
            // 
            // txb_FilePath
            // 
            txb_FilePath.Enabled = false;
            txb_FilePath.Location = new System.Drawing.Point(734, 12);
            txb_FilePath.Name = "txb_FilePath";
            txb_FilePath.ReadOnly = true;
            txb_FilePath.Size = new System.Drawing.Size(251, 27);
            txb_FilePath.TabIndex = 6;
            // 
            // txb_Solution
            // 
            txb_Solution.Location = new System.Drawing.Point(12, 12);
            txb_Solution.Name = "txb_Solution";
            txb_Solution.ReadOnly = true;
            txb_Solution.Size = new System.Drawing.Size(614, 522);
            txb_Solution.TabIndex = 7;
            txb_Solution.Text = "";
            // 
            // lbl_Solution
            // 
            lbl_Solution.AutoSize = true;
            lbl_Solution.Location = new System.Drawing.Point(12, 552);
            lbl_Solution.Name = "lbl_Solution";
            lbl_Solution.Size = new System.Drawing.Size(168, 20);
            lbl_Solution.TabIndex = 8;
            lbl_Solution.Text = "Total Amount of Lorries:";
            // 
            // lbl_NumOfLorries
            // 
            lbl_NumOfLorries.AutoSize = true;
            lbl_NumOfLorries.Location = new System.Drawing.Point(186, 552);
            lbl_NumOfLorries.Name = "lbl_NumOfLorries";
            lbl_NumOfLorries.Size = new System.Drawing.Size(30, 20);
            lbl_NumOfLorries.TabIndex = 9;
            lbl_NumOfLorries.Text = "NA";
            // 
            // lbl_TotalItems
            // 
            lbl_TotalItems.Location = new System.Drawing.Point(347, 552);
            lbl_TotalItems.Name = "lbl_TotalItems";
            lbl_TotalItems.Size = new System.Drawing.Size(100, 23);
            lbl_TotalItems.TabIndex = 10;
            lbl_TotalItems.Text = "NA";
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(241, 552);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 23);
            label1.TabIndex = 11;
            label1.Text = "Total Items: ";
            label1.Click += label1_Click;
            // 
            // btn_SelectLorry
            // 
            btn_SelectLorry.BackColor = System.Drawing.SystemColors.Info;
            btn_SelectLorry.Enabled = false;
            btn_SelectLorry.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btn_SelectLorry.Location = new System.Drawing.Point(632, 197);
            btn_SelectLorry.Name = "btn_SelectLorry";
            btn_SelectLorry.Size = new System.Drawing.Size(353, 70);
            btn_SelectLorry.TabIndex = 12;
            btn_SelectLorry.Text = "Select Lorry";
            btn_SelectLorry.UseVisualStyleBackColor = false;
            btn_SelectLorry.Click += btn_SelectLorry_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(992, 581);
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
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btn_SelectLorry;

        private System.Windows.Forms.Label lbl_TotalItems;
        private System.Windows.Forms.Label label1;

        #endregion

        private Button btn_FileSelect;
        private Button btn_FileSave;
        private Button btn_ExitProgram;
        private Button btn_CalculateLoads;

        private Label lbl_FileSelected;
        private TextBox txb_FilePath;
        private RichTextBox txb_Solution;
        private Label lbl_Solution;
        private Label lbl_NumOfLorries;
    }
}
