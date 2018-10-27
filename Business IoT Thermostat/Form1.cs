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
        static object lockObj = new object();
        const bool resolveNames = false;
        const int MAX_IN_RANGE = 10;
        const int TRIES_PER_IP = 3;
        const int PING_TIME = 500;

        public Form1()
        {
            InitializeComponent();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
           // var localComputers = NetworkComputer.GetLocalNetwork();
            //Ping pingSender = new Ping();
            //for (int i = 0; i < 255; i++)
            //{
            //    string adr = "192.168.137."+i.ToString();
            //    IPAddress address = IPAddress.Parse(adr);
            //    Application.DoEvents();
            //    PingReply reply = pingSender.Send(address);
            //    if (reply.Status == IPStatus.Success){
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
            //var startTimeSpan = TimeSpan.Zero;
            //var periodTimeSPan = TimeSpan.FromMilliseconds(500);
            //var timer = new System.Threading.Timer((_) =>
            //{
            //    upCount = 0;
            //    pingThing();
            //}, null, startTimeSpan, periodTimeSPan);
            for (int i = 0; i < 1; i++)
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
            string ipBase = "192.168.137.";
            Ping p = new Ping();
            PingReply pingReply;
            //p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
            //ideal code
            List<string> ipList = new List<string>();
            int MAX_IN_RANGE = 10;
            int TRIES_PER_IP = 3;
            int PING_TIME = 500;
            for (int i = 2; i < MAX_IN_RANGE; i++) { ipList.Add(ipBase + i.ToString()); }
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
                        Console.WriteLine("Pinging {0} was great success. Time: {1}", ip, replies.Sum(x => x.RoundtripTime));
                        upCount++;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Pinging {0} failed. (Null Reply object?)", ip);
                    continue;
                }
                //Ping p = new Ping();
                //p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                //p.SendAsync(ip, 500, ip);
                //Application.DoEvents();

            }


            sw.Stop();
            TimeSpan span = new TimeSpan(sw.ElapsedTicks);
            Console.WriteLine("Took {0} milliseconds. {1} hosts active.", sw.ElapsedMilliseconds, upCount);
        }
        //static void p_PingCompleted(object sender, PingCompletedEventArgs e)
        //{
        //    string ip = (string)e.UserState;
        //    lock (lockObj)
        //    {
        //        runCount++;
        //    }
        //    if (e.Reply != null && e.Reply.Status == IPStatus.Success)
        //    {
        //        if (e.Reply.RoundtripTime > 2)
        //        {
        //            Console.WriteLine("{0} is up: ({1} ms)", ip, e.Reply.RoundtripTime);
        //            lock (lockObj)
        //            {
        //                upCount++;
        //            }
        //        }
        //    }
        //    else if (e.Reply == null)
        //    {
        //        Console.WriteLine("Pinging {0} failed. (Null Reply object?)", ip);
        //    }
        //}
    }
    
}
