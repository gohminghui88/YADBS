/*
 * Created by SharpDevelop.
 * User: gohmi
 * Date: 28/05/2019
 * Time: 3:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace YADBS
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		//Reference: http://solibnis.blogspot.com/2013/02/connecting-mysql-table-to-datagridview.html
	
		void ToolStripLabel5Click(object sender, EventArgs e)
		{
			mySqlDataAdapter = new MySqlDataAdapter(richTextBox1.Text, conn);
			DataSet DS = new DataSet(); 
			mySqlDataAdapter.Fill(DS); 
			dataGridView1.DataSource = DS.Tables[0];
		}
		
		private string server;
		private string database;
		private string user;
		private string passwords;
		private string port;
		private MySqlConnection conn;
		void ToolStripButton3Click(object sender, EventArgs e)
		{
			try {
				
			
			ConnectForm2 conf = new ConnectForm2();
			conf.ShowDialog();
			
			server = conf.server;
			database = conf.database;
			user = conf.user;
			passwords = conf.passwords;
			port = conf.port;
			
			string connectionString;
			connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";PORT=" + port + ";"+ "UID=" + user + ";" + "PASSWORD=" + passwords + ";";
			
			conn = new MySqlConnection(connectionString);
			
			conn.Open();
			
			MySqlCommand command = conn.CreateCommand();
			command.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES where TABLE_TYPE=\'BASE TABLE\' and TABLE_SCHEMA=\'" + database + "\'";
			
			MySqlDataReader reader = command.ExecuteReader();
			
			listBox1.Items.Clear();
			while(reader.Read()) {
				listBox1.Items.Add(reader.GetString("table_name"));
			}
			reader.Close();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ToolStripButton4Click(object sender, EventArgs e)
		{
			try {
			conn.Close();
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		private MySqlDataAdapter mySqlDataAdapter;
		void ToolStripButton5Click(object sender, EventArgs e)
		{
			try {
			mySqlDataAdapter = new MySqlDataAdapter(richTextBox1.Text, conn);
        	DataSet DS = new DataSet();
        	mySqlDataAdapter.Fill(DS);
        	dataGridView1.DataSource = DS.Tables[0];
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ToolStripButton6Click(object sender, EventArgs e)
		{
			try {
				
				ExecuteForm ef = new ExecuteForm();
				ef.ShowDialog();
				
				if(ef.isInTextBox == 1) {
					MySqlScript script = new MySqlScript(conn, richTextBox1.Text);
					script.Delimiter = ";";
					script.Execute();
				}
				
				else {
					MySqlScript script = new MySqlScript(conn, File.ReadAllText(ef.location));
            		script.Execute();
				}
				
				MessageBox.Show("Completed. ");
				
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		
		
		
		void NewToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			richTextBox1.Text = "";
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			string filepath = "";
			
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "SQL files (*.sql)|*.sql";
			
			if(ofd.ShowDialog() == DialogResult.OK) {
				filepath = ofd.FileName;
			}
			
			StreamReader sr = new StreamReader(filepath);
			string line = "";
			int u = 0;
			while((line = sr.ReadLine()) != null) {
				if(u == 0) richTextBox1.Text += line;
				else richTextBox1.Text += "\n" + line;
				u++;
			}
			sr.Close();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			string filePath = "";
			
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "SQL Files | *.sql";
			if(sfd.ShowDialog() == DialogResult.OK) {
				filePath = sfd.FileName;
			}
			
			
			StreamWriter s = new StreamWriter(filePath);
			string[] con = richTextBox1.Text.Split('\n');
			
			foreach(string c in con) {
				s.WriteLine(c);
			}
			s.Close();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void SaveAsToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			string filePath = "";
			
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "SQL Files | *.sql";
			if(sfd.ShowDialog() == DialogResult.OK) {
				filePath = sfd.FileName;
			}
			
			
			StreamWriter s = new StreamWriter(filePath);
			string[] con = richTextBox1.Text.Split('\n');
			
			foreach(string c in con) {
				s.WriteLine(c);
			}
			s.Close();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			this.Close();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void UndoToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			richTextBox1.Undo();
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void RedoToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			richTextBox1.Redo();
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void CutToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			richTextBox1.Cut();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void CopyToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			richTextBox1.Copy();
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void PasteToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			richTextBox1.Paste();
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void NewDatabaseConnectionToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			ConnectForm con = new ConnectForm();
			con.ShowDialog();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ConnectToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			ConnectForm2 conf = new ConnectForm2();
			conf.ShowDialog();
			
			server = conf.server;
			database = conf.database;
			user = conf.user;
			passwords = conf.passwords;
			port = conf.port;
			
			string connectionString;
			connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";PORT=" + port + ";"+ "UID=" + user + ";" + "PASSWORD=" + passwords + ";";
			
			conn = new MySqlConnection(connectionString);
			
			conn.Open();
			
			MySqlCommand command = conn.CreateCommand();
			command.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES where TABLE_TYPE=\'BASE TABLE\' and TABLE_SCHEMA=\'" + database + "\'";
			
			MySqlDataReader reader = command.ExecuteReader();
			
			listBox1.Items.Clear();
			while(reader.Read()) {
				listBox1.Items.Add(reader.GetString("table_name"));
			}
			reader.Close();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void DisconnectToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			conn.Close();
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void RunToolStripMenuItem1Click(object sender, EventArgs e)
		{
			try {
			mySqlDataAdapter = new MySqlDataAdapter(richTextBox1.Text, conn);
        	DataSet DS = new DataSet();
        	mySqlDataAdapter.Fill(DS);
        	dataGridView1.DataSource = DS.Tables[0];
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ExecuteScriptToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
				
				ExecuteForm ef = new ExecuteForm();
				ef.ShowDialog();
				
				if(ef.isInTextBox == 1) {
					MySqlScript script = new MySqlScript(conn, richTextBox1.Text);
					script.Delimiter = ";";
					script.Execute();
				}
				
				else {
					MySqlScript script = new MySqlScript(conn, File.ReadAllText(ef.location));
            		script.Execute();
				}
				
				MessageBox.Show("Completed. ");
				
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void MySQLShellToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			List<string> res = new List<string>();
			StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/options.ini");
			string line = "";
			int k = 0;
			while((line = sr.ReadLine()) != null) {
				res.Add(line);
			}
			
			System.Diagnostics.Process.Start(res[0].Replace("[mysql shell]", ""));
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void MySQLWorkbenchToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			List<string> res = new List<string>();
			StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/options.ini");
			string line = "";
			int k = 0;
			while((line = sr.ReadLine()) != null) {
				res.Add(line);
			}
			
			System.Diagnostics.Process.Start(res[1].Replace("[mysql workbench]", ""));
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			AboutForm s = new AboutForm();
			s.ShowDialog();
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ToolStripButton7Click(object sender, EventArgs e)
		{
			try {
			richTextBox1.Undo();
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ToolStripButton8Click(object sender, EventArgs e)
		{
			try {
			richTextBox1.Redo();
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ToolStripButton11Click(object sender, EventArgs e)
		{
			try {
			List<string> res = new List<string>();
			StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/options.ini");
			string line = "";
			int k = 0;
			while((line = sr.ReadLine()) != null) {
				res.Add(line);
			}
			
			System.Diagnostics.Process.Start(res[1].Replace("[mysql workbench]", ""));
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			
		}
		void ToolStripButton10Click(object sender, EventArgs e)
		{
			try {
			List<string> res = new List<string>();
			StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/options.ini");
			string line = "";
			int k = 0;
			while((line = sr.ReadLine()) != null) {
				res.Add(line);
			}
			
			
			System.Diagnostics.Process.Start(res[0].Replace("[mysql shell]", ""));
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void SettingsToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\options.ini");
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ToolStripButton9Click(object sender, EventArgs e)
		{
			try {
			System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\options.ini");
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		//Reference: http://www.codingvision.net/interface/c-simple-syntax-highlighting
		//Reference: http://shambhook.blogspot.com/2013/11/syntax-highlighting-in-richtextbox.html
		//Reference: https://www.c-sharpcorner.com/article/syntax-highlighting-in-richtextbox-control-part-2/
		void ToolStripButton12Click(object sender, EventArgs e)
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
		void RichTextBox1Click(object sender, EventArgs e)
		{
			
		}
		
		//Reference: https://www.c-sharpcorner.com/article/syntax-highlighting-in-richtextbox-control-part-2/
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
				
			}
		}
		void CSVToSQLToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
			CSVForm csv = new CSVForm();
			csv.ShowDialog();
			richTextBox1.Text = csv.query;
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ToolStripButton18Click(object sender, EventArgs e)
		{
			try {
			richTextBox1.Text += "show databases;";
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ToolStripButton17Click(object sender, EventArgs e)
		{
			try {
			richTextBox1.Text += "show tables;";
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ToolStripButton21Click(object sender, EventArgs e)
		{
			try {
			richTextBox1.Text += "with rollup;";
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ToolStripButton23Click(object sender, EventArgs e)
		{
			try {
			richTextBox1.Text += "create database databasename;";
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ToolStripButton24Click(object sender, EventArgs e)
		{
			try {
			richTextBox1.Text += "drop database databasename;";
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ToolStripButton22Click(object sender, EventArgs e)
		{
			try {
			richTextBox1.Text += "drop table table_name;";
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		void ToolStripButton14Click(object sender, EventArgs e)
		{
			try {
			InsertForm1cs insert = new InsertForm1cs();
			insert.ShowDialog();
			
			richTextBox1.Text += insert.query;
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			
			
		}
		
		void ToolStripButton16Click(object sender, EventArgs e)
		{
			try {
			DeleteForm insert = new DeleteForm();
			insert.ShowDialog();
			
			richTextBox1.Text += insert.query;
			
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			
		}
		void ToolStripButton19Click(object sender, EventArgs e)
		{
			CreateTablesForm insert = new CreateTablesForm();
			insert.ShowDialog();
			
			richTextBox1.Text += insert.query;
		}
		void ToolStripButton13Click(object sender, EventArgs e)
		{
			SelectForm insert = new SelectForm();
			insert.ShowDialog();
			
			richTextBox1.Text += insert.query;
		}
		void ToolStripButton15Click(object sender, EventArgs e)
		{
			UpdateForm insert = new UpdateForm();
			insert.ShowDialog();
			
			richTextBox1.Text += insert.query;
		}
		void UseMySQLShellToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\UseMySQLShell.pdf");
		}
		void SQLBasicsToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\SQLBasics.pdf");
		}
		void SQLJoinGroupByStatmentsToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\SQLJoinGroupByStatements.pdf");
		}
		
		
		
		
	}
}
