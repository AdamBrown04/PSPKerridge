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
            this.btn_FileSelect = new System.Windows.Forms.Button();
            this.btn_FileSave = new System.Windows.Forms.Button();
            this.btn_ExitProgram = new System.Windows.Forms.Button();
            this.btn_CalculateLoads = new System.Windows.Forms.Button();
            this.lbl_FileSelected = new System.Windows.Forms.Label();
            this.txb_FilePath = new System.Windows.Forms.TextBox();
            this.txb_Solution = new System.Windows.Forms.RichTextBox();
            this.lbl_Solution = new System.Windows.Forms.Label();
            this.lbl_NumOfLorries = new System.Windows.Forms.Label();
            this.lbl_TotalItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            // New controls for singular lorry selection:
            this.txt_LorryNumber = new System.Windows.Forms.TextBox();
            this.btn_ShowLorry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_FileSelect
            // 
            this.btn_FileSelect.BackColor = System.Drawing.SystemColors.Info;
            this.btn_FileSelect.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FileSelect.Location = new System.Drawing.Point(632, 45);
            this.btn_FileSelect.Name = "btn_FileSelect";
            this.btn_FileSelect.Size = new System.Drawing.Size(353, 70);
            this.btn_FileSelect.TabIndex = 1;
            this.btn_FileSelect.Text = "Select File";
            this.btn_FileSelect.UseVisualStyleBackColor = false;
            this.btn_FileSelect.Click += new System.EventHandler(this.btn_FileSelect_Click);
            // 
            // btn_FileSave
            // 
            this.btn_FileSave.BackColor = System.Drawing.SystemColors.Info;
            this.btn_FileSave.Enabled = false;
            this.btn_FileSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FileSave.Location = new System.Drawing.Point(632, 121);
            this.btn_FileSave.Name = "btn_FileSave";
            this.btn_FileSave.Size = new System.Drawing.Size(353, 70);
            this.btn_FileSave.TabIndex = 2;
            this.btn_FileSave.Text = "Save Output to File";
            this.btn_FileSave.UseVisualStyleBackColor = false;
            this.btn_FileSave.Click += new System.EventHandler(this.btn_FileSave_Click);
            // 
            // btn_ExitProgram
            // 
            this.btn_ExitProgram.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ExitProgram.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitProgram.Location = new System.Drawing.Point(632, 506);
            this.btn_ExitProgram.Name = "btn_ExitProgram";
            this.btn_ExitProgram.Size = new System.Drawing.Size(353, 70);
            this.btn_ExitProgram.TabIndex = 3;
            this.btn_ExitProgram.Text = "Exit Program";
            this.btn_ExitProgram.UseVisualStyleBackColor = false;
            this.btn_ExitProgram.Click += new System.EventHandler(this.btn_ExitProgram_Click);
            // 
            // btn_CalculateLoads
            // 
            this.btn_CalculateLoads.BackColor = System.Drawing.SystemColors.Info;
            this.btn_CalculateLoads.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalculateLoads.Location = new System.Drawing.Point(632, 430);
            this.btn_CalculateLoads.Name = "btn_CalculateLoads";
            this.btn_CalculateLoads.Size = new System.Drawing.Size(353, 70);
            this.btn_CalculateLoads.TabIndex = 4;
            this.btn_CalculateLoads.Text = "Calculate Optimum Loading Method";
            this.btn_CalculateLoads.UseVisualStyleBackColor = false;
            this.btn_CalculateLoads.Click += new System.EventHandler(this.btn_CalculateLoads_Click);
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
            // txt_LorryNumber
            // 
            this.txt_LorryNumber.Location = new System.Drawing.Point(632, 197);
            this.txt_LorryNumber.Name = "txt_LorryNumber";
            this.txt_LorryNumber.Size = new System.Drawing.Size(150, 27);
            this.txt_LorryNumber.TabIndex = 12;
            // 
            // btn_ShowLorry
            // 
            this.btn_ShowLorry.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ShowLorry.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowLorry.Location = new System.Drawing.Point(792, 197);
            this.btn_ShowLorry.Name = "btn_ShowLorry";
            this.btn_ShowLorry.Size = new System.Drawing.Size(193, 70);
            this.btn_ShowLorry.TabIndex = 13;
            this.btn_ShowLorry.Text = "Show Lorry";
            
