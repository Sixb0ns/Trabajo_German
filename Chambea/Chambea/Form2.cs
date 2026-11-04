/*
 * Created by SharpDevelop.
 * User: CC2_PC09
 * Date: 04/11/2026
 * Time: 08:21 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chambea
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
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
			double y=Convert.ToDouble(textBox2.Text);
			double x=y*18.69;
			MessageBox.Show(Convert.ToString(y)+" Dolares a pesos son: "+Convert.ToString(x));
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			double y=Convert.ToDouble(textBox2.Text);
			double x=y/18.69;
			MessageBox.Show(Convert.ToString(y)+" Pesos a Dolares son: "+Convert.ToString(x));			
		}
	}
}
