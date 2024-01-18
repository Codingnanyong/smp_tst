using System;
using System.Net;
using System.Linq;
using System.Net.NetworkInformation;

public class IoTCheck{
    public static bool PingTest(string ip)
    {
        using (Ping ping = new Ping())
        {
            try
            {
                PingReply reply = ping.Send(ip);
                return reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                return false;
            }
            finally
            {
                if (ping != null)
                {
                    ping.Dispose();
                }
            }
        }
    }
}