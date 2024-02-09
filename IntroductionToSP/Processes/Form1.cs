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
		//void Form1_Closing(object sender, CancelEventArgs e)
		//{
		//	myProcess.CloseMainWindow();
		//	myProcess.Close();
		//}
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
			Info();
		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			myProcess.CloseMainWindow();	//закрывает процесс
			myProcess.Close();		//освобождает ресурсы, занимаемые процессом
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			myProcess.CloseMainWindow();
			myProcess.Close();
		}
		void Info()
		{
			labelProcessInfo.Text = "Process info:\n";
			labelProcessInfo.Text += $"PID:				{myProcess.Id}\n";
			labelProcessInfo.Text += $"Base priority:	{myProcess.BasePriority}\n";
			labelProcessInfo.Text += $"Priority class:	{myProcess.PriorityClass}\n";
			labelProcessInfo.Text += $"Start time:		{myProcess.StartTime}\n";
			labelProcessInfo.Text += $"Total CPU time:	{myProcess.TotalProcessorTime}\n";
			labelProcessInfo.Text += $"User  CPU time:	{myProcess.UserProcessorTime}\n";
			labelProcessInfo.Text += $"User  CPU time:	{myProcess.UserProcessorTime}\n";
			labelProcessInfo.Text += $"Session ID:		{myProcess.SessionId}\n";
			labelProcessInfo.Text += $"Name:			{myProcess.ProcessName}\n";
			labelProcessInfo.Text += $"Affinity:		{myProcess.ProcessorAffinity}\n";
			labelProcessInfo.Text += $"Threads:			{myProcess.Threads.Count}\n";
		}
	}
}
