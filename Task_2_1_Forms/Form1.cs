using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2_1_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int r = 25;
				int x, y;
				x = Convert.ToInt32(textBox1.Text);
				y = Convert.ToInt32(textBox2.Text);

				if (y < 0 && (x * x + y * y) < (r * r) && Math.Abs(x) < Math.Abs(y))
				{
					textBox3.Text = "Точка находится внутри фигуры";
				}
				else if (y > 0 || ((x * x + y * y) > (r * r)) || Math.Abs(x) > Math.Abs(y))
				{
					textBox3.Text = "Точка находится вне фигуры";
				}
				else
				{
					textBox3.Text = "Точка находится на границе";
				}
			}
			catch
			{
				textBox3.Text = string.Format("X и Y должны быть числом");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
		}
	}
}
