/*
 * Created by SharpDevelop.
 * User: CC2_PC09
 * Date: 04/11/2026
 * Time: 07:58 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Chambea
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.pesosADolaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.distanciaEntreDosPuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encuentraElCuadranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(410, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menu Principal";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(103, 74);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(205, 175);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.pesosADolaresToolStripMenuItem,
									this.distanciaEntreDosPuntosToolStripMenuItem,
									this.encuentraElCuadranteToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(410, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// pesosADolaresToolStripMenuItem
			// 
			this.pesosADolaresToolStripMenuItem.Name = "pesosADolaresToolStripMenuItem";
			this.pesosADolaresToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
			this.pesosADolaresToolStripMenuItem.Text = "&Pesos A Dolares";
			// 
			// distanciaEntreDosPuntosToolStripMenuItem
			// 
			this.distanciaEntreDosPuntosToolStripMenuItem.Name = "distanciaEntreDosPuntosToolStripMenuItem";
			this.distanciaEntreDosPuntosToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
			this.distanciaEntreDosPuntosToolStripMenuItem.Text = "&Distancia Entre Dos Puntos";
			// 
			// encuentraElCuadranteToolStripMenuItem
			// 
			this.encuentraElCuadranteToolStripMenuItem.Name = "encuentraElCuadranteToolStripMenuItem";
			this.encuentraElCuadranteToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
			this.encuentraElCuadranteToolStripMenuItem.Text = "&Encuentra El Cuadrante";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 261);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem encuentraElCuadranteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem distanciaEntreDosPuntosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pesosADolaresToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
