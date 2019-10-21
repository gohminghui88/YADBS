/*
 * Created by SharpDevelop.
 * User: gohmi
 * Date: 31/05/2019
 * Time: 5:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace YADBS
{
	partial class AboutForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(66, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Developed By: Eric M. H. Goh";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(66, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(413, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "YADBS Yet Another Database Studio v1.0.1 beta";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(66, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(223, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "gohminghui88@gmail.com";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(66, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(248, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Webpage: http://www.svbook.com";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(133, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(202, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "http://emhacademy.com";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(133, 148);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(116, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "http://dstk.tech";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(66, 186);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(576, 197);
			this.richTextBox1.TabIndex = 6;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(567, 389);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 435);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AboutForm";
			this.ResumeLayout(false);

		}
	}
}
