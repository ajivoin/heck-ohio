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
        static CountdownEvent countdown;
        static int upCount = 0;
        static object lockObj = new object();
        const bool resolveNames = false;
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
            upCount = 0;
            countdown = new CountdownEvent(1);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string ipBase = "192.168.137.";
            for (int i = 2; i < 255; i++)
            {
                if (i != 35)
                {
                    string ip = ipBase + i.ToString();

                    Ping p = new Ping();
                    p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                    countdown.AddCount();
                    p.SendAsync(ip, 500, ip);
                    Application.DoEvents();
                }
            }
            //countdown.Signal();
            //countdown.Wait();
            sw.Stop();
            TimeSpan span = new TimeSpan(sw.ElapsedTicks);
            Console.WriteLine("Took {0} milliseconds. {1} hosts active.", sw.ElapsedMilliseconds, upCount);
            Console.ReadLine();
        }
        static void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                    Console.WriteLine("{0} is up: ({1} ms)", ip, e.Reply.RoundtripTime);
                lock (lockObj)
                {
                    upCount++;
                }
            }
            else if (e.Reply == null)
            {
                Console.WriteLine("Pinging {0} failed. (Null Reply object?)", ip);
            }
            countdown.Signal();
        }
    }
    
}
