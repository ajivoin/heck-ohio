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

        char currentMode;

        float previousDist;
        float currentDist;




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
                ProcessLine(portInput);
                Console.WriteLine(portInput);
                Thread.Sleep(20);
                Application.DoEvents();
            }
        }

 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void SettingsView_Load(object sender, EventArgs e) {

        }

        void ProcessLine (String line) {
            String[] vals = line.Split(',');
            float temp1 = float.Parse(vals[0]);
            float temp2 = float.Parse(vals[1]);
            float humid1 = float.Parse(vals[2]);
            float humid2 = float.Parse(vals[3]);


            MapView.instance.zoneViews[4].SetTemp(temp1.ToString() + "\u00B0");
            MapView.instance.zoneViews[5].SetTemp(temp2.ToString() + "\u00B0");

            MapView.instance.zoneViews[4].SetHumid(humid1.ToString() + "%");
            MapView.instance.zoneViews[5].SetHumid(humid2.ToString() + "%");

            currentDist = float.Parse(vals[5]);
        }

        private void button1_Click(object sender, EventArgs e) {
            connectToArduino();
            startDataStream();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (Math.Abs(currentDist - previousDist) > 2f) {
                setTrigger();
            }
            previousDist = currentDist;
        }

        public void setTrigger() {
            currentMode = '1';
        }
    }
}
