/*
 * Created by SharpDevelop.
 * User: gohmi
 * Date: 29/05/2019
 * Time: 9:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace YADBS
{
	/// <summary>
	/// Description of CSVForm.
	/// </summary>
	public partial class CSVForm : Form
	{
		public CSVForm()
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
			try {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "CSV files (*.csv)|*.csv";
			
			if(ofd.ShowDialog() == DialogResult.OK) {
				textBox1.Text = ofd.FileName;
			}
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		List<string> variables = new List<string>();
		List<List<string>> rows = new List<List<string>>();
		void Button4Click(object sender, EventArgs e)
		{
			try {
				
			TextFieldParser csv = new TextFieldParser(textBox1.Text);
			csv.CommentTokens = new string[] { "#" };
			csv.SetDelimiters(new string[] { "," });
			csv.HasFieldsEnclosedInQuotes = true;
			
			List<List<string>> rs = new List<List<string>>();
			
			
			while(!csv.EndOfData) {
				string[] fields = csv.ReadFields();
				
				List<String> d = new List<string>();
				foreach(string s in fields) {
					d.Add(s);
				}
				rs.Add(d);
			}
			
			variables = rs[0];
			rs.RemoveAt(0);
			rows = rs;
			
			richTextBox1.Clear();
			
			if(checkBox1.Checked) {
			string tableScri = "CREATE TABLE " + textBox2.Text + "(";
			
			int u = 0;
			foreach(string v in variables) {
				if(u == variables.Count - 1)
					tableScri += "\n" + v + "\t" + "varchar(255) ";
				else tableScri += "\n" + v + "\t" + "varchar(255), ";
				u++;
			}
			
			tableScri += ");\n";
			
			richTextBox1.Text += tableScri;
			}
			
			
			foreach(List<string> row in rows) {
				
				int i = 0;
				string f = "";
				foreach(string col in row) {
					
					if(i > 0) f += ",\'" + col + "\'";
					else f = "\'" + col + "\'";
					
					i++;
				}
				
				string q = "INSERT INTO " + textBox2.Text + " VALUES (" + f + ");";
				richTextBox1.Text = richTextBox1.Text + "\n" + q;
			}
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			
		}
		void RichTextBox1TextChanged(object sender, EventArgs e)
		{
			try {
			string keywords = @"\b(select|select distinct|where|and|or|not|order by|insert into|update|delete|min|max|count|avg|sum|like|in|between|join|inner join|left join|right join|full join|self join|union|group by|having|SELECT|SELECT DISTINCT|WHERE|AND|OR|NOT|ORDER BY|INSERT INTO|UPDATE|DELETE|MIN|MAX|COUNT|AVG|SUM|LIKE|IN|BETWEEN|JOIN|INNER JOIN|LEFT JOIN|RIGHT JOIN|FULL JOIN|SELF JOIN|UNION|GROUP BY|HAVING)\b";
			MatchCollection keywordMatches = Regex.Matches(richTextBox1.Text, keywords);
			
			int originalIndex = richTextBox1.SelectionStart;
			int originalLength = richTextBox1.SelectionLength;
			Color originalColor = Color.Black;
			
			richTextBox1.SelectionStart = 0;
			richTextBox1.SelectionLength = richTextBox1.Text.Length;
			richTextBox1.SelectionColor = originalColor;
			
    		int StartCursorPosition = richTextBox1.SelectionStart;
    		foreach (Match m in keywordMatches)
    		{
    			richTextBox1.SelectionStart = m.Index;
    			richTextBox1.SelectionLength = m.Length;
    			richTextBox1.SelectionColor = Color.Blue;
    		}
    		
    		richTextBox1.SelectionStart = originalIndex;
    		richTextBox1.SelectionLength = originalLength;
    		richTextBox1.SelectionColor = originalColor;
    		
    		richTextBox1.Focus();
    		
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		public string query = "";
		void Button2Click(object sender, EventArgs e)
		{
			try {
			query = richTextBox1.Text;
			
			this.Close();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			try {
			this.Close();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
