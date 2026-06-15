using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace EasyLevel
{
    public class AnalyzeLogs
    {
        string[] logs = {
                "203.17.92.14 -- 2026-03-18T04:12:55Z, 200, -",
                "203.22.14.88 -- 2026-03-18T04:13:10Z, 304, -",
                "172.58.22.91 -- 2026-03-18T04:13:25Z, 500, InternalServerError",
                "203.22.14.88 -- 2026-03-18T04:13:33Z, 403, AccessDenied",
                "203.22.14.88 -- 2026-03-18T04:13:02Z, 503, TargetHealthCheckFailed",
                "203.17.92.14 -- 2026-03-18T04:13:07Z, 504, DatabaseTimeout",
                "198.51.100.77 -- 2026-03-18T04:14:11Z, 401, Unauthorized",
                "203.22.14.88 -- 2026-03-18T04:14:22Z, 400, BadRequest",
                "203.0.113.19 -- 2026-03-18T04:14:35Z, 404, NotFound",
                "203.17.92.14 -- 2026-03-18T04:14:48Z, 201, Created",
                "198.51.100.22 -- 2026-03-18T04:15:03Z, 204, -",
                "10.0.5.12 -- 2026-03-18T04:15:17Z, 502, BadGateway",
                "192.0.2.88 -- 2026-03-18T04:15:29Z, 503, ServiceUnavailable",
                "203.22.14.88 -- 2026-03-18T04:15:41Z, 500, LambdaUnhandledException",
                "198.51.100.77 -- 2026-03-18T04:15:55Z, 200, -"
            };
        public static void Run(string[] logs)
        {           
            if (logs == null || logs.Length == 0) { return; }
            
            List<string> ipAddress = new List<string>();
            List<int> statusCodes = new List<int>();            
            int totalErrors4xx = 0;
            int totalErrors5xx = 0;

            foreach (string log in logs)
            {
                string[] parts = log.Split(" -- ");

                string ip = parts[0].Trim();    // IP address
                ipAddress.Add(ip);
                string content = parts[1].Trim();       // Timestamp, status code, and error message                                      
                // Extract the status code from the content
                int code = Convert.ToInt32(content.Split(",")[1].Trim()); // Extract the status code
                statusCodes.Add(code);
            }

            //Console.WriteLine(statusCodes.Count);
            for (int i = 0; i < statusCodes.Count; i++)
            {
                if (statusCodes[i] >= 400 && statusCodes[i] < 500)
                {
                    totalErrors4xx++;
                }
                else if (statusCodes[i] >= 500 && statusCodes[i] < 600)
                {
                    totalErrors5xx++;
                }
            }

            // Count the occurrences of each IP address and get the top 3
            var top3IPs = ipAddress
                            .GroupBy(ip => ip)
                            .OrderByDescending(group => group.Count())
                            .Take(3)
                            .Select(group => new { IP = group.Key, Count = group.Count() })
                            .ToList();

            Console.WriteLine("Top 3 IP addresses:");
            foreach (var item in top3IPs)
            {
                Console.WriteLine($"{item.IP} : {item.Count} time(s)");
            }

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("totalErrors4xx: " + totalErrors4xx);
            Console.WriteLine("totalErrors5xx: " + totalErrors5xx);
        }
    }
}
