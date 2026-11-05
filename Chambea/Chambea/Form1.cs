/*
 * Created by SharpDevelop.
 * User: CC2_PC09
 * Date: 04/11/2026
 * Time: 07:58 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chambea
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PesosADolaresToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form2 f = new Form2();
			f.Show();
			this.Hide();			
		}
		
		void DistanciaEntreDosPuntosToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form3 f = new Form3();
			f.Show();
			this.Hide();			
		}
		
		void EncuentraElCuadranteToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form4 f = new Form4();
			f.Show();
			this.Hide();			
		}
	}
}
