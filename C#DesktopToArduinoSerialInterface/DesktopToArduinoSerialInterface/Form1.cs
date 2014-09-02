using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopToArduinoSerialInterface
{
	public partial class Form1 : Form
	{
		SerialPortWrapper serialPortWrapper;

		public Form1()
		{
			InitializeComponent();
			serialPortWrapper = new SerialPortWrapper();

			lstPorts.DataSource = serialPortWrapper.GetPorts();
			//lstPorts.DataSource;

			this.Text = serialPortWrapper.GetPorts();
		}

		

		private void button1_Click(object sender, EventArgs e)
		{

			serialPortWrapper.Send(textBox1.Text);
		}

	
	}

	public class SerialPortWrapper
	{
		public SerialPort SerialPort;
		public SerialPortWrapper()
		{
		
			SerialPort = new SerialPort() { PortName = "COM4", BaudRate = 9600 };
			
		}

		public string GetPorts()
		{
			return SerialPort.GetPortNames()[0];

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
