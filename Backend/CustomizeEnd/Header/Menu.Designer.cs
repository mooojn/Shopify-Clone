﻿namespace CustomizeEnd.Header
{
	partial class Menu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(508, 468);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(182, 62);
			this.button3.TabIndex = 22;
			this.button3.Text = "Add";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(353, 395);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 25);
			this.label3.TabIndex = 21;
			this.label3.Text = "Name";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(477, 389);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(313, 31);
			this.textBox3.TabIndex = 20;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(648, 304);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(182, 62);
			this.button2.TabIndex = 19;
			this.button2.Text = "Done";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(312, 207);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 25);
			this.label2.TabIndex = 18;
			this.label2.Text = "LogoText";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(287, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 25);
			this.label1.TabIndex = 17;
			this.label1.Text = "HeaderBGHex";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(456, 201);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(313, 31);
			this.textBox2.TabIndex = 16;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(456, 130);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(313, 31);
			this.textBox1.TabIndex = 15;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1221, 824);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Menu";
			this.Text = "Menu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
	}
}