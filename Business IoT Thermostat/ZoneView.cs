using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_IoT_Thermostat {
    public partial class ZoneView : UserControl {

        public Form2 parent;

        public ZoneView() {
            InitializeComponent();

        }

        public void SetText(string s) {
            labelText.Text = s;
        }

        public void SetTemp(string s) {
            tempText.Text = s;
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
    }
}
