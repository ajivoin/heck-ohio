using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Business_IoT_Thermostat
{
    public partial class Form1 : Form
    {
        const bool resolveNames = false;

        const int MAX_IN_RANGE = 10;
        const int MIN_IN_RANGE = 1;

        const int TRIES_PER_IP = 3;
        const int PING_TIME = 500;
        const int SAMPLE_COUNT = 1;
        const int MIN_RESPONSE_TIME = 2;

        // Jon
        const string BASE_IP = "192.168.137.";

        // Andrew
        //const string BASE_IP = "172.31.112.";

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            //textBox1.Text = string.Empty;
            //Ping pingSender = new Ping();
            //for (int i = MIN_IN_RANGE; i <= MAX_IN_RANGE; i++)
            //{
            //    string adr = BASE_IP + i.ToString();
            //    IPAddress address = IPAddress.Parse(adr);
            //    Application.DoEvents();
            //    List<PingReply> reply = PingN(pingSender, adr, PING_TIME, 1);
            //    if (reply.Count() > 0)
            //    {
            //        textBox1.Text = adr + "\r\n" + textBox1.Text;
            //    }
            //    Application.DoEvents();
            //}
            //if (textBox1.Text == string.Empty)
            //{
            //    textBox1.Text = "None";
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NetworkScanner netScan = new NetworkScanner(BASE_IP, 2, 3, 4);
            Dictionary<string, long> addresses = netScan.Scan(PING_TIME, TRIES_PER_IP);
            foreach (KeyValuePair<string, long> p in addresses)
            {
                textBox1.Text += string.Format("{0}:{1}", p.Key, p.Value);
            }
        }  
    }
}
