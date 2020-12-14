namespace CSharpGUI
{
	partial class HelpForm
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
			this.close = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.gameLabel = new System.Windows.Forms.Label();
			this.gameStatusLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// close
			// 
			this.close.Location = new System.Drawing.Point(538, 490);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(75, 23);
			this.close.TabIndex = 0;
			this.close.Text = "Закрыть";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(18, 168);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(562, 303);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label1.Location = new System.Drawing.Point(26, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Справочная информация";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Создатель: Давыденко Роман";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Платформа: .NET WindowsForms";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(238, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Левое окно - продукты. Правое окно - блюда.";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(26, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(362, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Можно создать продукт, для этого надо нажать на кнопку \"Создать\".";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(26, 61);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(442, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Можно выбрать несколько продуктов и нажать \"Приготовить\", чтобы создать блюдо";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(26, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(389, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Чтобы редактировать блюдо, надо его выбрать и нажать \"Редактировать\"";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label10.Location = new System.Drawing.Point(15, 152);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(315, 13);
			this.label10.TabIndex = 3;
			this.label10.Text = "Мини-игра: Найди клад. Нажми на карту и найди сокровище";
			// 
			// gameLabel
			// 
			this.gameLabel.AutoSize = true;
			this.gameLabel.Location = new System.Drawing.Point(500, 152);
			this.gameLabel.Name = "gameLabel";
			this.gameLabel.Size = new System.Drawing.Size(75, 13);
			this.gameLabel.TabIndex = 4;
			this.gameLabel.Text = "До клада: 2м";
			// 
			// gameStatusLabel
			// 
			this.gameStatusLabel.AutoSize = true;
			this.gameStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.gameStatusLabel.ForeColor = System.Drawing.Color.Green;
			this.gameStatusLabel.Location = new System.Drawing.Point(350, 150);
			this.gameStatusLabel.Name = "gameStatusLabel";
			this.gameStatusLabel.Size = new System.Drawing.Size(0, 15);
			this.gameStatusLabel.TabIndex = 5;
			// 
			// HelpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 525);
			this.Controls.Add(this.gameStatusLabel);
			this.Controls.Add(this.gameLabel);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.close);
			this.Name = "HelpForm";
			this.Text = "Справка";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button close;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label gameLabel;
		private System.Windows.Forms.Label gameStatusLabel;
	}
}