/*
 * Created by SharpDevelop.
 * User: CC2_PC09
 * Date: 04/11/2026
 * Time: 08:32 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chambea
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
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
			double x=Convert.ToDouble(textBox1.Text);
			double y=Convert.ToDouble(textBox2.Text);
			double x2=Convert.ToDouble(textBox3.Text);
			double y2=Convert.ToDouble(textBox4.Text);
			double d=Math.Sqrt(Math.Pow((Math.Pow(x2, 2)-Math.Pow(y, 2)),2)+Math.Pow((Math.Pow(y2, 2)-Math.Pow(y, 2)),2));
			MessageBox.Show("La Distancia Entre Ambos Puntos Es De"+Convert.ToString(d));
		}
	}
}
