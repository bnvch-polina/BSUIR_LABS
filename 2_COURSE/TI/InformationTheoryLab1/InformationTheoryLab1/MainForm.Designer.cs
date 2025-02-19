namespace InformationTheoryLab1;

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
        chooseActionBox = new System.Windows.Forms.ComboBox();
        keyBox = new System.Windows.Forms.TextBox();
        resultBox = new System.Windows.Forms.TextBox();
        dataBox = new System.Windows.Forms.TextBox();
        dataLabel = new System.Windows.Forms.Label();
        keyLabel = new System.Windows.Forms.Label();
        actionButton = new System.Windows.Forms.Button();
        chooseAlgorithmBox = new System.Windows.Forms.ComboBox();
        resultLabel = new System.Windows.Forms.Label();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        SuspendLayout();
        // 
        // chooseActionBox
        // 
        chooseActionBox.FormattingEnabled = true;
        chooseActionBox.Location = new System.Drawing.Point(34, 46);
        chooseActionBox.Name = "chooseActionBox";
        chooseActionBox.Size = new System.Drawing.Size(261, 33);
        chooseActionBox.TabIndex = 2;
        chooseActionBox.Text = "Выберите действие";
        // 
        // keyBox
        // 
        keyBox.Location = new System.Drawing.Point(34, 250);
        keyBox.Name = "keyBox";
        keyBox.Size = new System.Drawing.Size(658, 31);
        keyBox.TabIndex = 3;
        // 
        // resultBox
        // 
        resultBox.Location = new System.Drawing.Point(34, 428);
        resultBox.Name = "resultBox";
        resultBox.Size = new System.Drawing.Size(658, 31);
        resultBox.TabIndex = 4;
        // 
        // dataBox
        // 
        dataBox.Location = new System.Drawing.Point(34, 156);
        dataBox.Name = "dataBox";
        dataBox.Size = new System.Drawing.Size(658, 31);
        dataBox.TabIndex = 5;
        // 
        // dataLabel
        // 
        dataLabel.Location = new System.Drawing.Point(34, 106);
        dataLabel.Name = "dataLabel";
        dataLabel.Size = new System.Drawing.Size(526, 31);
        dataLabel.TabIndex = 6;
        dataLabel.Text = "Исходный текст (шифротекст)";
        // 
        // keyLabel
        // 
        keyLabel.Location = new System.Drawing.Point(34, 205);
        keyLabel.Name = "keyLabel";
        keyLabel.Size = new System.Drawing.Size(203, 31);
        keyLabel.TabIndex = 8;
        keyLabel.Text = "Ключ";
        // 
        // actionButton
        // 
        actionButton.Enabled = false;
        actionButton.Location = new System.Drawing.Point(34, 313);
        actionButton.Name = "actionButton";
        actionButton.Size = new System.Drawing.Size(167, 34);
        actionButton.TabIndex = 9;
        actionButton.Text = "Шифровать";
        actionButton.UseVisualStyleBackColor = true;
        actionButton.Click += actionButton_Click;
        // 
        // chooseAlgorithmBox
        // 
        chooseAlgorithmBox.FormattingEnabled = true;
        chooseAlgorithmBox.Location = new System.Drawing.Point(317, 46);
        chooseAlgorithmBox.Name = "chooseAlgorithmBox";
        chooseAlgorithmBox.Size = new System.Drawing.Size(375, 33);
        chooseAlgorithmBox.TabIndex = 13;
        chooseAlgorithmBox.Text = "Выберите алгоритм";
        chooseAlgorithmBox.SelectedIndexChanged += chooseAlgorithmBox_SelectedIndexChanged;
        // 
        // resultLabel
        // 
        resultLabel.Location = new System.Drawing.Point(34, 373);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new System.Drawing.Size(203, 31);
        resultLabel.TabIndex = 14;
        resultLabel.Text = "Результат";
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(706, 24);
        menuStrip1.TabIndex = 15;
        menuStrip1.Text = "menuStrip1";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ControlLight;
        ClientSize = new System.Drawing.Size(706, 507);
        Controls.Add(resultLabel);
        Controls.Add(chooseAlgorithmBox);
        Controls.Add(actionButton);
        Controls.Add(keyLabel);
        Controls.Add(dataLabel);
        Controls.Add(dataBox);
        Controls.Add(resultBox);
        Controls.Add(keyBox);
        Controls.Add(chooseActionBox);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Text = "Теория Информации (1 лаба)";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.MenuStrip menuStrip1;


    private System.Windows.Forms.Label resultLabel;

    private System.Windows.Forms.ComboBox chooseAlgorithmBox;

    private System.Windows.Forms.Button actionButton;

    private System.Windows.Forms.TextBox dataBox;
    private System.Windows.Forms.Label dataLabel;
    private System.Windows.Forms.Label keyLabel;

    private System.Windows.Forms.TextBox resultBox;

    private System.Windows.Forms.TextBox keyBox;

    private System.Windows.Forms.ComboBox chooseActionBox;

    #endregion
}