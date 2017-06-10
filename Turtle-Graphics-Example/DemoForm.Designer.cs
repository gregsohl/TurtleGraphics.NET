namespace Turtle_Graphics_Example
{
	partial class DemoForm
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
			this.buttonDraw = new System.Windows.Forms.Button();
			this.buttonDrawSpiral = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.buttonShowHideTurtle = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.panelSurface = new System.Windows.Forms.Panel();
			this.Coordinates = new System.Windows.Forms.ToolStripStatusLabel();
			this.Angle = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel1.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonDraw
			// 
			this.buttonDraw.Location = new System.Drawing.Point(11, 9);
			this.buttonDraw.Name = "buttonDraw";
			this.buttonDraw.Size = new System.Drawing.Size(78, 35);
			this.buttonDraw.TabIndex = 0;
			this.buttonDraw.Text = "Draw";
			this.buttonDraw.UseVisualStyleBackColor = true;
			this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
			// 
			// buttonDrawSpiral
			// 
			this.buttonDrawSpiral.Location = new System.Drawing.Point(11, 60);
			this.buttonDrawSpiral.Name = "buttonDrawSpiral";
			this.buttonDrawSpiral.Size = new System.Drawing.Size(78, 35);
			this.buttonDrawSpiral.TabIndex = 0;
			this.buttonDrawSpiral.Text = "Spiral";
			this.buttonDrawSpiral.UseVisualStyleBackColor = true;
			this.buttonDrawSpiral.Click += new System.EventHandler(this.buttonDrawSpiral_Click);
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(11, 113);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(78, 35);
			this.buttonReset.TabIndex = 1;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// buttonShowHideTurtle
			// 
			this.buttonShowHideTurtle.Location = new System.Drawing.Point(12, 164);
			this.buttonShowHideTurtle.Name = "buttonShowHideTurtle";
			this.buttonShowHideTurtle.Size = new System.Drawing.Size(78, 34);
			this.buttonShowHideTurtle.TabIndex = 2;
			this.buttonShowHideTurtle.Text = "Hide Turtle";
			this.buttonShowHideTurtle.UseVisualStyleBackColor = true;
			this.buttonShowHideTurtle.Click += new System.EventHandler(this.buttonShowHideTurtle_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonShowHideTurtle);
			this.panel1.Controls.Add(this.buttonReset);
			this.panel1.Controls.Add(this.buttonDraw);
			this.panel1.Controls.Add(this.buttonDrawSpiral);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(101, 720);
			this.panel1.TabIndex = 4;
			// 
			// statusBar
			// 
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Coordinates,
            this.Angle});
			this.statusBar.Location = new System.Drawing.Point(101, 698);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(912, 22);
			this.statusBar.TabIndex = 6;
			this.statusBar.Text = "statusStrip1";
			// 
			// panelSurface
			// 
			this.panelSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelSurface.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelSurface.Location = new System.Drawing.Point(101, 0);
			this.panelSurface.Name = "panelSurface";
			this.panelSurface.Size = new System.Drawing.Size(912, 698);
			this.panelSurface.TabIndex = 7;
			// 
			// Coordinates
			// 
			this.Coordinates.Name = "Coordinates";
			this.Coordinates.Size = new System.Drawing.Size(109, 17);
			this.Coordinates.Text = "toolStripStatusLabel1";
			// 
			// Angle
			// 
			this.Angle.Name = "Angle";
			this.Angle.Size = new System.Drawing.Size(109, 17);
			this.Angle.Text = "toolStripStatusLabel2";
			// 
			// DemoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1013, 720);
			this.Controls.Add(this.panelSurface);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.panel1);
			this.Name = "DemoForm";
			this.Text = "Nakov.TurtleGraphics - Demo";
			this.Load += new System.EventHandler(this.DemoForm_Load);
			this.panel1.ResumeLayout(false);
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonDraw;
		private System.Windows.Forms.Button buttonDrawSpiral;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.Button buttonShowHideTurtle;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel Coordinates;
		private System.Windows.Forms.ToolStripStatusLabel Angle;
		private System.Windows.Forms.Panel panelSurface;
	}
}