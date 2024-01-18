IotDevice device = new IotDevice
{
    DeviceId = "12345",
    Ip = "127.0.0.1"
};

if (IoTCheck.PingTest(device.Ip))
{
    Console.WriteLine("Ping Success");

    AutoBatch.CreateBatch(device);

    string batchContent = $@"
@echo off
set DeviceIp={device.Ip}
echo This is the updated batch file content.
echo This Device Ip is %DeviceIp%
pause
";

    AutoBatch.WriteBatch(device, batchContent);

    AutoBatch.RunBatchAsAdmin(device);
}
else
{
    Console.WriteLine("Ping Fail");
}