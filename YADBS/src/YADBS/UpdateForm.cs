/*
 * Created by SharpDevelop.
 * User: gohmi
 * Date: 01/06/2019
 * Time: 12:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace YADBS
{
	/// <summary>
	/// Description of UpdateForm.
	/// </summary>
	public partial class UpdateForm : Form
	{
		public UpdateForm()
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
			textBox4.Text += textBox2.Text + "=" + textBox3.Text + ", ";
		}
		
		public string query;
		void Button2Click(object sender, EventArgs e)
		{
			query += "update " + textBox1.Text + " set " + textBox4.Text.Remove(textBox4.Text.Trim().Length - 1) + " where " + textBox5.Text + ";";
			this.Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
