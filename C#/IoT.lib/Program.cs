IotDevice device = new IotDevice
{
    DeviceId = "12345",
    Ip = "127.0.0.1"
};

if (IoTCheck.PingTest(device.Ip))
{
    Console.WriteLine("Ping Success");

    AutoBatch.CreateBatch(device);

    AutoBatch.WriteBatch(
        device,
        "@echo off\r\n" +
        "echo This is the updated batch file content.\r\n" +
        "This Device Ip is $"{device.Ip}"\r\n"+
        "pause");

    AutoBatch.RunBatchAsAdmin(device);
}
else
{
    Console.WriteLine("Ping Fail");
}