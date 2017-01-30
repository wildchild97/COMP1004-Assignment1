namespace COMP1004_Assignment1
{
    partial class SalesBonus
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.SalesTextBox = new System.Windows.Forms.TextBox();
            this.BonusLabel = new System.Windows.Forms.Label();
            this.BonusTextBox = new System.Windows.Forms.TextBox();
            this.LanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.SpanishRadioButton = new System.Windows.Forms.RadioButton();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.LanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(6, 153);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(129, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Employee Name:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(6, 188);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(104, 20);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "Employee ID:";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLabel.Location = new System.Drawing.Point(8, 239);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(154, 20);
            this.HoursLabel.TabIndex = 2;
            this.HoursLabel.Text = "Total Hours Worked:";
            // 
            // SalesLabel
            // 
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLabel.Location = new System.Drawing.Point(8, 268);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(151, 20);
            this.SalesLabel.TabIndex = 3;
            this.SalesLabel.Text = "Total Monthly Sales:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(213, 153);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(174, 26);
            this.NameTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(213, 185);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(174, 26);
            this.IdTextBox.TabIndex = 5;
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursTextBox.Location = new System.Drawing.Point(213, 233);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(150, 26);
            this.HoursTextBox.TabIndex = 6;
            this.HoursTextBox.TextChanged += new System.EventHandler(this.HoursTextBox_TextChanged);
            // 
            // SalesTextBox
            // 
            this.SalesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTextBox.Location = new System.Drawing.Point(213, 268);
            this.SalesTextBox.Name = "SalesTextBox";
            this.SalesTextBox.Size = new System.Drawing.Size(150, 26);
            this.SalesTextBox.TabIndex = 7;
            this.SalesTextBox.TextChanged += new System.EventHandler(this.SalesTextBox_TextChanged);
            // 
            // BonusLabel
            // 
            this.BonusLabel.AutoSize = true;
            this.BonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonusLabel.Location = new System.Drawing.Point(8, 326);
            this.BonusLabel.Name = "BonusLabel";
            this.BonusLabel.Size = new System.Drawing.Size(120, 20);
            this.BonusLabel.TabIndex = 8;
            this.BonusLabel.Text = "Sales Bonus :";
            // 
            // BonusTextBox
            // 
            this.BonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonusTextBox.Location = new System.Drawing.Point(213, 326);
            this.BonusTextBox.Name = "BonusTextBox";
            this.BonusTextBox.ReadOnly = true;
            this.BonusTextBox.Size = new System.Drawing.Size(150, 26);
            this.BonusTextBox.TabIndex = 9;
            // 
            // LanguageGroupBox
            // 
            this.LanguageGroupBox.Controls.Add(this.SpanishRadioButton);
            this.LanguageGroupBox.Controls.Add(this.FrenchRadioButton);
            this.LanguageGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguageGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageGroupBox.Location = new System.Drawing.Point(12, 12);
            this.LanguageGroupBox.Name = "LanguageGroupBox";
            this.LanguageGroupBox.Size = new System.Drawing.Size(138, 120);
            this.LanguageGroupBox.TabIndex = 10;
            this.LanguageGroupBox.TabStop = false;
            this.LanguageGroupBox.Text = "Language";
            // 
            // SpanishRadioButton
            // 
            this.SpanishRadioButton.AutoSize = true;
            this.SpanishRadioButton.Location = new System.Drawing.Point(6, 89);
            this.SpanishRadioButton.Name = "SpanishRadioButton";
            this.SpanishRadioButton.Size = new System.Drawing.Size(85, 24);
            this.SpanishRadioButton.TabIndex = 2;
            this.SpanishRadioButton.TabStop = true;
            this.SpanishRadioButton.Text = "Español";
            this.SpanishRadioButton.UseVisualStyleBackColor = true;
            this.SpanishRadioButton.CheckedChanged += new System.EventHandler(this.SpanishRadioButton_CheckedChanged);
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Location = new System.Drawing.Point(6, 59);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(88, 24);
            this.FrenchRadioButton.TabIndex = 1;
            this.FrenchRadioButton.Text = "Français";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this.FrenchRadioButton_CheckedChanged);
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(6, 29);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(79, 24);
            this.EnglishRadioButton.TabIndex = 0;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.EnglishRadioButton_CheckedChanged);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::COMP1004_Assignment1.Properties.Resources.logo;
            this.LogoPictureBox.Location = new System.Drawing.Point(212, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(175, 125);
            this.LogoPictureBox.TabIndex = 11;
            this.LogoPictureBox.TabStop = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(13, 394);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(102, 35);
            this.CalculateButton.TabIndex = 12;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(144, 394);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(102, 35);
            this.NextButton.TabIndex = 13;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(270, 394);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(102, 35);
            this.PrintButton.TabIndex = 14;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // SalesBonus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(399, 441);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.LanguageGroupBox);
            this.Controls.Add(this.BonusTextBox);
            this.Controls.Add(this.BonusLabel);
            this.Controls.Add(this.SalesTextBox);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SalesLabel);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.NameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesBonus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";
            this.LanguageGroupBox.ResumeLayout(false);
            this.LanguageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label SalesLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.TextBox SalesTextBox;
        private System.Windows.Forms.Label BonusLabel;
        private System.Windows.Forms.TextBox BonusTextBox;
        private System.Windows.Forms.GroupBox LanguageGroupBox;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.RadioButton SpanishRadioButton;
    }
}

