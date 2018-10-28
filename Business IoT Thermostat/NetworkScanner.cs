using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Business_IoT_Thermostat
{
    class NetworkScanner
    { 
        readonly int minInRange, maxInRange;
        int scanCount;

        readonly List<string> ipList;
        
        // Filters out connections to self
        const int MIN_RESPONSE_TIME = 2;

        /// <summary>
        /// Creates a Network Scanner
        /// </summary>
        /// <param name="baseIP">Base string of IP address to build upon. Example: "255.255.255."</param>
        /// <param name="minInRange">Minimum value for 4th segment of IP address</param>
        /// <param name="maxInRange">Maximum value for 4th segment of IP address</param>
        public NetworkScanner(string baseIP, int minInRange, int maxInRange)
        {
            ipList = GenerateIPList(baseIP, minInRange, maxInRange);
            this.minInRange = minInRange;
            this.maxInRange = maxInRange;
        }

        /// <summary>
        /// Creates a Network Scanner
        /// </summary>
        /// <param name="baseIP">Base string of IP address to build upon. Example: "255.255.255."</param>
        /// <param name="parts">Values for the 4th segment of IP address. Each value x must fit: 0 <= x <= 255</param>
        public NetworkScanner(string baseIP, int[] parts)
        {
            ipList = parts.Distinct().Select(i => baseIP + i.ToString()).ToList();
        }

        /// <summary>
        /// Generates a list of IP addresses prefixed with `baseIP` from "`baseIP`.`min`" through "`baseIP`.`max`"
        /// </summary>
        /// <param name="baseIP">First three segments of the network address with a '.' at the end</param>
        /// <param name="min">Minimum number for range. Must fit: 0 <= `min` <= max</param>
        /// <param name="max">Maximum number for range. Must fit: min <= max <= 255</param>
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
        /// <param name="n">Number of attempts</param>
        /// <param name="pingSender">Ping sender object</param>
        /// <param name="ip">IP to be pinged</param>
        /// <param name="timeout">Ping timeout</param>
        /// <returns>List of successful ping replies</returns>
        public async Task<List<PingReply>> PingN(int n, Ping pingSender, string ip, int timeout)
        {
            List<PingReply> replies = new List<PingReply>();
            PingReply pingReply;
            for (int i = 0; i < n; i++)
            {
                try
                {
                    pingReply = await pingSender.SendPingAsync(ip, timeout);
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
        /// Scans network, returns dictionary of IP addresses and their response times
        /// </summary>
        /// <param name="timeout">Ping timeout</param>
        /// <param name="attemptsPerIP">Max pings per IP address</param>
        /// <returns>Dictionary of IP addresses and their response times</returns>
        public async Task<Dictionary<string, long>> Scan(int timeout, int attemptsPerIP)
        {
            Dictionary<string, long> foundIPs = new Dictionary<string, long>();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            scanCount = 0;
            Ping pingSender = new Ping();

            foreach (var ip in ipList)
            {
                Console.WriteLine(ip);
                scanCount++;
                List<PingReply> replies = await PingN(attemptsPerIP, pingSender, ip, timeout);
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
