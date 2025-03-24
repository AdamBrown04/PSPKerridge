namespace PSPKerrdige
{
    partial class SelectFileForm
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
            btn_FileFind = new Button();
            btn_FileConfirm = new Button();
            btn_Return = new Button();
            lbl_fileSelected = new Label();
            txb_FileSelected = new TextBox();
            SuspendLayout();
            // 
            // btn_FileFind
            // 
            btn_FileFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_FileFind.Location = new Point(12, 12);
            btn_FileFind.Name = "btn_FileFind";
            btn_FileFind.Size = new Size(408, 49);
            btn_FileFind.TabIndex = 0;
            btn_FileFind.Text = "Select a File";
            btn_FileFind.UseVisualStyleBackColor = true;
            btn_FileFind.Click += btn_FileFind_Click;
            // 
            // btn_FileConfirm
            // 
            btn_FileConfirm.BackColor = SystemColors.Info;
            btn_FileConfirm.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_FileConfirm.Location = new Point(12, 110);
            btn_FileConfirm.Name = "btn_FileConfirm";
            btn_FileConfirm.Size = new Size(408, 49);
            btn_FileConfirm.TabIndex = 1;
            btn_FileConfirm.Text = "Confirm File";
            btn_FileConfirm.UseVisualStyleBackColor = false;
            btn_FileConfirm.Click += btn_FileConfirm_Click;
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.Info;
            btn_Return.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Return.Location = new Point(12, 165);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(408, 49);
            btn_Return.TabIndex = 2;
            btn_Return.Text = "Return to Menu";
            btn_Return.UseVisualStyleBackColor = false;
            btn_Return.Click += btn_Return_Click;
            // 
            // lbl_fileSelected
            // 
            lbl_fileSelected.AutoSize = true;
            lbl_fileSelected.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_fileSelected.Location = new Point(12, 73);
            lbl_fileSelected.Name = "lbl_fileSelected";
            lbl_fileSelected.Size = new Size(111, 25);
            lbl_fileSelected.TabIndex = 3;
            lbl_fileSelected.Text = "File selected:";
            // 
            // txb_FileSelected
            // 
            txb_FileSelected.Enabled = false;
            txb_FileSelected.Location = new Point(129, 74);
            txb_FileSelected.Name = "txb_FileSelected";
            txb_FileSelected.ReadOnly = true;
            txb_FileSelected.Size = new Size(291, 27);
            txb_FileSelected.TabIndex = 4;
            // 
            // SelectFileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(428, 222);
            Controls.Add(txb_FileSelected);
            Controls.Add(lbl_fileSelected);
            Controls.Add(btn_Return);
            Controls.Add(btn_FileConfirm);
            Controls.Add(btn_FileFind);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SelectFileForm";
            Text = "Select File";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_FileFind;
        private Button btn_FileConfirm;
        private Button btn_Return;
        private Label lbl_fileSelected;
        private TextBox txb_FileSelected;
    }
}