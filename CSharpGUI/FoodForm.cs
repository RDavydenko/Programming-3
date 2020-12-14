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
	public partial class FoodForm : Form
	{
		public Food Food { get; }

		public FoodForm(Food food, bool isInitial = false)
		{
			InitializeComponent();

			if (isInitial)
			{
				statusLabel.Text = "Вы можете выбрать собственное название для созданного блюда";
				actionBtn.Text = "Сохранить";
			}

			nameInput.Text = food.Name;
			priceInput.Value = (int)food.Price;
			difficultInput.Value = food.Difficult;

			actionBtn.Click += ActionBtn_Click;
			cancelBtn.Click += CancelBtn_Click;

			Food = food;
		}
		private void ActionBtn_Click(object sender, EventArgs e)
		{
			var f = Form1.Foods.First(x => x.Id == Food.Id);
			var index = Form1.Foods.IndexOf(f);

			Food.Name = nameInput.Text;
			Food.Price = (double)priceInput.Value;
			Food.Difficult = (int)difficultInput.Value;

			Form1.Foods[index] = Food;

			Close();
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
