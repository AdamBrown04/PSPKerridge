namespace PSPKerrdige
{
    partial class Menu
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
            Title = new System.Windows.Forms.TextBox();
            ViewItems = new System.Windows.Forms.Button();
            SortItems = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            Title.Location = new System.Drawing.Point(238, 31);
            Title.Name = "Title";
            Title.Size = new System.Drawing.Size(345, 47);
            Title.TabIndex = 0;
            Title.Text = "Lorry Sorter Program";
            Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ViewItems
            // 
            ViewItems.Location = new System.Drawing.Point(126, 275);
            ViewItems.Name = "ViewItems";
            ViewItems.Size = new System.Drawing.Size(160, 88);
            ViewItems.TabIndex = 1;
            ViewItems.Text = "View Items";
            ViewItems.UseVisualStyleBackColor = true;
            // 
            // SortItems
            // 
            SortItems.ForeColor = System.Drawing.Color.Black;
            SortItems.Location = new System.Drawing.Point(528, 275);
            SortItems.Name = "SortItems";
            SortItems.Size = new System.Drawing.Size(160, 88);
            SortItems.TabIndex = 2;
            SortItems.Text = "Sort Items";
            SortItems.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(SortItems);
            Controls.Add(ViewItems);
            Controls.Add(Title);
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button ViewItems;
        private System.Windows.Forms.Button SortItems;

        private System.Windows.Forms.TextBox Title;

        #endregion
    }
}
