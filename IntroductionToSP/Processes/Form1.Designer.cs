namespace Processes
{
	partial class Form1
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
			this.richTextBoxProcessName = new System.Windows.Forms.RichTextBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.labelProcessInfo = new System.Windows.Forms.Label();
			this.myProcess = new System.Diagnostics.Process();
			this.lvProcesses = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// richTextBoxProcessName
			// 
			this.richTextBoxProcessName.Location = new System.Drawing.Point(13, 13);
			this.richTextBoxProcessName.Name = "richTextBoxProcessName";
			this.richTextBoxProcessName.Size = new System.Drawing.Size(419, 23);
			this.richTextBoxProcessName.TabIndex = 0;
			this.richTextBoxProcessName.Text = "calc.exe";
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(13, 42);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 1;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonStop
			// 
			this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStop.Location = new System.Drawing.Point(357, 42);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(75, 23);
			this.buttonStop.TabIndex = 2;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// labelProcessInfo
			// 
			this.labelProcessInfo.AutoSize = true;
			this.labelProcessInfo.Location = new System.Drawing.Point(13, 72);
			this.labelProcessInfo.Name = "labelProcessInfo";
			this.labelProcessInfo.Size = new System.Drawing.Size(69, 13);
			this.labelProcessInfo.TabIndex = 3;
			this.labelProcessInfo.Text = "Process Info:";
			// 
			// myProcess
			// 
			this.myProcess.StartInfo.Domain = "";
			this.myProcess.StartInfo.LoadUserProfile = false;
			this.myProcess.StartInfo.Password = null;
			this.myProcess.StartInfo.StandardErrorEncoding = null;
			this.myProcess.StartInfo.StandardOutputEncoding = null;
			this.myProcess.StartInfo.UserName = "";
			this.myProcess.SynchronizingObject = this;
			// 
			// lvProcesses
			// 
			this.lvProcesses.FullRowSelect = true;
			this.lvProcesses.HideSelection = false;
			this.lvProcesses.Location = new System.Drawing.Point(16, 88);
			this.lvProcesses.MultiSelect = false;
			this.lvProcesses.Name = "lvProcesses";
			this.lvProcesses.Size = new System.Drawing.Size(416, 228);
			this.lvProcesses.TabIndex = 4;
			this.lvProcesses.UseCompatibleStateImageBehavior = false;
			this.lvProcesses.View = System.Windows.Forms.View.Details;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 328);
			this.Controls.Add(this.lvProcesses);
			this.Controls.Add(this.labelProcessInfo);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.richTextBoxProcessName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBoxProcessName;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Label labelProcessInfo;
		private System.Diagnostics.Process myProcess;
		private System.Windows.Forms.ListView lvProcesses;
	}
}

