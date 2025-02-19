
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_FileSelect = new Button();
            btn_FileSave = new Button();
            btn_ExitProgram = new Button();
            btn_CalculateLoads = new Button();
            lbl_FileSelected = new Label();
            txb_FilePath = new TextBox();
            txb_Solution = new RichTextBox();
            lbl_Solution = new Label();
            txb_NumOfLorries = new TextBox();
            SuspendLayout();
            // 
            // btn_FileSelect
            // 
            btn_FileSelect.BackColor = SystemColors.Info;
            btn_FileSelect.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_FileSelect.Location = new Point(632, 45);
            btn_FileSelect.Name = "btn_FileSelect";
            btn_FileSelect.Size = new Size(353, 70);
            btn_FileSelect.TabIndex = 1;
            btn_FileSelect.Text = "Select File";
            btn_FileSelect.UseVisualStyleBackColor = false;
            btn_FileSelect.Click += btn_FileSelect_Click;
            // 
            // btn_FileSave
            // 
            btn_FileSave.BackColor = SystemColors.Info;
            btn_FileSave.Enabled = false;
            btn_FileSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_FileSave.Location = new Point(632, 121);
            btn_FileSave.Name = "btn_FileSave";
            btn_FileSave.Size = new Size(353, 70);
            btn_FileSave.TabIndex = 2;
            btn_FileSave.Text = "Save Output to File";
            btn_FileSave.UseVisualStyleBackColor = false;
            btn_FileSave.Click += btn_FileSave_Click;
            // 
            // btn_ExitProgram
            // 
            btn_ExitProgram.BackColor = SystemColors.Info;
            btn_ExitProgram.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ExitProgram.Location = new Point(632, 506);
            btn_ExitProgram.Name = "btn_ExitProgram";
            btn_ExitProgram.Size = new Size(353, 70);
            btn_ExitProgram.TabIndex = 3;
            btn_ExitProgram.Text = "Exit Program";
            btn_ExitProgram.UseVisualStyleBackColor = false;
            btn_ExitProgram.Click += btn_ExitProgram_Click;
            // 
            // btn_CalculateLoads
            // 
            btn_CalculateLoads.BackColor = SystemColors.Info;
            btn_CalculateLoads.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CalculateLoads.Location = new Point(632, 430);
            btn_CalculateLoads.Name = "btn_CalculateLoads";
            btn_CalculateLoads.Size = new Size(353, 70);
            btn_CalculateLoads.TabIndex = 4;
            btn_CalculateLoads.Text = "Calculate Optimum Loading Method";
            btn_CalculateLoads.UseVisualStyleBackColor = false;
            btn_CalculateLoads.Click += btn_CalculateLoads_Click;
            // 
            // lbl_FileSelected
            // 
            lbl_FileSelected.AutoSize = true;
            lbl_FileSelected.Location = new Point(632, 15);
            lbl_FileSelected.Name = "lbl_FileSelected";
            lbl_FileSelected.Size = new Size(96, 20);
            lbl_FileSelected.TabIndex = 5;
            lbl_FileSelected.Text = "File Selected:";
            // 
            // txb_FilePath
            // 
            txb_FilePath.Enabled = false;
            txb_FilePath.Location = new Point(734, 12);
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
            lbl_Solution.Location = new Point(12, 552);
            lbl_Solution.Name = "lbl_Solution";
            lbl_Solution.Size = new Size(168, 20);
            lbl_Solution.TabIndex = 8;
            lbl_Solution.Text = "Total Amount of Lorries:";
            // 
            // txb_NumOfLorries
            // 
            txb_NumOfLorries.Location = new Point(186, 549);
            txb_NumOfLorries.Name = "txb_NumOfLorries";
            txb_NumOfLorries.ReadOnly = true;
            txb_NumOfLorries.Size = new Size(84, 27);
            txb_NumOfLorries.TabIndex = 9;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(992, 581);
            Controls.Add(txb_NumOfLorries);
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

        #endregion

        private Button btn_FileSelect;
        private Button btn_FileSave;
        private Button btn_ExitProgram;
        private Button btn_CalculateLoads;

        private Label lbl_FileSelected;
        private TextBox txb_FilePath;
        private RichTextBox txb_Solution;
        private Label lbl_Solution;
        private TextBox txb_NumOfLorries;
    }
}
