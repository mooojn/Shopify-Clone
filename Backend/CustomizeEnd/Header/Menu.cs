using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomizeEnd.Header
{
	public partial class Menu : Form
	{
		public static List<string> menuItems = new List<string>();
		public List<string> data = new List<string>();
		public Menu()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CustomizeEnd.Header.Menu menu = new CustomizeEnd.Header.Menu();

			menu.Show();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			data.Add(textBox1.Text);
			data.Add(textBox2.Text);
			foreach (string i in menuItems)
			{
				data.Add(i);
			}
			SaveInFile();
			this.Close();
		}
		public void SaveInFile()
		{
			StreamWriter f = new StreamWriter("C:\\Users\\moon\\Desktop\\shopify-clone\\public\\data\\header.csv");
			foreach (string i in data)
			{
				f.WriteLine(i);
			}
			f.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			menuItems.Add(textBox3.Text);
			textBox3.Text = "";
		}

		private void button1_Click_1(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
