using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			richTextBoxProcessName.Text = "notepad";
			InitProcess();
		}
		void InitProcess()
		{
			AllignText();
			myProcess.StartInfo = new System.Diagnostics.ProcessStartInfo(richTextBoxProcessName.Text);
		}
		void AllignText()
		{
			richTextBoxProcessName.SelectAll();
			richTextBoxProcessName.SelectionAlignment = HorizontalAlignment.Center;
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			InitProcess();
			myProcess.Start();
		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			myProcess.CloseMainWindow();	//закрывает процесс
			myProcess.Close();		//освобождает ресурсы, занимаемые процессом
		}
	}
}
