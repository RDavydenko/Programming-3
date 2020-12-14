namespace CSharpGUI
{
	partial class FoodForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.nameInput = new System.Windows.Forms.TextBox();
			this.priceInput = new System.Windows.Forms.NumericUpDown();
			this.actionBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.difficultInput = new System.Windows.Forms.NumericUpDown();
			this.statusLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.priceInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.difficultInput)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label1.Location = new System.Drawing.Point(54, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name:";
			// 
			// nameInput
			// 
			this.nameInput.Location = new System.Drawing.Point(142, 42);
			this.nameInput.Name = "nameInput";
			this.nameInput.Size = new System.Drawing.Size(182, 20);
			this.nameInput.TabIndex = 4;
			// 
			// priceInput
			// 
			this.priceInput.Location = new System.Drawing.Point(142, 88);
			this.priceInput.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.priceInput.Name = "priceInput";
			this.priceInput.Size = new System.Drawing.Size(182, 20);
			this.priceInput.TabIndex = 5;
			// 
			// actionBtn
			// 
			this.actionBtn.Location = new System.Drawing.Point(274, 203);
			this.actionBtn.Name = "actionBtn";
			this.actionBtn.Size = new System.Drawing.Size(86, 28);
			this.actionBtn.TabIndex = 6;
			this.actionBtn.Text = "Обновить";
			this.actionBtn.UseVisualStyleBackColor = true;
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(12, 203);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(86, 28);
			this.cancelBtn.TabIndex = 7;
			this.cancelBtn.Text = "Отмена";
			this.cancelBtn.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label2.Location = new System.Drawing.Point(54, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 15);
			this.label2.TabIndex = 8;
			this.label2.Text = "Price:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label3.Location = new System.Drawing.Point(54, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "Difficult:";
			// 
			// difficultInput
			// 
			this.difficultInput.Location = new System.Drawing.Point(142, 135);
			this.difficultInput.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.difficultInput.Name = "difficultInput";
			this.difficultInput.Size = new System.Drawing.Size(182, 20);
			this.difficultInput.TabIndex = 10;
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.statusLabel.Location = new System.Drawing.Point(12, 13);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(0, 13);
			this.statusLabel.TabIndex = 11;
			// 
			// FoodForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 240);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.difficultInput);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.actionBtn);
			this.Controls.Add(this.priceInput);
			this.Controls.Add(this.nameInput);
			this.Controls.Add(this.label1);
			this.Name = "FoodForm";
			this.Text = "Блюдо";
			((System.ComponentModel.ISupportInitialize)(this.priceInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.difficultInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameInput;
		private System.Windows.Forms.NumericUpDown priceInput;
		private System.Windows.Forms.Button actionBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown difficultInput;
		private System.Windows.Forms.Label statusLabel;
	}
}