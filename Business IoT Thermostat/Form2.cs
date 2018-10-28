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
        // Jon
        const string BASE_IP = "192.168.137.";

        public bool noConnectionsLeft, lowerTempLeft, higherTempLeft;
        public bool noMotionRight, lowerTempRight, higherTempRight;
        public int numDevices;
        public static Form2 instance;

        private enum View { Map, Zone, General };
        private View activeView;

        private MapView map;
        private GeneralView general;
        private SettingsView settings;

        private NetworkScanner networkScanner;

        public Form2() {
            InitializeComponent();
            instance = this;
            map = new MapView();
            general = new GeneralView();
            settings = new SettingsView();

            networkScanner = new NetworkScanner(BASE_IP, new int[] { 50, 5, 153, 18 });

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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (settings.Port == null) return;


            if (!noConnectionsLeft)
            {
                if (lowerTempLeft)
                {
                    settings.WriteToPort('2');
                }
                else if (higherTempLeft)
                {
                    settings.WriteToPort('3');
                }
                else
                {
                    settings.WriteToPort('1');
                }
            }
            else
            {
                settings.WriteToPort('1');
            }


            System.Threading.Thread.Sleep(300);
            if (!noMotionRight)
            {
                Console.WriteLine("MOTION");
                if (lowerTempRight)
                {
                    settings.WriteToPort('5');
                    //System.Threading.Thread.Sleep(300);
                    settings.WriteToPort('7');
                }
                else if (higherTempRight)
                {
                    settings.WriteToPort('6');
                    //System.Threading.Thread.Sleep(300);
                    settings.WriteToPort('8');
                }
                else
                {
                    settings.WriteToPort('4');
                   // System.Threading.Thread.Sleep(300);
                    settings.WriteToPort('7');
                }
            }
            else
            {
                settings.WriteToPort('4');
                //System.Threading.Thread.Sleep(300);
                settings.WriteToPort('7');
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void floorComboBox_SelectedIndexChanged_1(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            int devices = (await networkScanner.Scan(500, 2)).Count;
            MapView.instance.zoneViews[4].setDevicesText(devices);
            //foreach(ZoneView zv in MapView.instance.zoneViews)
            //{
            //    zv.setDevicesText(devices);
           // }
            noConnectionsLeft = devices == 0;
            numDevices = devices;
            if(devices == 0)
            {
                settings.WriteToPort('9');
            }
            if (devices == 1)
            {
                settings.WriteToPort('a');
            }
            if (devices == 2)
            {
                settings.WriteToPort('b');
            }
            if (devices == 3)
            {
                settings.WriteToPort('c');
            }
        }
    }
}
