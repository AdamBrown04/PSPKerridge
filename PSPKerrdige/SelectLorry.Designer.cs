namespace PSPKerrdige
{
    partial class SelectLorry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btn_ShowLorry;
        private System.Windows.Forms.RichTextBox txb_LorryDetails;
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
            btn_ShowLorry = new Button();
            txb_LorryDetails = new RichTextBox();
            lbl_LorryNumber = new Label();
            Nud_lorryNumber = new NumericUpDown();
            ReturnToMenu = new Button();
            btn_saveLorry = new Button();
            ((System.ComponentModel.ISupportInitialize)Nud_lorryNumber).BeginInit();
            SuspendLayout();
            // 
            // btn_ShowLorry
            // 
            btn_ShowLorry.BackColor = SystemColors.Info;
            btn_ShowLorry.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ShowLorry.Location = new Point(607, 48);
            btn_ShowLorry.Name = "btn_ShowLorry";
            btn_ShowLorry.Size = new Size(200, 75);
            btn_ShowLorry.TabIndex = 1;
            btn_ShowLorry.Text = "Show Lorry";
            btn_ShowLorry.UseVisualStyleBackColor = false;
            btn_ShowLorry.Click += btn_ShowLorry_Click;
            // 
            // txb_LorryDetails
            // 
            txb_LorryDetails.Location = new Point(12, 12);
            txb_LorryDetails.Name = "txb_LorryDetails";
            txb_LorryDetails.ReadOnly = true;
            txb_LorryDetails.Size = new Size(588, 371);
            txb_LorryDetails.TabIndex = 2;
            txb_LorryDetails.Text = "";
            // 
            // lbl_LorryNumber
            // 
            lbl_LorryNumber.AutoSize = true;
            lbl_LorryNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_LorryNumber.Location = new Point(607, 15);
            lbl_LorryNumber.Name = "lbl_LorryNumber";
            lbl_LorryNumber.Size = new Size(126, 25);
            lbl_LorryNumber.TabIndex = 3;
            lbl_LorryNumber.Text = "Lorry Number:";
            // 
            // Nud_lorryNumber
            // 
            Nud_lorryNumber.Location = new Point(739, 15);
            Nud_lorryNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Nud_lorryNumber.Name = "Nud_lorryNumber";
            Nud_lorryNumber.Size = new Size(68, 27);
            Nud_lorryNumber.TabIndex = 4;
            Nud_lorryNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ReturnToMenu
            // 
            ReturnToMenu.BackColor = SystemColors.Info;
            ReturnToMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReturnToMenu.Location = new Point(606, 308);
            ReturnToMenu.Name = "ReturnToMenu";
            ReturnToMenu.Size = new Size(201, 75);
            ReturnToMenu.TabIndex = 5;
            ReturnToMenu.Text = "Return to Menu";
            ReturnToMenu.UseVisualStyleBackColor = false;
            ReturnToMenu.Click += ReturnToMenu_Click;
            // 
            // btn_saveLorry
            // 
            btn_saveLorry.BackColor = SystemColors.Info;
            btn_saveLorry.Enabled = false;
            btn_saveLorry.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_saveLorry.Location = new Point(607, 129);
            btn_saveLorry.Name = "btn_saveLorry";
            btn_saveLorry.Size = new Size(200, 75);
            btn_saveLorry.TabIndex = 6;
            btn_saveLorry.Text = "Save Lorry Information";
            btn_saveLorry.UseVisualStyleBackColor = false;
            btn_saveLorry.Click += btn_saveLorry_Click;
            // 
            // SelectLorry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 395);
            Controls.Add(btn_saveLorry);
            Controls.Add(ReturnToMenu);
            Controls.Add(Nud_lorryNumber);
            Controls.Add(lbl_LorryNumber);
            Controls.Add(txb_LorryDetails);
            Controls.Add(btn_ShowLorry);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SelectLorry";
            Text = "Select Lorry";
            ((System.ComponentModel.ISupportInitialize)Nud_lorryNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown Nud_lorryNumber;
        private Button ReturnToMenu;
        private Button btn_saveLorry;
    }
}
