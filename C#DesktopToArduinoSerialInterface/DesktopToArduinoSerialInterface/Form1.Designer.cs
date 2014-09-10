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
			this.lstBuilds = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(86, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtLightDelay
			// 
			this.txtLightDelay.Location = new System.Drawing.Point(86, 201);
			this.txtLightDelay.Name = "txtLightDelay";
			this.txtLightDelay.Size = new System.Drawing.Size(100, 20);
			this.txtLightDelay.TabIndex = 1;
			this.txtLightDelay.Text = "50";
			this.txtLightDelay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLightDelay_KeyDown);
			// 
			// lstPorts
			// 
			this.lstPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstPorts.FormattingEnabled = true;
			this.lstPorts.Location = new System.Drawing.Point(86, 174);
			this.lstPorts.Name = "lstPorts";
			this.lstPorts.Size = new System.Drawing.Size(121, 21);
			this.lstPorts.TabIndex = 2;
			this.lstPorts.SelectedIndexChanged += new System.EventHandler(this.lstPorts_SelectedIndexChanged);
			// 
			// lstProject
			// 
			this.lstProject.FormattingEnabled = true;
			this.lstProject.Location = new System.Drawing.Point(86, 147);
			this.lstProject.Name = "lstProject";
			this.lstProject.Size = new System.Drawing.Size(121, 21);
			this.lstProject.TabIndex = 3;
			this.lstProject.SelectedIndexChanged += new System.EventHandler(this.lstProject_SelectedIndexChanged);
			// 
			// lstBuildDefinitions
			// 
			this.lstBuildDefinitions.FormattingEnabled = true;
			this.lstBuildDefinitions.Location = new System.Drawing.Point(86, 12);
			this.lstBuildDefinitions.Name = "lstBuildDefinitions";
			this.lstBuildDefinitions.Size = new System.Drawing.Size(121, 21);
			this.lstBuildDefinitions.TabIndex = 4;
			this.lstBuildDefinitions.SelectedIndexChanged += new System.EventHandler(this.lstBuildDefinitions_SelectedIndexChanged);
			// 
			// lstBuilds
			// 
			this.lstBuilds.FormattingEnabled = true;
			this.lstBuilds.Location = new System.Drawing.Point(86, 39);
			this.lstBuilds.Name = "lstBuilds";
			this.lstBuilds.Size = new System.Drawing.Size(120, 95);
			this.lstBuilds.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.lstBuilds);
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
		private ListBox lstBuilds;
	}
}

