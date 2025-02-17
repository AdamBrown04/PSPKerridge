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
            SuspendLayout();
            // 
            // btn_FileFind
            // 
            btn_FileFind.Location = new Point(12, 12);
            btn_FileFind.Name = "btn_FileFind";
            btn_FileFind.Size = new Size(391, 49);
            btn_FileFind.TabIndex = 0;
            btn_FileFind.Text = "Select a File";
            btn_FileFind.UseVisualStyleBackColor = true;
            // 
            // btn_FileConfirm
            // 
            btn_FileConfirm.BackColor = SystemColors.Info;
            btn_FileConfirm.Location = new Point(12, 77);
            btn_FileConfirm.Name = "btn_FileConfirm";
            btn_FileConfirm.Size = new Size(391, 49);
            btn_FileConfirm.TabIndex = 1;
            btn_FileConfirm.Text = "Confirm File";
            btn_FileConfirm.UseVisualStyleBackColor = false;
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.Info;
            btn_Return.Location = new Point(12, 132);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(391, 49);
            btn_Return.TabIndex = 2;
            btn_Return.Text = "Return to Menu";
            btn_Return.UseVisualStyleBackColor = false;
            btn_Return.Click += btn_Return_Click;
            // 
            // SelectFileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(415, 193);
            Controls.Add(btn_Return);
            Controls.Add(btn_FileConfirm);
            Controls.Add(btn_FileFind);
            Name = "SelectFileForm";
            Text = "Select File";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_FileFind;
        private Button btn_FileConfirm;
        private Button btn_Return;
    }
}