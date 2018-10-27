using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;


namespace Business_IoT_Thermostat {
    public partial class SettingsView : UserControl {

        public Form2 parent;
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        String portInput;




        public SettingsView() {
            InitializeComponent();

            getAvailableComPorts();

            foreach (string port in ports) {
                cboxPorts.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null) {
                    cboxPorts.SelectedItem = ports[0];
                }
            }
        }

        void getAvailableComPorts() {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino() {
            isConnected = true;
            string selectedPort = cboxPorts.GetItemText(cboxPorts.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            try {
                port.Open();
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            Thread.Sleep(500);
            Console.WriteLine("Ran1");
        }

        private void disconnectFromArduino() {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
        }

        public void startDataStream() {
            while (isConnected) {
                portInput = port.ReadLine();
                Console.WriteLine(portInput);
                Thread.Sleep(20);
                Application.DoEvents();
            }
        }

 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void SettingsView_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            connectToArduino();
            startDataStream();
        }
    }
}
