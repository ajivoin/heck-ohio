using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
namespace Business_IoT_Thermostat {
    public partial class ZoneView : UserControl {
        
        public Form2 parent;
        public int setTemp = 72;
        public Stopwatch stopwatch = new Stopwatch();
        public int graph_scalar = 32;
        public ZoneView() {
            InitializeComponent();
            tempText.Text = "72.3\u00B0";
            tempSet.Text = setTemp.ToString() + "\u00B0";

        }

        public void SetText(string s) {
            labelText.Text = s;
        }

        public void SetTemp(string s, float num) {
            tempText.Text = s;
            double time = Math.Round((stopwatch.ElapsedMilliseconds / 1000.0), 1);
            
                if (graph.Series[0].Points.Count > graph_scalar) 
                    graph.Series[0].Points.RemoveAt(0);
         
                DataPoint newPoint = new DataPoint(time, num);
                graph.Series[0].Points.Add(newPoint);
                graph.ChartAreas[0].RecalculateAxesScale();
            
        }

        public void SetHumid(string s) {
            humidText.Text = s;
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label2_Click_1(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnLowerSet_Click(object sender, EventArgs e) {
            setTemp--;
            tempSet.Text = setTemp.ToString() + "\u00B0";
        }

        private void btnRaiseSet_Click(object sender, EventArgs e) {
            setTemp++;
            tempSet.Text = setTemp.ToString() + "\u00B0";
        }

        public void setDevicesText(int size)
        {
            devicesLabel.Text = size.ToString();
        }

        private void tempSet_Click(object sender, EventArgs e) {

        }

        private void graph2_Click(object sender, EventArgs e)
        {

        }
    }
}
