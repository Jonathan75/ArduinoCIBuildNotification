﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using DesktopToArduinoSerialInterface.TfsBuildWebService;
using Microsoft.TeamFoundation.Build.Client;
using Microsoft.TeamFoundation.Client;
//using Microsoft.TeamFoundation.Framework.Common;
//using Microsoft.TeamFoundation.VersionControl.Client;

namespace DesktopToArduinoSerialInterface
{
	public partial class Form1 : Form
	{
		SerialPortWrapper serialPortWrapper;
		TfsWrapper tfsWrapper;
		public Form1()
		{
			InitializeComponent();
			serialPortWrapper = new SerialPortWrapper();

			lstPorts.DataSource = serialPortWrapper.GetPorts();

			tfsWrapper = new TfsWrapper();


			lstBuildDefinitions.DataSource = tfsWrapper.GetAllBuildDefinitionsFromTheTeamProject();
			lstBuildDefinitions.DisplayMember = "Name";
			lstBuildDefinitions.ValueMember  = "Uri";
			//lstBuildDefinitions.SelectedIndex = 0;
		}

		private void lstPorts_SelectedIndexChanged(object sender, EventArgs e)
		{
			serialPortWrapper.SerialPort.PortName = lstPorts.SelectedValue.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			updateLightDelay();
		}

		private void txtLightDelay_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				updateLightDelay();
			}
		}


		void updateLightDelay()
		{
			serialPortWrapper.Send(txtLightDelay.Text);
		}

		private void lstProject_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void lstBuildDefinitions_SelectedIndexChanged(object sender, EventArgs e)
		{
			var buildDefinition = (((ComboBox)sender).SelectedItem) as IBuildDefinition;

			if (buildDefinition == null) 
				return;
			
			lstBuilds.DataSource= tfsWrapper.Builds(buildDefinition.Name);
			lstBuilds.DisplayMember = "BuildNumber";
			lstBuilds.ValueMember = "Uri";
			//lstBuilds.SelectedIndex = 0;
		}

	}
	
	public class TfsWrapper
	{
		TfsTeamProjectCollection _tfs;
		string _selectedTeamProject;
		IBuildServer _bs;
		
		public TfsWrapper()
		{

			TeamProjectPicker tfsPP = new TeamProjectPicker(TeamProjectPickerMode.SingleProject, false);
			tfsPP.ShowDialog();
			_tfs = tfsPP.SelectedTeamProjectCollection;
			_selectedTeamProject = tfsPP.SelectedProjects[0].Name;
			_bs = _tfs.GetService<IBuildServer>();
		}

		public IBuildDefinition[] GetAllBuildDefinitionsFromTheTeamProject()
		{
			return _bs.QueryBuildDefinitions(_selectedTeamProject);
		}

		public IBuildDetail[] Builds(string buildName)
		{
			var def = _bs.CreateBuildDetailSpec(_selectedTeamProject);
			def.MaxBuildsPerDefinition = 10;
			def.QueryOrder = BuildQueryOrder.FinishTimeDescending;
			def.DefinitionSpec.Name = buildName;
			def.Status = BuildStatus.InProgress;
			return _bs.QueryBuilds(def).Builds;
		}
		
	}

	public class SerialPortWrapper
	{
		public SerialPort SerialPort;
		public SerialPortWrapper()
		{
		
			SerialPort = new SerialPort() { PortName = "COM4", BaudRate = 9600 };
			//SerialPort = new SerialPort() {BaudRate = 9600 };
		}

		public string[] GetPorts()
		{
			return SerialPort.GetPortNames();

		}

		public void Send(string message)
		{
			if (SerialPort.IsOpen) return;

			try
			{
				SerialPort.Open();
				SerialPort.Write(message);

			}
			catch (Exception ex)
			{
				throw;
			}
			finally
			{
				SerialPort.Close();
			}
		}
	}
}
