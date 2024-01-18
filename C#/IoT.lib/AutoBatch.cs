using System;
using System.IO;
using System.Security.Principal;

public class AutoBatch
{
    private static string BatchFilePath = "example.bat";

    public static void CreateBatch()
    {
        try
        {
            File.WriteAllText(BatchFilePath, "");
            Console.WriteLine($"Batch file '{BatchFilePath}' created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

   public static void WriteBatch(string newContent)
    {
        try
        {
            File.AppendAllText(BatchFilePath, newContent);
            Console.WriteLine($"Batch file '{BatchFilePath}' updated successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public static void RunBatch()
    {
        try
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = BatchFilePath,
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