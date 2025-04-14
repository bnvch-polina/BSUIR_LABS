namespace JewerlyStore;

partial class MainForm
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
        label1 = new System.Windows.Forms.Label();
        textBoxOutput = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(51, 59);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(212, 82);
        label1.TabIndex = 0;
        label1.Text = "label1";
        // 
        // textBoxOutput
        // 
        textBoxOutput.Location = new System.Drawing.Point(7, 1);
        textBoxOutput.Multiline = true;
        textBoxOutput.Name = "textBoxOutput";
        textBoxOutput.Size = new System.Drawing.Size(569, 596);
        textBoxOutput.TabIndex = 1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 611);
        Controls.Add(textBoxOutput);
        Controls.Add(label1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBoxOutput;

    private System.Windows.Forms.Label label1;

    #endregion
}