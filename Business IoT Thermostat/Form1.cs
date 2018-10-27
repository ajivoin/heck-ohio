using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;
using System.DirectoryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Net.Sockets;


namespace Business_IoT_Thermostat
{
    public partial class Form1 : Form
    {
        static int upCount = 0;
        static int runCount = 0;

        const bool resolveNames = false;

        const int MAX_IN_RANGE = 10;
        const int MIN_IN_RANGE = 2;

        const int TRIES_PER_IP = 3;
        const int PING_TIME = 500;
        const int SAMPLE_COUNT = 1;

        const string BASE_IP = "192.168.137.";

        public Form1()
        {
            InitializeComponent();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //var localComputers = NetworkComputer.GetLocalNetwork();
            //Ping pingSender = new Ping();
            //for (int i = 0; i < 255; i++)
            //{
            //    string adr = "192.168.137." + i.ToString();
            //    IPAddress address = IPAddress.Parse(adr);
            //    Application.DoEvents();
            //    PingReply reply = pingSender.Send(address);
            //    if (reply.Status == IPStatus.Success)
            //    {
            //        textBox1.Text = adr + textBox1.Text;
            //        Application.DoEvents();
            //    }
            //    else
            //    {
            //        textBox1.Text = "None";
            //        Application.DoEvents();
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SAMPLE_COUNT; i++)
            {
                upCount = 0;
                pingThing();
            }
        }

        private static void pingThing()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            runCount = 0;
            Ping p = new Ping();
            PingReply pingReply;
            List<string> ipList = new List<string>();
            for (int i = MIN_IN_RANGE; i < MAX_IN_RANGE; i++)
            {
                ipList.Add(BASE_IP + i.ToString());
            }
            foreach (var ip in ipList)
            {
                Console.WriteLine("Running for {0}", ip);
                try
                {
                    runCount++;
                    List<PingReply> replies = new List<PingReply>();
                    for (int j = 0; j < TRIES_PER_IP; j++)
                    {
                        pingReply = p.Send(ip, PING_TIME);
                        if (pingReply != null && pingReply.Status == IPStatus.Success && pingReply.RoundtripTime > 2)
                        {
                            replies.Add(pingReply);
                        }
                    }
                    if (replies.Count() > 0)
                    {
                        Console.WriteLine("Pinging {0} was great success. Time: {1} ms", ip, replies.Sum(x => x.RoundtripTime));
                        upCount++;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Pinging {0} failed. (Null Reply object?)", ip);
                    continue;
                }
                Application.DoEvents();
            }


            sw.Stop();
            Console.WriteLine("Took {0} milliseconds. {1} hosts active.", sw.ElapsedMilliseconds, upCount);
        }
    }
}
