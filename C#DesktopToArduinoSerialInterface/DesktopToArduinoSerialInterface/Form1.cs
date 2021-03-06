﻿using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Arduino4Net.Components.Leds;
using Arduino4Net.Models;
using Microsoft.TeamFoundation.Build.Client;
using Microsoft.TeamFoundation.Client;

namespace DesktopToArduinoSerialInterface
{
	public partial class Form1 : Form
	{
		readonly SerialPortWrapper serialPortWrapper;
		readonly TfsWrapper tfsWrapper;
		ArduinoWrapper arduinoWrapper;
		public Form1()
		{
			InitializeComponent();
			serialPortWrapper = new SerialPortWrapper();

			lstPorts.DataSource = serialPortWrapper.GetPorts();

			tfsWrapper = new TfsWrapper();


			lstBuildDefinitions.DataSource = tfsWrapper.GetAllBuildDefinitionsFromTheTeamProject();
			lstBuildDefinitions.DisplayMember = "Name";
			lstBuildDefinitions.ValueMember  = "Uri";
		}

		private void lstPorts_SelectedIndexChanged(object sender, EventArgs e)
		{
			//serialPortWrapper.SerialPort.PortName = lstPorts.SelectedValue.ToString();
			arduinoWrapper = new ArduinoWrapper(lstPorts.SelectedValue.ToString());
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
			arduinoWrapper.Blink();
			//serialPortWrapper.Send(txtLightDelay.Text);
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
			lstBuilds.DisplayMember = "Status";
			lstBuilds.ValueMember = "Uri";
		}

	}
	
	public class TfsWrapper
	{
		/// http://geekswithblogs.net/TarunArora/archive/2011/06/18/tfs-2010-sdk-connecting-to-tfs-2010-programmaticallyndashpart-1.aspx
		/// http://visualstudiogallery.msdn.microsoft.com/25622469-19d8-4959-8e5c-4025d1c9183d?SRC=VSIDE
		/// https://www.microsoft.com/en-us/download/details.aspx?id=21835

		TfsTeamProjectCollection _tfs;

		readonly string _selectedTeamProject;
		readonly IBuildServer _bs;
		
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


	public class ArduinoWrapper
	{
		Arduino board;
		readonly Led led13;
		readonly Led led12;
		readonly Led led11;


		public ArduinoWrapper(string Port)
		{
			board = new Arduino(Port);
			led13 = new Led(board,13);
			led12 = new Led(board,12);
			led11 = new Led(board,11);
		}

		public void GreenLight(bool on)
		{
			lightOnOff(led13, on);



			
			led11.On();
		}

		public void YellowLight(bool on)
		{
			lightOnOff(led12,on);
		}

		public void RedLight(StrobeSpeed speed)
		{
			led13.StrobeOn();

		}

		void lightOnOff(Led led, bool on)
		{
			if (on)
			{
				led13.On();
				return;
			}

			led13.Off();
		}

		public enum StrobeSpeed
		{
			Off = 0,
			On = 1,
			Slow = 1000 * 10,
			Medium = 1000,
			Fast = 500
		}
	}

	public class SerialPortWrapper
	{
		//public SerialPort SerialPort;
		//public SerialPortWrapper()
		//{
		
		//	SerialPort = new SerialPort() { PortName = "COM4", BaudRate = 9600 };
		//	//SerialPort = new SerialPort() {BaudRate = 9600 };
		//}

		public string[] GetPorts()
		{
			return SerialPort.GetPortNames();

		}

		//public void Send(string message)
		//{
		//	if (SerialPort.IsOpen) return;

		//	try
		//	{
		//		SerialPort.Open();
		//		SerialPort.Write(message);

		//	}
		//	catch (Exception ex)
		//	{
		//		throw;
		//	}
		//	finally
		//	{
		//		SerialPort.Close();
		//	}
		//}
	}
}
