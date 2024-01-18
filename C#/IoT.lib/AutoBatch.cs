using System;
using System.IO;
using System.Security.Principal;

public class AutoBatch
{
    public static void CreateBatch(IotDevice device)
    {
        if (device == null || string.IsNullOrEmpty(device.DeviceId))
        {
            Console.WriteLine("Invalid device information. Unable to create batch file.");
            return;
        }

        string batchFileName = $"{device.DeviceId}_example.bat";
        string batchFilePath = Path.Combine(Environment.CurrentDirectory, batchFileName);

        try
        {
            File.WriteAllText(batchFilePath, "");
            Console.WriteLine($"Batch file '{batchFilePath}' created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

   public static void WriteBatch(IotDevice device, string newContent)
    {
        if (device == null || string.IsNullOrEmpty(device.DeviceId))
        {
            Console.WriteLine("Invalid device information. Unable to write to batch file.");
            return;
        }

        string batchFileName = $"{device.DeviceId}_example.bat";
        string batchFilePath = Path.Combine(Environment.CurrentDirectory, batchFileName);

        try
        {
            File.AppendAllText(batchFilePath, newContent);
            Console.WriteLine($"Batch file '{batchFilePath}' updated successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public static void RunBatchAsAdmin(IotDevice device)
    {
        if (device == null || string.IsNullOrEmpty(device.DeviceId))
        {
            Console.WriteLine("Invalid device information. Unable to run batch file.");
            return;
        }

        string batchFileName = $"{device.DeviceId}_example.bat";
        string batchFilePath = Path.Combine(Environment.CurrentDirectory, batchFileName);

        try
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = batchFilePath,
                Verb = "runas", 
                UseShellExecute = true
            };

            System.Diagnostics.Process.Start(startInfo);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}