string ip = "127.0.0.1";

if (IoTCheck.PingTest(ip))
{
    Console.WriteLine("Ping Success");
}
else
{
    Console.WriteLine("Ping Fail");
}