using System.ComponentModel;

namespace PSPKerrdige;

partial class ViewItems
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        View = new System.Windows.Forms.ListBox();
        SuspendLayout();
        //
        // View
        //
        View.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        View.FormattingEnabled = true;
        View.ItemHeight = 28;
        View.Location = new System.Drawing.Point(144, 67);
        View.Name = "View";
        View.Size = new System.Drawing.Size(504, 228);
        View.TabIndex = 0;
        View.SelectedIndexChanged += View_SelectedIndexChanged;
        //
        // ViewItems
        //
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(View);
        Text = "ViewItems";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ListBox View;

    #endregion
}