/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 17/10/2024
 * Time: 00:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CacadorDeChar
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
		void Button1Click(object sender, EventArgs e)
		{
			string palavra = textBox1.Text;
			string letra = textBox2.Text;
			for (int i = 0; i < palavra.Length; i++)
			{
				int pos = i + 1;
				string letraP = palavra[i].ToString();
				if(letraP == letra)
				{
					listBox1.Items.Add("A letra " + letraP + " está na posição: " + pos );
					
				}
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			listBox1.Items.Clear();
			textBox1.Focus();
		}
		
	}
}
