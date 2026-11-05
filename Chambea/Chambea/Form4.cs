/*
 * Created by SharpDevelop.
 * User: LACD1
 * Date: 04/11/2026
 * Time: 09:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chambea
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double X=Convert.ToDouble(textBox1.Text);
			double Y=Convert.ToDouble(textBox2.Text);
			if (X<0&&Y<0)
				MessageBox.Show("Te encuentras en el cuadrante de abajo a la izquierda");
			if (X<0&&Y>0)
				MessageBox.Show("Te encuentras en el cuadrante de arriba a la izquierda");
			if (X>0&&Y<0)
				MessageBox.Show("Te encuentras en el cuadrante de abajo a la derecha");
			if (X>0&&Y>0)
				MessageBox.Show("Te encuentras en el cuadrante de arriba a la derecha");
			if (X==0||Y==0)
				MessageBox.Show("No te encuentras en ningun cuadrante");
		}
	}
}
