using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Business_IoT_Thermostat
{
    class NetworkScanner
    { 
        readonly int upCount, minInRange, maxInRange;
        int scanCount;

        readonly List<string> ipList;
        
        // Filters out connections to self
        const int MIN_RESPONSE_TIME = 2;

        // Jon
        const string BASE_IP = "192.168.137.";

        // Andrew
        //const string BASE_IP = "172.31.112.";

        public NetworkScanner(string baseIP, int minInRange, int maxInRange)
        {
            ipList = GenerateIPList(baseIP, minInRange, maxInRange);
            this.minInRange = minInRange;
            this.maxInRange = maxInRange;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = string.Empty;
        //    Ping pingSender = new Ping();
        //    for (int i = MIN_IN_RANGE; i <= MAX_IN_RANGE; i++)
        //    {
        //        string adr = BASE_IP + i.ToString();
        //        IPAddress address = IPAddress.Parse(adr);
        //        Application.DoEvents();
        //        List<PingReply> reply = PingN(pingSender, adr, PING_TIME, 1);
        //        if (reply.Count() > 0)
        //        {
        //            textBox1.Text = adr + "\r\n" + textBox1.Text;
        //        }
        //        Application.DoEvents();
        //    }
        //    if (textBox1.Text == string.Empty)
        //    {
        //        textBox1.Text = "None";
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < SAMPLE_COUNT; i++)
        //    {
        //        upCount = 0;
        //        PingThing();
        //    }
        //}

        /// <summary>
        /// Generates a list of IP addresses prefixed with `baseIP` from "`baseIP`.`min`" through "`baseIP`.`max`"
        /// </summary>
        /// <param name="baseIP">First three segments of the network address with a '.' at the end</param>
        /// <param name="min">Minimum number for range</param>
        /// <param name="max">Maximum number for range</param>
        /// <returns>List of IP addresses</returns>
        private List<string> GenerateIPList(string baseIP, int min, int max)
        {
            return Enumerable.Range(
                min,
                (max - min + 1)
            ).Select(i => baseIP + i.ToString()).ToList();
        }

        /// <summary>
        /// Pings a specified IP n times and returns list of successful ping replies.
        /// </summary>
        /// <param name="pingSender">Ping sender object</param>
        /// <param name="ip">IP to be pinged</param>
        /// <param name="timeout">Ping timeout</param>
        /// <param name="n">Number of attempts</param>
        /// <returns>List of successful ping replies</returns>
        public List<PingReply> PingN(int n, Ping pingSender, string ip, int timeout)
        {
            List<PingReply> replies = new List<PingReply>();
            PingReply pingReply;
            for (int i = 0; i < n; i++)
            {
                try
                {
                    pingReply = pingSender.Send(ip, timeout);
                }
                catch (Exception)
                {
                    // This is from a hackathon. If this gets used outside of the context of a hackathon,
                    // properly handle all possible Exceptions.
                    continue;
                }
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
        public Dictionary<string, long> Scan(int timeout, int attemptsPerIP)
        {
            Dictionary<string, long> foundIPs = new Dictionary<string, long>();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            scanCount = 0;
            Ping pingSender = new Ping();

            foreach (var ip in ipList)
            {
                scanCount++;
                List<PingReply> replies = PingN(attemptsPerIP, pingSender, ip, timeout);
                if (replies.Count() > 0)
                { 
                    foundIPs.Add(ip, replies.Sum(r => r.RoundtripTime));
                }
            }

            sw.Stop();
            return foundIPs;
        }
    }
}
