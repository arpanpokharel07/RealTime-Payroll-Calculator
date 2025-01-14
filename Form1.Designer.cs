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
			SuspendLayout();
			// 
			// lblHello
			// 
			lblHello.AutoSize = true;
			lblHello.Location = new Point(123, 67);
			lblHello.Name = "lblHello";
			lblHello.Size = new Size(89, 20);
			lblHello.TabIndex = 0;
			lblHello.Text = "Hello World";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblHello);
			Name = "Form1";
			Text = "Arpan Pokharel";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHello;
	}
}
