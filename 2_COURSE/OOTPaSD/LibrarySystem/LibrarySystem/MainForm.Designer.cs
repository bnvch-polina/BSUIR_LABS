namespace LibrarySystem;

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
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        ButtonShowLibrarian = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        button6 = new System.Windows.Forms.Button();
        button7 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(329, 17);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(301, 93);
        button1.TabIndex = 0;
        button1.Text = "Библиотека";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(129, 192);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(201, 90);
        button2.TabIndex = 1;
        button2.Text = "Человек";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(611, 192);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(198, 90);
        button3.TabIndex = 2;
        button3.Text = "Книга";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // ButtonShowLibrarian
        // 
        ButtonShowLibrarian.Location = new System.Drawing.Point(4, 381);
        ButtonShowLibrarian.Name = "ButtonShowLibrarian";
        ButtonShowLibrarian.Size = new System.Drawing.Size(201, 100);
        ButtonShowLibrarian.TabIndex = 3;
        ButtonShowLibrarian.Text = "Библиотекарь";
        ButtonShowLibrarian.UseVisualStyleBackColor = true;
        ButtonShowLibrarian.Click += ButtonShowLibrarian_Click_1;
        // 
        // button5
        // 
        button5.Location = new System.Drawing.Point(245, 381);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(201, 100);
        button5.TabIndex = 4;
        button5.Text = "Читатель";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.Location = new System.Drawing.Point(484, 381);
        button6.Name = "button6";
        button6.Size = new System.Drawing.Size(201, 100);
        button6.TabIndex = 5;
        button6.Text = "Учебник";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // button7
        // 
        button7.Location = new System.Drawing.Point(749, 381);
        button7.Name = "button7";
        button7.Size = new System.Drawing.Size(201, 100);
        button7.TabIndex = 6;
        button7.Text = "Художественная книга";
        button7.UseVisualStyleBackColor = true;
        button7.Click += button7_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(955, 571);
        Controls.Add(button7);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(ButtonShowLibrarian);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button ButtonShowLibrarian;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    #endregion
}