namespace CSharpGUI
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.createProductBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cookFoodBtn = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.editFoodBtn = new System.Windows.Forms.Button();
			this.helpBtn = new System.Windows.Forms.Button();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.difficultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// createProductBtn
			// 
			this.createProductBtn.Location = new System.Drawing.Point(276, 17);
			this.createProductBtn.Name = "createProductBtn";
			this.createProductBtn.Size = new System.Drawing.Size(75, 23);
			this.createProductBtn.TabIndex = 1;
			this.createProductBtn.Text = "Создать";
			this.createProductBtn.UseVisualStyleBackColor = true;
			this.createProductBtn.Click += new System.EventHandler(this.createProductBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.label1.Location = new System.Drawing.Point(53, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Продукты";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.helpBtn);
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.cookFoodBtn);
			this.splitContainer1.Panel1.Controls.Add(this.createProductBtn);
			this.splitContainer1.Panel1MinSize = 50;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.editFoodBtn);
			this.splitContainer1.Panel2MinSize = 50;
			this.splitContainer1.Size = new System.Drawing.Size(904, 430);
			this.splitContainer1.SplitterDistance = 450;
			this.splitContainer1.TabIndex = 3;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.productBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 46);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(447, 384);
			this.dataGridView1.TabIndex = 3;
			// 
			// cookFoodBtn
			// 
			this.cookFoodBtn.Location = new System.Drawing.Point(357, 17);
			this.cookFoodBtn.Name = "cookFoodBtn";
			this.cookFoodBtn.Size = new System.Drawing.Size(82, 23);
			this.cookFoodBtn.TabIndex = 1;
			this.cookFoodBtn.Text = "Приготовить";
			this.cookFoodBtn.UseVisualStyleBackColor = true;
			this.cookFoodBtn.Click += new System.EventHandler(this.cookFoodBtn_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.difficultDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.foodBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(3, 46);
			this.dataGridView2.MultiSelect = false;
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(447, 384);
			this.dataGridView2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.label2.Location = new System.Drawing.Point(45, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Блюда";
			// 
			// editFoodBtn
			// 
			this.editFoodBtn.Location = new System.Drawing.Point(346, 17);
			this.editFoodBtn.Name = "editFoodBtn";
			this.editFoodBtn.Size = new System.Drawing.Size(93, 23);
			this.editFoodBtn.TabIndex = 1;
			this.editFoodBtn.Text = "Редактировать";
			this.editFoodBtn.UseVisualStyleBackColor = true;
			this.editFoodBtn.Click += new System.EventHandler(this.editFoodBtn_Click);
			// 
			// helpBtn
			// 
			this.helpBtn.BackColor = System.Drawing.Color.RoyalBlue;
			this.helpBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.helpBtn.Location = new System.Drawing.Point(12, 17);
			this.helpBtn.Margin = new System.Windows.Forms.Padding(0);
			this.helpBtn.Name = "helpBtn";
			this.helpBtn.Size = new System.Drawing.Size(25, 23);
			this.helpBtn.TabIndex = 5;
			this.helpBtn.Text = "?";
			this.helpBtn.UseVisualStyleBackColor = false;
			this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// weightDataGridViewTextBoxColumn
			// 
			this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
			this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
			this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
			this.weightDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// volumeDataGridViewTextBoxColumn
			// 
			this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
			this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
			this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
			this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataSource = typeof(CSharpGUI.Product);
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn1
			// 
			this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
			this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// difficultDataGridViewTextBoxColumn
			// 
			this.difficultDataGridViewTextBoxColumn.DataPropertyName = "Difficult";
			this.difficultDataGridViewTextBoxColumn.HeaderText = "Difficult";
			this.difficultDataGridViewTextBoxColumn.Name = "difficultDataGridViewTextBoxColumn";
			this.difficultDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// foodBindingSource
			// 
			this.foodBindingSource.DataSource = typeof(CSharpGUI.Food);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 430);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Главная";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button createProductBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button cookFoodBtn;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button editFoodBtn;
		private System.Windows.Forms.BindingSource productBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn difficultDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource foodBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button helpBtn;
	}
}

