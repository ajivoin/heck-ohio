using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_IoT_Thermostat {
    public partial class Form2 : Form {

        private enum View { Map, Zone, General };
        private View activeView;

        public Form2() {
            InitializeComponent();
        }

        private void ChangeActiveView() {
            generalPanel.Visible = false;
            mapPanel.Visible = false;
            zonePanel.Visible = false;

            switch (activeView) {
                case View.General:
                    generalPanel.Visible = true;
                    break;
                case View.Map:
                    mapPanel.Visible = true;
                    break;
                case View.Zone:
                    zonePanel.Visible = true;
                    break;
            }
        }

        private void generalBtn_Click(object sender, EventArgs e) {
            activeView = View.General;
            ChangeActiveView();
        }

        private void mapBtn_Click(object sender, EventArgs e) {
            activeView = View.Map;
            ChangeActiveView();
        }

        private void zoneBtn_Click(object sender, EventArgs e) {
            activeView = View.Zone;
            ChangeActiveView();
        }
    }
}
