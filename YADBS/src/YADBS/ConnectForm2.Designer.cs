﻿/*
 * Created by SharpDevelop.
 * User: gohmi
 * Date: 29/05/2019
 * Time: 2:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace YADBS
{
	partial class ConnectForm2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(327, 24);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(424, 22);
			this.textBox6.TabIndex = 27;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(250, 27);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 26;
			this.label6.Text = "Name: ";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(327, 125);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(73, 22);
			this.textBox5.TabIndex = 25;
			this.textBox5.Text = "3306";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(250, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 24;
			this.label5.Text = "Port: ";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(784, 271);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 33);
			this.button2.TabIndex = 23;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(691, 271);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 33);
			this.button1.TabIndex = 22;
			this.button1.Text = "Connect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(327, 206);
			this.textBox4.Name = "textBox4";
			this.textBox4.PasswordChar = '*';
			this.textBox4.Size = new System.Drawing.Size(424, 22);
			this.textBox4.TabIndex = 21;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(327, 170);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(424, 22);
			this.textBox3.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(250, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 19;
			this.label4.Text = "Passwords: ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(250, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "User: ";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(327, 96);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(424, 22);
			this.textBox2.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(250, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "Database: ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(327, 63);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(424, 22);
			this.textBox1.TabIndex = 15;
			this.textBox1.Text = "localhost";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(250, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "Server: ";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(24, 56);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(207, 276);
			this.listBox1.TabIndex = 28;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(156, 24);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 29;
			this.button3.Text = "Edit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// ConnectForm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 357);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ConnectForm2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Connect";
			this.Load += new System.EventHandler(this.ConnectForm2Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
