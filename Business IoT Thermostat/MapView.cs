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
    public partial class MapView : UserControl {

        public static MapView instance;
        public List<PictureBox> floorImages = new List<PictureBox>();
        public List<List<PictureBox>> zones = new List<List<PictureBox>>();
        public int[][] floorZones = new int[3][];
        public Color selected = Color.FromArgb(33, 150, 243);
        public Color unselected = Color.FromArgb(187, 222, 251);
        public List<ZoneView> zoneViews = new List<ZoneView>();

        public Form2 callback;
        
        public MapView() {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();

            if (instance == null)
                instance = this;

            floorImages.Add(floor0);
            floorImages.Add(floor1);
            floorImages.Add(floor2);
            cboxFloor.SelectedIndex = 1;

            zones.Add(new List<PictureBox>());
            zones.Add(new List<PictureBox>());
            zones.Add(new List<PictureBox>());
            zones.Add(new List<PictureBox>());
            zones.Add(new List<PictureBox>());
            zones.Add(new List<PictureBox>());
            zones.Add(new List<PictureBox>());

            for (int i = 0; i < 7; i++) {
                zoneViews.Add(new ZoneView());
            }

            zones[0].Add(zone00);
            zones[0].Add(zone01);
            zones[1].Add(zone10);
            zones[2].Add(zone11);
            zones[3].Add(zone12);
            zones[4].Add(zone20);
            zones[5].Add(zone21);
            zones[6].Add(zone22);

            floorZones[0] = new int[] { 0 };
            floorZones[1] = new int[] { 1, 2, 3};
            floorZones[2] = new int[] { 4, 5, 6 };

            cboxFloor_SelectedIndexChanged(null, null);

        }

        public void setCallback(Form2 form) {
            callback = form;
        }


        private void cboxFloor_SelectedIndexChanged(object sender, EventArgs e) {
            foreach(PictureBox p in floorImages) {
                p.Visible = false;
            }
            floorImages[cboxFloor.SelectedIndex].Visible = true;
            foreach(List<PictureBox> l in zones) {
                foreach(PictureBox p in l) {
                    p.Visible = false;
                }
            }
            if (zones.Count > 0) {
                foreach (int i in floorZones[cboxFloor.SelectedIndex]) {
                    foreach(PictureBox p in zones[i])
                        p.Visible = true;
                }
            }
        }

        private void zone00_Click(object sender, EventArgs e) {
            OpenZone(0, "Floor 0 - Basement Lounge");
        }

        private void zone01_Click(object sender, EventArgs e) {
            OpenZone(0, "Floor 0 - Basement Lounge");
        }

        private void zone20_Click(object sender, EventArgs e) {
            OpenZone(4, "Floor 2 - Room D");
        }

        private void zone22_Click(object sender, EventArgs e) {
            OpenZone(6, "Floor 2 - Room E");
        }

        private void zone21_Click(object sender, EventArgs e) {
            OpenZone(5, "Floor 2 - Room F");
        }

        private void zone10_Click(object sender, EventArgs e) {
            OpenZone(1, "Floor 1 - Room A");
        }

        private void zone11_Click(object sender, EventArgs e) {
            OpenZone(2, "Floor 1 - Room B");
        }

        private void zone12_Click(object sender, EventArgs e) {
            OpenZone(3, "Floor 1 - Room C");
        }

        public void OpenZone(int i , string name) {
            userControl.Controls.Clear();
            userControl.Controls.Add(zoneViews[i]);
            zoneViews[i].SetText(name);

            foreach (List<PictureBox> l in zones) {
                foreach (PictureBox p in l) {
                    p.BackColor = unselected;
                }
            }
            foreach (PictureBox p in zones[i]) {
                p.BackColor = selected;
            }
        }
    }
}
