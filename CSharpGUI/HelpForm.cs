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
	public partial class HelpForm : Form
	{
		private int x;
		private int y;
		private int clicksCount;

		public HelpForm()
		{
			InitializeComponent();

			pictureBox1.Image = Image.FromFile("Resources/treasuremap.jpg");

			Random r = new Random();
			x = r.Next(0, pictureBox1.Width);
			y = r.Next(0, pictureBox1.Height);
		}

		private void close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			clicksCount++;

			var clickedX = (e as MouseEventArgs).X;
			var clickedY = (e as MouseEventArgs).Y;

			var deltaX = Math.Abs(clickedX - x);
			var deltaY = Math.Abs(clickedY - y);

			var delta = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
			gameLabel.Text = $"До клада {delta:N1}м";

			if (delta <= 20)
			{
				gameStatusLabel.Text = $"Победа за {clicksCount} кликов!";
			}
		}
	}
}
