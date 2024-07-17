namespace fort.winforms
{
  partial class Form1
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      checkBoxW = new CheckBox();
      checkBoxA = new CheckBox();
      checkBoxS = new CheckBox();
      checkBoxD = new CheckBox();
      checkBoxSpace = new CheckBox();
      comboBoxKeys = new ComboBox();
      buttonRun = new Button();
      buttonStop = new Button();
      textBoxSignature = new TextBox();
      label1 = new Label();
      label3 = new Label();
      textBox1 = new TextBox();
      SuspendLayout();
      // 
      // checkBoxW
      // 
      checkBoxW.AutoSize = true;
      checkBoxW.Checked = true;
      checkBoxW.CheckState = CheckState.Checked;
      checkBoxW.Location = new Point(27, 15);
      checkBoxW.Name = "checkBoxW";
      checkBoxW.Size = new Size(66, 19);
      checkBoxW.TabIndex = 0;
      checkBoxW.Text = "Tecla W";
      checkBoxW.UseVisualStyleBackColor = true;
      checkBoxW.CheckedChanged += checkBoxW_CheckedChanged;
      // 
      // checkBoxA
      // 
      checkBoxA.AutoSize = true;
      checkBoxA.Checked = true;
      checkBoxA.CheckState = CheckState.Checked;
      checkBoxA.Location = new Point(27, 40);
      checkBoxA.Name = "checkBoxA";
      checkBoxA.Size = new Size(63, 19);
      checkBoxA.TabIndex = 1;
      checkBoxA.Text = "Tecla A";
      checkBoxA.UseVisualStyleBackColor = true;
      checkBoxA.CheckedChanged += checkBoxA_CheckedChanged;
      // 
      // checkBoxS
      // 
      checkBoxS.AutoSize = true;
      checkBoxS.Checked = true;
      checkBoxS.CheckState = CheckState.Checked;
      checkBoxS.Location = new Point(27, 65);
      checkBoxS.Name = "checkBoxS";
      checkBoxS.Size = new Size(61, 19);
      checkBoxS.TabIndex = 2;
      checkBoxS.Text = "Tecla S";
      checkBoxS.UseVisualStyleBackColor = true;
      checkBoxS.CheckedChanged += checkBoxS_CheckedChanged;
      // 
      // checkBoxD
      // 
      checkBoxD.AutoSize = true;
      checkBoxD.Checked = true;
      checkBoxD.CheckState = CheckState.Checked;
      checkBoxD.Location = new Point(27, 90);
      checkBoxD.Name = "checkBoxD";
      checkBoxD.Size = new Size(63, 19);
      checkBoxD.TabIndex = 3;
      checkBoxD.Text = "Tecla D";
      checkBoxD.UseVisualStyleBackColor = true;
      checkBoxD.CheckedChanged += checkBoxD_CheckedChanged;
      // 
      // checkBoxSpace
      // 
      checkBoxSpace.AutoSize = true;
      checkBoxSpace.Checked = true;
      checkBoxSpace.CheckState = CheckState.Checked;
      checkBoxSpace.Location = new Point(27, 115);
      checkBoxSpace.Name = "checkBoxSpace";
      checkBoxSpace.Size = new Size(86, 19);
      checkBoxSpace.TabIndex = 4;
      checkBoxSpace.Text = "Tecla Space";
      checkBoxSpace.UseVisualStyleBackColor = true;
      checkBoxSpace.CheckedChanged += checkBoxSpace_CheckedChanged;
      // 
      // comboBoxKeys
      // 
      comboBoxKeys.FormattingEnabled = true;
      comboBoxKeys.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
      comboBoxKeys.Location = new Point(181, 184);
      comboBoxKeys.Name = "comboBoxKeys";
      comboBoxKeys.Size = new Size(55, 23);
      comboBoxKeys.TabIndex = 5;
      comboBoxKeys.SelectedIndex = 0;
      // 
      // buttonRun
      // 
      buttonRun.BackColor = Color.Green;
      buttonRun.Location = new Point(140, 3);
      buttonRun.Name = "buttonRun";
      buttonRun.Size = new Size(121, 81);
      buttonRun.TabIndex = 6;
      buttonRun.Text = "Run";
      buttonRun.UseVisualStyleBackColor = false;
      buttonRun.Click += buttonRun_Click;
      // 
      // buttonStop
      // 
      buttonStop.BackColor = Color.DarkGray;
      buttonStop.Location = new Point(140, 90);
      buttonStop.Name = "buttonStop";
      buttonStop.Size = new Size(121, 81);
      buttonStop.TabIndex = 7;
      buttonStop.Text = "Stop";
      buttonStop.UseVisualStyleBackColor = false;
      buttonStop.Click += buttonStop_Click;
      // 
      // textBoxSignature
      // 
      textBoxSignature.BackColor = SystemColors.ActiveCaption;
      textBoxSignature.Enabled = false;
      textBoxSignature.Location = new Point(212, 253);
      textBoxSignature.Name = "textBoxSignature";
      textBoxSignature.Size = new Size(49, 23);
      textBoxSignature.TabIndex = 8;
      textBoxSignature.Text = "@thj3a";
      textBoxSignature.TextAlign = HorizontalAlignment.Center;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.BackColor = SystemColors.Info;
      label1.Location = new Point(12, 187);
      label1.Name = "label1";
      label1.Size = new Size(163, 15);
      label1.TabIndex = 10;
      label1.Text = "Tempo de pressionamento (s)";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.BackColor = SystemColors.Info;
      label3.Location = new Point(12, 218);
      label3.Name = "label3";
      label3.Size = new Size(142, 15);
      label3.TabIndex = 12;
      label3.Text = "Caixa de texto para teste: ";
      // 
      // textBox1
      // 
      textBox1.Location = new Point(181, 215);
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(55, 23);
      textBox1.TabIndex = 13;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.MenuBar;
      ClientSize = new Size(266, 279);
      Controls.Add(textBox1);
      Controls.Add(label3);
      Controls.Add(label1);
      Controls.Add(textBoxSignature);
      Controls.Add(buttonStop);
      Controls.Add(buttonRun);
      Controls.Add(comboBoxKeys);
      Controls.Add(checkBoxSpace);
      Controls.Add(checkBoxD);
      Controls.Add(checkBoxS);
      Controls.Add(checkBoxA);
      Controls.Add(checkBoxW);
      Name = "Form1";
      Text = "Random KeyPress";
      Load += Form1_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private CheckBox checkBoxW;
    private CheckBox checkBoxA;
    private CheckBox checkBoxS;
    private CheckBox checkBoxD;
    private CheckBox checkBoxSpace;
    private ComboBox comboBoxKeys;
    private Button buttonRun;
    private Button buttonStop;
    private TextBox textBoxSignature;
    private Label label1;
    private Label label3;
    private TextBox textBox1;
  }
}
