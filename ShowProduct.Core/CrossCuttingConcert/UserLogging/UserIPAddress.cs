using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ShowProduct.Core.CrossCuttingConcert.UserLogging
{
    public static class UserIPAddress
    {
        public static string FindUserIp(/*HttpContext context*/)
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");


            //return "";
            //var ipAddress = context.Connection.RemoteIpAddress.ToString();
            //if (ipAddress != null)
            //    ipAddress = context.Connection.RemoteIpAddress.ToString();
            //else if (context.Connection.RemoteIpAddress.ToString() != null && context.Connection.RemoteIpAddress.ToString().Length != 0)
            //    ipAddress = context.Connection.RemoteIpAddress.ToString();
            //else if (context.Connection.RemoteIpAddress.ToString().Length != 0)
            //    ipAddress = context.Connection.RemoteIpAddress.ToString();
            //return ipAddress;
        }
    }
}
