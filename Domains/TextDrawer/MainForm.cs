using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextDrawer
{
	public partial class MainForm : Form
	{
		string text = "Nothing here yet";
		Font font;
		public MainForm()
		{
			InitializeComponent();
			font = new Font("Arial", 48);

			panel1.Paint += Panel1_Paint;
			//this.Paint += MainForm_Paint;
		}
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
			if (text.Length > 0)
			{
				//1) Создаем картинку:
				Image img = new Bitmap(panel1.ClientRectangle.Width, panel1.ClientRectangle.Height);
				//2) Для того чтобы что-либо нарисовать, нужен контекст устройства.
				//	 Получаем контекст устройства(в даном случае, устройством является картинка):
				//	 Контекст устройства - это то, на чем можно рисовать.
				Graphics imgDC = Graphics.FromImage(img);	//Image Device Context
				//3) Очищаем фон, задаем цвет фона:
				imgDC.Clear(Color.LightBlue);
				//4) Загоняем текст в картинку, используя контекст этой картинки:
				imgDC.DrawString(text, font, Brushes.Black, ClientRectangle, new StringFormat(StringFormatFlags.NoFontFallback));
				//5) Прорисовываем картинку:
				e.Graphics.DrawImage(img, 0, 0);
			}
		}
		private void MainForm_Paint(object sender, PaintEventArgs e)
		{
			Panel1_Paint(panel1, new PaintEventArgs(panel1.CreateGraphics(), panel1.ClientRectangle));
		}

		private void fontToolStripMenuItemFont_Click(object sender, EventArgs e)
		{
			//1) Создаем диалог изменения шрифта:
			FontDialog fontDialog = new FontDialog();

			//2) Загружаем текущий шрифт в диалог:
			fontDialog.Font = this.font;

			//3) Применяем новые настройки шрифта:
			if (fontDialog.ShowDialog() == DialogResult.OK) this.font = fontDialog.Font;

			//4) Принудительно вызываем событие отрисовки панели:
			Panel1_Paint(panel1, new PaintEventArgs(panel1.CreateGraphics(), panel1.ClientRectangle));
		}
		public void SetText(string text)
		{
			this.text = text;
			Panel1_Paint(panel1, new PaintEventArgs(panel1.CreateGraphics(), panel1.ClientRectangle));
		}
		public void Move(Point newLocation, int width)
		{
			this.Location = newLocation;
			this.Width = width;
		}
	}
}
