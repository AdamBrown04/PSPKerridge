using System.ComponentModel;

namespace PSPKerrdige
{
    partial class SelectLorry
    {
        private IContainer components = null;

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
            txt_LorryNumber = new System.Windows.Forms.TextBox();
            btn_ShowLorry = new System.Windows.Forms.Button();
            rtxt_ItemDetails = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // txt_LorryNumber
            // 
            txt_LorryNumber.Location = new System.Drawing.Point(143, 40);
            txt_LorryNumber.Name = "txt_LorryNumber";
            txt_LorryNumber.Size = new System.Drawing.Size(229, 27);
            txt_LorryNumber.TabIndex = 0;
            // Event assignment for TextChanged removed.
            // 
            // btn_ShowLorry
            // 
            btn_ShowLorry.BackColor = System.Drawing.SystemColors.Info;
            btn_ShowLorry.Location = new System.Drawing.Point(158, 73);
            btn_ShowLorry.Name = "btn_ShowLorry";
            btn_ShowLorry.Size = new System.Drawing.Size(199, 73);
            btn_ShowLorry.TabIndex = 1;
            btn_ShowLorry.Text = "Display Items";
            btn_ShowLorry.UseVisualStyleBackColor = false;
            btn_ShowLorry.Click += new System.EventHandler(this.btn_ShowLorry_Click);
            // 
            // rtxt_ItemDetails
            // 
            rtxt_ItemDetails.Location = new System.Drawing.Point(91, 168);
            rtxt_ItemDetails.Name = "rtxt_ItemDetails";
            rtxt_ItemDetails.ReadOnly = true;
            rtxt_ItemDetails.Size = new System.Drawing.Size(355, 209);
            rtxt_ItemDetails.TabIndex = 2;
            rtxt_ItemDetails.Text = "";
            // 
            // SelectLorry
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(520, 448);
            Controls.Add(rtxt_ItemDetails);
            Controls.Add(btn_ShowLorry);
            Controls.Add(txt_LorryNumber);
            Text = "SelectLorry";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.RichTextBox rtxt_ItemDetails;
        private System.Windows.Forms.Button btn_ShowLorry;
        private System.Windows.Forms.TextBox txt_LorryNumber;

        #endregion
    }
}
