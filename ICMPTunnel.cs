using System;
using System.Net.NetworkInformation;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter the remote host or IP: ");
        string? host = Console.ReadLine();

        Console.Write("Enter the payload/text: ");
        string? data = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(host)) { Console.WriteLine("Host required."); return; }

        byte[] buffer = string.IsNullOrEmpty(data) ? Array.Empty<byte>() : Encoding.ASCII.GetBytes(data);
        int timeout = 2000;

        using Ping ping = new Ping();
        try
        {
            PingReply reply = ping.Send(host, timeout, buffer);
            Console.WriteLine($"Status={reply.Status}, RTT={reply.RoundtripTime}ms, Addr={reply.Address}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ping failed: {ex.Message}");
        }
    }
}