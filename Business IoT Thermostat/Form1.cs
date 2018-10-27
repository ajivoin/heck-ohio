using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;


namespace Business_IoT_Thermostat
{
    public partial class Form1 : Form
    {
        static int upCount = 0;
        static int runCount = 0;

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
            textBox1.Text = string.Empty;
            Ping pingSender = new Ping();
            for (int i = MIN_IN_RANGE; i <= MAX_IN_RANGE; i++)
            {
                string adr = BASE_IP + i.ToString();
                IPAddress address = IPAddress.Parse(adr);
                Application.DoEvents();
                List<PingReply> reply = PingN(pingSender, adr, PING_TIME, 1);
                if (reply.Count() > 0)
                {
                    textBox1.Text = adr + "\r\n" + textBox1.Text;
                }
                Application.DoEvents();
            }
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "None";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SAMPLE_COUNT; i++)
            {
                upCount = 0;
                pingThing();
            }
        }

        /// <summary>
        /// Generates a list of IP addresses prefixed with `baseIP` from "`baseIP`.`min`" through "`baseIP`.`max`"
        /// </summary>
        /// <param name="baseIP">First three segments of the network address with a '.' at the end</param>
        /// <param name="min">Minimum number for range</param>
        /// <param name="max">Maximum number for range</param>
        /// <returns>List of IP addresses</returns>
        private static List<string> GenerateIPList(string baseIP, int min, int max)
        {
            List<string> result = new List<string>();
            for (int i = min; i <= max; i++)
            {
                result.Add(baseIP + i.ToString());
            }
            return result;
        }

        /// <summary>
        /// Pings `ip` `n` times and returns list of successful ping replies.
        /// </summary>
        /// <param name="pingSender">Ping sender object</param>
        /// <param name="ip">IP to be pinged</param>
        /// <param name="timeout">Ping timeout</param>
        /// <param name="n">Number of attempts</param>
        /// <returns>List of successful ping replies</returns>
        private static List<PingReply> PingN(Ping pingSender, string ip, int timeout, int n)
        {
            List<PingReply> replies = new List<PingReply>();
            PingReply pingReply;
            for (int i = 0; i < n; i++)
            {
                pingReply = pingSender.Send(ip, timeout);
                if (pingReply != null && pingReply.Status == IPStatus.Success && pingReply.RoundtripTime > MIN_RESPONSE_TIME)
                {
                    replies.Add(pingReply);
                }
            }
            return replies;
        }

        /// <summary>
        /// Runs the ping process
        /// </summary>
        private static void pingThing()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            runCount = 0;
            Ping p = new Ping();
            List<string> ipList = GenerateIPList(BASE_IP, MIN_IN_RANGE, MAX_IN_RANGE);
            foreach (var ip in ipList)
            {
                Console.WriteLine("Running for {0}", ip);
                try
                {
                    runCount++;
                    List<PingReply> replies = PingN(p, ip, PING_TIME, SAMPLE_COUNT);
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
