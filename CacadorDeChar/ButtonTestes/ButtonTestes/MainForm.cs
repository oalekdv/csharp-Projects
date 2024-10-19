/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 24/08/2024
 * Time: 15:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace ButtonTestes
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
	
		}
		void Button1Paint(object sender, PaintEventArgs e)
		{
			
			// define a corde de fundo e a borda do botão
			Color buttonBackgroundColor = Color.LightBlue;
			Color buttonBorderColor = Color.DarkBlue;
			
			// obtém o retangulo do botão
			Rectangle buttonRect = button1.ClientRectangle;
			
			int cornerRadius = 20;
			using (GraphicsPath roundedPath = new GraphicsPath())
    {
        roundedPath.AddArc(buttonRect.X, buttonRect.Y, cornerRadius, cornerRadius, 180, 180);
        roundedPath.AddArc(buttonRect.X + buttonRect.Width - cornerRadius, buttonRect.Y, cornerRadius, cornerRadius, 270, 90);
        roundedPath.AddArc(buttonRect.X + buttonRect.Width - cornerRadius, buttonRect.Y + buttonRect.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
        roundedPath.AddArc(buttonRect.X, buttonRect.Y + buttonRect.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
        roundedPath.CloseFigure();

        // Preenche o botão com a cor de fundo
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        e.Graphics.FillPath(new SolidBrush(buttonBackgroundColor), roundedPath);

        // Desenha a borda do botão
        e.Graphics.DrawPath(new Pen(buttonBorderColor, 2), roundedPath);

        // Desenha o texto do botão
        TextRenderer.DrawText(e.Graphics, button1.Text, button1.Font, buttonRect, button1.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
			
		}
	}
}
