namespace CSharpGUI
{
	partial class ProductForm
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
			this.actionBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.weightInput = new System.Windows.Forms.NumericUpDown();
			this.nameInput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.volumeInput = new System.Windows.Forms.NumericUpDown();
			this.priceInput = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.cancelBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.weightInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.volumeInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.priceInput)).BeginInit();
			this.SuspendLayout();
			// 
			// actionBtn
			// 
			this.actionBtn.Location = new System.Drawing.Point(262, 197);
			this.actionBtn.Name = "actionBtn";
			this.actionBtn.Size = new System.Drawing.Size(86, 28);
			this.actionBtn.TabIndex = 0;
			this.actionBtn.Text = "Создать";
			this.actionBtn.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label1.Location = new System.Drawing.Point(58, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name:";
			// 
			// weightInput
			// 
			this.weightInput.Location = new System.Drawing.Point(132, 79);
			this.weightInput.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.weightInput.Name = "weightInput";
			this.weightInput.Size = new System.Drawing.Size(182, 20);
			this.weightInput.TabIndex = 2;
			// 
			// nameInput
			// 
			this.nameInput.Location = new System.Drawing.Point(132, 39);
			this.nameInput.Name = "nameInput";
			this.nameInput.Size = new System.Drawing.Size(182, 20);
			this.nameInput.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label2.Location = new System.Drawing.Point(58, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Weight:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label3.Location = new System.Drawing.Point(58, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Volume:";
			// 
			// volumeInput
			// 
			this.volumeInput.Location = new System.Drawing.Point(132, 119);
			this.volumeInput.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.volumeInput.Name = "volumeInput";
			this.volumeInput.Size = new System.Drawing.Size(182, 20);
			this.volumeInput.TabIndex = 6;
			// 
			// priceInput
			// 
			this.priceInput.Location = new System.Drawing.Point(132, 162);
			this.priceInput.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.priceInput.Name = "priceInput";
			this.priceInput.Size = new System.Drawing.Size(182, 20);
			this.priceInput.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label4.Location = new System.Drawing.Point(58, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Price:";
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(16, 197);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(86, 28);
			this.cancelBtn.TabIndex = 9;
			this.cancelBtn.Text = "Отмена";
			this.cancelBtn.UseVisualStyleBackColor = true;
			// 
			// ProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 238);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.priceInput);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.volumeInput);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nameInput);
			this.Controls.Add(this.weightInput);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.actionBtn);
			this.Name = "ProductForm";
			this.Text = "Продукт";
			((System.ComponentModel.ISupportInitialize)(this.weightInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.volumeInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.priceInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button actionBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown weightInput;
		private System.Windows.Forms.TextBox nameInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown volumeInput;
		private System.Windows.Forms.NumericUpDown priceInput;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button cancelBtn;
	}
}