using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpGUI
{
	public partial class ProductForm : Form
	{
		public ProductForm(ProductFormType type)
		{
			InitializeComponent();

			if (type == ProductFormType.Create)
			{
				actionBtn.Text = "Создать";
				actionBtn.Click += CreateBtn_Click;
			}
			else if (type == ProductFormType.Edit)
			{
				actionBtn.Text = "Обновить";
				actionBtn.Click += EditBtn_Click;
			}

			cancelBtn.Click += CancelBtn_Click;
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CreateBtn_Click(object sender, EventArgs e)
		{
			Product product = new Product(
				nameInput.Text,
				(double)weightInput.Value,
				(double)volumeInput.Value,
				(double)priceInput.Value
			)
			{ Id = Form1.NextProductId };
			Form1.Products.Add(product);

			Close();
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}
