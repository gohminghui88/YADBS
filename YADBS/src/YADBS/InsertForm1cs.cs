/*
 * Created by SharpDevelop.
 * User: gohmi
 * Date: 31/05/2019
 * Time: 6:22 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace YADBS
{
	/// <summary>
	/// Description of InsertForm1cs.
	/// </summary>
	public partial class InsertForm1cs : Form
	{
		public InsertForm1cs()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public string query;
		void Button1Click(object sender, EventArgs e)
		{
			query = "INSERT INTO " + textBox1.Text + "(" + textBox2.Text + ") " + "VALUES(" + textBox3.Text + ");";
			
			
			this.Close();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
