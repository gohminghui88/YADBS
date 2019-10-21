/*
 * Created by SharpDevelop.
 * User: gohmi
 * Date: 29/05/2019
 * Time: 2:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace YADBS
{
	/// <summary>
	/// Description of ConnectForm2.
	/// </summary>
	public partial class ConnectForm2 : Form
	{
		public ConnectForm2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public string connectionName = "";
		public string server = "";
		public string database = "";
		public string port = "";
		public string user = "";
		public string passwords = "";
		
		void Button1Click(object sender, EventArgs e)
		{
			try {
			server = textBox1.Text;
			database = textBox2.Text;
			user = textBox3.Text;
			passwords = textBox4.Text;
			
			port = textBox5.Text;
			connectionName = textBox6.Text;
			
			this.Close();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			try {
			this.Close();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ConnectForm2Load(object sender, EventArgs e)
		{
			try {
			List<string> res = new List<string>();
			StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/connection.ini");
			string line = "";
			
			while((line = sr.ReadLine()) != null) {
				res.Add(line);
			}
			
			sr.Close();
			
			foreach(string r in res) {
				if(r.Contains("[ConnectionName]"))
					listBox1.Items.Add(r);
			}
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			try {
			List<string> res = new List<string>();
			StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/connection.ini");
			string line = "";
			
			while((line = sr.ReadLine()) != null) {
				res.Add(line);
			}
			
			sr.Close();
			
			for(int i = 0; i < res.Count; i++) {
				if(res[i].Contains(listBox1.GetItemText(listBox1.SelectedItem))) {
					textBox6.Text = listBox1.GetItemText(listBox1.SelectedItem).Replace("[ConnectionName]", "");
					textBox1.Text = res[i + 1].Replace("[Server]", "");
					textBox2.Text = res[i + 2].Replace("[Database]", "");
					textBox5.Text = res[i + 3].Replace("[port]", "");
					textBox3.Text = res[i + 4].Replace("[User]", "");
				}
			}
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			try {
			System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "/connection.ini");
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
