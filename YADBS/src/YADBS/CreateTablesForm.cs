/*
 * Created by SharpDevelop.
 * User: gohmi
 * Date: 01/06/2019
 * Time: 1:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace YADBS
{
	/// <summary>
	/// Description of CreateTablesForm.
	/// </summary>
	public partial class CreateTablesForm : Form
	{
		public CreateTablesForm()
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
			richTextBox1.Text += "\n" + textBox2.Text + "\t" + textBox3.Text;
			
			if(checkBox1.Checked) {
				richTextBox1.Text = richTextBox1.Text + "\t" + "PRIMARY KEY";
			}
			
			if(checkBox2.Checked) {
				richTextBox1.Text = richTextBox1.Text + "\t" + "NOT NULL";
			}
			
			if(checkBox3.Checked) {
				richTextBox1.Text = richTextBox1.Text + "\t" + "UNIQUE";
			}
			
			richTextBox1.Text += ",";
		}
		
		
		void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
	
		}
		
		public string query;
		void Button2Click(object sender, EventArgs e)
		{
			query = "CREATE TABLE " + textBox1.Text + "\n(" + richTextBox1.Text.Remove(richTextBox1.Text.Trim().Length) + "\n);";
			
			this.Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
