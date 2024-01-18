string ip = "127.0.0.1";

if (IoTCheck.PingTest(ip))
{
    Console.WriteLine("Ping Success");

    AutoBatch.CreateBatch();

    AutoBatch.WriteBatch( "@echo off\r\n" +"echo This is the updated batch file content.\r\n" +"pause");

    AutoBatch.RunBatch();
}
else
{
    Console.WriteLine("Ping Fail");
}