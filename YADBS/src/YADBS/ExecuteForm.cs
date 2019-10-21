/*
 * Created by SharpDevelop.
 * User: gohmi
 * Date: 29/05/2019
 * Time: 5:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace YADBS
{
	/// <summary>
	/// Description of ExecuteForm.
	/// </summary>
	public partial class ExecuteForm : Form
	{
		public ExecuteForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public int isInTextBox;
		public string location;
		void Button2Click(object sender, EventArgs e)
		{
			if(radioButton2.Checked) isInTextBox = 1;
			else isInTextBox = 0;
			
			location = textBox1.Text;
			
			this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "SQL files (*.sql)|*.sql";
			
			DialogResult g = ofd.ShowDialog();
			
			if(g == DialogResult.OK) {
				textBox1.Text = ofd.FileName;
			}
		}
	}
}
