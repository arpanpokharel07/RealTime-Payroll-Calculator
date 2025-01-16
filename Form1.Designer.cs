namespace RealTIme_Payroll_Calculator
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
			lblHello = new Label();
			lblProvince = new Label();
			cbProvince = new ComboBox();
			pictureBox1 = new PictureBox();
			cbFrequency = new ComboBox();
			lblFrequency = new Label();
			lblHrsPWeek = new Label();
			txtHours = new TextBox();
			txtRate = new TextBox();
			lblPayRate = new Label();
			btnCalculate = new Button();
			pbSalary = new ProgressBar();
			lblSalary = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// lblHello
			// 
			lblHello.Location = new Point(0, 0);
			lblHello.Name = "lblHello";
			lblHello.Size = new Size(100, 23);
			lblHello.TabIndex = 0;
			// 
			// lblProvince
			// 
			lblProvince.AutoSize = true;
			lblProvince.Location = new Point(50, 46);
			lblProvince.Name = "lblProvince";
			lblProvince.Size = new Size(116, 20);
			lblProvince.TabIndex = 1;
			lblProvince.Text = "Select Province: ";
			// 
			// cbProvince
			// 
			cbProvince.FlatStyle = FlatStyle.Flat;
			cbProvince.FormattingEnabled = true;
			cbProvince.Items.AddRange(new object[] { "Select one", "Alberta", "Ontario", "British Columbia" });
			cbProvince.Location = new Point(50, 78);
			cbProvince.Name = "cbProvince";
			cbProvince.Size = new Size(151, 28);
			cbProvince.TabIndex = 2;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = SystemColors.ActiveCaptionText;
			pictureBox1.Location = new Point(277, 22);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(471, 154);
			pictureBox1.TabIndex = 3;
			pictureBox1.TabStop = false;
			// 
			// cbFrequency
			// 
			cbFrequency.FlatStyle = FlatStyle.Flat;
			cbFrequency.FormattingEnabled = true;
			cbFrequency.Items.AddRange(new object[] { "Select one", "Annual", "Semi-Annual", "Monthly", "Bi-weekly", "Weekly" });
			cbFrequency.Location = new Point(50, 173);
			cbFrequency.Name = "cbFrequency";
			cbFrequency.Size = new Size(151, 28);
			cbFrequency.TabIndex = 5;
			// 
			// lblFrequency
			// 
			lblFrequency.AutoSize = true;
			lblFrequency.Location = new Point(50, 141);
			lblFrequency.Name = "lblFrequency";
			lblFrequency.Size = new Size(207, 20);
			lblFrequency.TabIndex = 4;
			lblFrequency.Text = "What would be my __ Salary?";
			// 
			// lblHrsPWeek
			// 
			lblHrsPWeek.AutoSize = true;
			lblHrsPWeek.Location = new Point(50, 239);
			lblHrsPWeek.Name = "lblHrsPWeek";
			lblHrsPWeek.Size = new Size(97, 20);
			lblHrsPWeek.TabIndex = 6;
			lblHrsPWeek.Text = "Hrs per Week";
			// 
			// txtHours
			// 
			txtHours.Location = new Point(153, 236);
			txtHours.Name = "txtHours";
			txtHours.Size = new Size(125, 27);
			txtHours.TabIndex = 7;
			// 
			// txtRate
			// 
			txtRate.Location = new Point(153, 288);
			txtRate.Name = "txtRate";
			txtRate.Size = new Size(125, 27);
			txtRate.TabIndex = 9;
			// 
			// lblPayRate
			// 
			lblPayRate.AutoSize = true;
			lblPayRate.Location = new Point(63, 295);
			lblPayRate.Name = "lblPayRate";
			lblPayRate.Size = new Size(72, 20);
			lblPayRate.TabIndex = 8;
			lblPayRate.Text = "Pay Rate: ";
			// 
			// btnCalculate
			// 
			btnCalculate.Location = new Point(107, 363);
			btnCalculate.Name = "btnCalculate";
			btnCalculate.Size = new Size(94, 29);
			btnCalculate.TabIndex = 10;
			btnCalculate.Text = "Calculate";
			btnCalculate.UseVisualStyleBackColor = true;
			btnCalculate.Click += btnCalculate_Click;
			// 
			// pbSalary
			// 
			pbSalary.ForeColor = Color.Salmon;
			pbSalary.Location = new Point(369, 363);
			pbSalary.Name = "pbSalary";
			pbSalary.Size = new Size(419, 29);
			pbSalary.TabIndex = 11;
			// 
			// lblSalary
			// 
			lblSalary.AutoSize = true;
			lblSalary.Location = new Point(435, 206);
			lblSalary.Name = "lblSalary";
			lblSalary.Size = new Size(0, 20);
			lblSalary.TabIndex = 12;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblSalary);
			Controls.Add(pbSalary);
			Controls.Add(btnCalculate);
			Controls.Add(txtRate);
			Controls.Add(lblPayRate);
			Controls.Add(txtHours);
			Controls.Add(lblHrsPWeek);
			Controls.Add(cbFrequency);
			Controls.Add(lblFrequency);
			Controls.Add(pictureBox1);
			Controls.Add(cbProvince);
			Controls.Add(lblProvince);
			Controls.Add(lblHello);
			Name = "Form1";
			Text = "Arpan Pokharel";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHello;
		private Label lblProvince;
		private ComboBox cbProvince;
		private PictureBox pictureBox1;
		private ComboBox cbFrequency;
		private Label lblFrequency;
		private Label lblHrsPWeek;
		private TextBox txtHours;
		private TextBox txtRate;
		private Label lblPayRate;
		private Button btnCalculate;
		private ProgressBar pbSalary;
		private Label lblSalary;
	}
}
