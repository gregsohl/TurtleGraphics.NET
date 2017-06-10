#region Namespaces

using System;
using System.Drawing;
using System.Windows.Forms;

using Nakov.TurtleGraphics;

#endregion Namespaces

namespace Turtle_Graphics_Example
{
	public partial class DemoForm : Form
	{
		public DemoForm()
		{
			InitializeComponent();
		}

		private void buttonDraw_Click(object sender, EventArgs e)
		{
			// Assign a delay to visualize the drawing process
			Turtle.Delay = 150;

			// Draw a equilateral triangle
			Turtle.PenColor = Color.Green;
			Turtle.Rotate(30);
			Turtle.Forward(200);
			Turtle.Rotate(120);
			Turtle.Forward(200);
			Turtle.Rotate(120);
			Turtle.Forward(200);

			// Draw a line in the triangle
			Turtle.Rotate(-30);
			Turtle.PenUp();
			Turtle.Backward(50);
			Turtle.PenDown();
			Turtle.PenColor = Color.Red;
			Turtle.PenSize = 5;
			Turtle.Backward(100);
			Turtle.PenColor = Turtle.DEFAULT_COLOR;
			Turtle.PenSize = Turtle.DEFAULT_PEN_SIZE;
			Turtle.PenUp();
			Turtle.Forward(150);
			Turtle.PenDown();
			Turtle.Rotate(30);
		}

		private void buttonDrawSpiral_Click(object sender, EventArgs e)
		{
			Turtle.PenColor = Color.Red;
			Turtle.Delay = 50;
			for (int i = 0; i < 25; i++)
			{
				Turtle.Forward(i * 5);
				Turtle.Rotate(30 + i);
			}
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			Turtle.Reset();
		}

		private void buttonShowHideTurtle_Click(object sender, EventArgs e)
		{
			Turtle.ShowTurtle = !Turtle.ShowTurtle;

			if (Turtle.ShowTurtle)
			{
				buttonShowHideTurtle.Text = "Show Turtle";
			}
			else
			{
				buttonShowHideTurtle.Text = "Hide Turtle";
			}
		}

		private void DemoForm_Load(object sender, EventArgs e)
		{
			Turtle.Init(panelSurface);
		}
	}
}
