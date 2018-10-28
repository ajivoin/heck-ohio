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

        private MapView map;
        private GeneralView general;
        private SettingsView settings;

        public Form2() {
            InitializeComponent();
            
            map = new MapView();
            general = new GeneralView();
            settings = new SettingsView();

            settings.parent = this;
            map.setCallback(this);
            userControl.Controls.Add(general);

        }

        //private void ChangeActiveView() {
        //    //generalPanel.Visible = false;
        //    mapPanel.Visible = false;
        //    zonePanel.Visible = false;

        //    switch (activeView) {
        //        case View.General:
        //            //generalPanel.Visible = true;
        //            break;
        //        case View.Map:
        //            mapPanel.Visible = true;
        //            break;
        //        case View.Zone:
        //            zonePanel.Visible = true;
        //            break;
        //    }
        //}

        private void generalBtn_Click(object sender, EventArgs e) {
            activeView = View.General;
            userControl.Controls.Clear();
            userControl.Controls.Add(general);
        }

        private void mapBtn_Click(object sender, EventArgs e) {
            activeView = View.Map;
            userControl.Controls.Clear();
            userControl.Controls.Add(map);
        }

        private void zoneBtn_Click(object sender, EventArgs e) {
            activeView = View.Zone;
            userControl.Controls.Clear();
            userControl.Controls.Add(settings);
        }

        public void OpenZone(string s) {
            //activeView = View.Zone;
            //userControl.Controls.Clear();
            //userControl.Controls.Add(zone);
            //zone.SetText(s);
        }

        private void floorComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void Form2_Load(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void floorComboBox_SelectedIndexChanged_1(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
