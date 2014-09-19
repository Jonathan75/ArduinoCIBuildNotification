using System.Windows.Forms;

namespace DesktopToArduinoSerialInterface
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
			this.button1 = new System.Windows.Forms.Button();
			this.txtLightDelay = new System.Windows.Forms.TextBox();
			this.lstPorts = new System.Windows.Forms.ComboBox();
			this.lstProject = new System.Windows.Forms.ComboBox();
			this.lstBuildDefinitions = new System.Windows.Forms.ComboBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lstBuilds = new System.Windows.Forms.ComboBox();
			this.lstJobMonitor = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 374);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtLightDelay
			// 
			this.txtLightDelay.Location = new System.Drawing.Point(12, 348);
			this.txtLightDelay.Name = "txtLightDelay";
			this.txtLightDelay.Size = new System.Drawing.Size(100, 20);
			this.txtLightDelay.TabIndex = 1;
			this.txtLightDelay.Text = "50";
			this.txtLightDelay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLightDelay_KeyDown);
			// 
			// lstPorts
			// 
			this.lstPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstPorts.FormattingEnabled = true;
			this.lstPorts.Location = new System.Drawing.Point(12, 321);
			this.lstPorts.Name = "lstPorts";
			this.lstPorts.Size = new System.Drawing.Size(220, 21);
			this.lstPorts.TabIndex = 2;
			this.lstPorts.SelectedIndexChanged += new System.EventHandler(this.lstPorts_SelectedIndexChanged);
			// 
			// lstProject
			// 
			this.lstProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstProject.FormattingEnabled = true;
			this.lstProject.Location = new System.Drawing.Point(12, 294);
			this.lstProject.Name = "lstProject";
			this.lstProject.Size = new System.Drawing.Size(220, 21);
			this.lstProject.TabIndex = 3;
			this.lstProject.SelectedIndexChanged += new System.EventHandler(this.lstProject_SelectedIndexChanged);
			// 
			// lstBuildDefinitions
			// 
			this.lstBuildDefinitions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstBuildDefinitions.FormattingEnabled = true;
			this.lstBuildDefinitions.Location = new System.Drawing.Point(12, 12);
			this.lstBuildDefinitions.Name = "lstBuildDefinitions";
			this.lstBuildDefinitions.Size = new System.Drawing.Size(220, 21);
			this.lstBuildDefinitions.TabIndex = 4;
			this.lstBuildDefinitions.SelectedIndexChanged += new System.EventHandler(this.lstBuildDefinitions_SelectedIndexChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 400);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(242, 22);
			this.statusStrip1.TabIndex = 6;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lstBuilds
			// 
			this.lstBuilds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstBuilds.FormattingEnabled = true;
			this.lstBuilds.Location = new System.Drawing.Point(12, 39);
			this.lstBuilds.Name = "lstBuilds";
			this.lstBuilds.Size = new System.Drawing.Size(220, 21);
			this.lstBuilds.TabIndex = 7;
			// 
			// lstJobMonitor
			// 
			this.lstJobMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstJobMonitor.FormattingEnabled = true;
			this.lstJobMonitor.Location = new System.Drawing.Point(12, 66);
			this.lstJobMonitor.Name = "lstJobMonitor";
			this.lstJobMonitor.Size = new System.Drawing.Size(218, 95);
			this.lstJobMonitor.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(242, 422);
			this.Controls.Add(this.lstJobMonitor);
			this.Controls.Add(this.lstBuilds);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.lstBuildDefinitions);
			this.Controls.Add(this.lstProject);
			this.Controls.Add(this.lstPorts);
			this.Controls.Add(this.txtLightDelay);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtLightDelay;
		private System.Windows.Forms.ComboBox lstPorts;
		private ComboBox lstProject;
		private ComboBox lstBuildDefinitions;
		private StatusStrip statusStrip1;
		private ComboBox lstBuilds;
		private ListBox lstJobMonitor;
	}
}

