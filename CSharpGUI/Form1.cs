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
	public partial class Form1 : Form
	{
		private static int _nextProductId;
		private static int _nextFoodId;

		public static BindingList<Product> Products { get; set; }
		public static BindingList<Food> Foods { get; set; }

		public static int NextProductId
		{
			get
			{
				_nextProductId++;
				return _nextProductId - 1;
			}
		}

		public static int NextFoodId
		{
			get
			{
				_nextFoodId++;
				return _nextFoodId - 1;
			}
		}


		public Form1()
		{
			InitializeComponent();
			Foods = new BindingList<Food>()
			{
				new Food("Бутерброд") {Id = 0 },
				new Food("Яичница") {Id = 1 },
				new Food("Каша") {Id = 2 },
				new Food("Салат") {Id = 3 },
			};
			_nextFoodId = Foods.Max(x => x.Id) + 1;

			Products = new BindingList<Product>()
			{
				new Product("Хлеб") {Id = 0 },
				new Product("Колбаса") {Id = 1 },
				new Product("Сыр") {Id = 2 },
				new Product("Масло") {Id = 3 },
				new Product("Яйца") {Id = 4 },
				new Product("Кипяток") {Id = 5 },
				new Product("Молоко") {Id = 6 },
			};
			_nextFoodId = Products.Max(x => x.Id) + 1;

			Load += LoadTables;
		}

		private void LoadTables(object sender, EventArgs e)
		{
			dataGridView1.DataSource = Products;
			dataGridView2.DataSource = Foods;
			dataGridView1.SelectionChanged += ProuductsGrid_SelectionChanged;
			dataGridView2.SelectionChanged += FoodsGrid_SelectionChanged;
		}

		private void ProuductsGrid_SelectionChanged(object sender, EventArgs e)
		{
			var count = (sender as DataGridView).SelectedRows.Count;
			if (count > 0)
			{
				cookFoodBtn.Enabled = true;
			}
			else
			{
				cookFoodBtn.Enabled = false;
			}
		}

		private void FoodsGrid_SelectionChanged(object sender, EventArgs e)
		{
			var count = (sender as DataGridView).SelectedRows.Count;
			if (count == 1)
			{
				editFoodBtn.Enabled = true;
			}
			else
			{
				editFoodBtn.Enabled = false;
			}
		}

		private void createProductBtn_Click(object sender, EventArgs e)
		{
			ProductForm createForm = new ProductForm(ProductFormType.Create);
			createForm.ShowDialog();
		}

		private void cookFoodBtn_Click(object sender, EventArgs e)
		{
			List<Product> selected = new List<Product>();
			for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
			{
				var id = ((Product)dataGridView1.SelectedRows[i].DataBoundItem).Id;
				selected.Add(Products.FirstOrDefault(x => x.Id == id));
			}

			Food food = new Food("Без имени", selected.ToArray());
			food.Id = NextFoodId;
			Foods.Add(food);
			EditFood(food, true);
		}

		private void editFoodBtn_Click(object sender, EventArgs e)
		{
			var selected = (Food)dataGridView2.SelectedRows[0].DataBoundItem;
			EditFood(selected, false);
		}

		private void EditFood(Food f, bool isInitial = false)
		{
			FoodForm form = new FoodForm(f, isInitial);
			form.ShowDialog();
		}

		private void helpBtn_Click(object sender, EventArgs e)
		{
			HelpForm h = new HelpForm();
			h.ShowDialog();
		}
	}

	public enum ProductFormType
	{
		Create,
		Edit
	}
}
