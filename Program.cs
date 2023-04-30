using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Net;


public class Program {
    
    public static WebClient client = new WebClient();

    public static string filePath = "";
    
    public static void StopBlocking(string filePath)
    {
        if(File.Exists(filePath+".bak"))
        {
            Console.WriteLine("Restoring original hosts file!");
            try {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                File.Move(filePath+".bak",filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    public static void StartBlocking(string filePath)
    {
        if (File.Exists(filePath+".bak"))
        {
            Console.WriteLine("Blocking websites...");
        }

        Console.WriteLine("Starting hhadblock");

        if(File.Exists(filePath))
        {
            try {
                File.Copy(filePath,filePath+".bak");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Downloading latest hosts file!");
            try {
                client.DownloadFile("https://www.github.developerdan.com/hosts/lists/ads-and-tracking-extended.txt",filePath);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

public static void Init()
{
    if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
    {
        filePath = "/etc/hosts";
        Console.WriteLine("Linux detected!");
    }
    if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
    {
        filePath = "/etc/hosts";
        Console.WriteLine("macOS detected!");
    }
    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    {
        filePath = "C:\\Windows\\system32\\drivers\\etc\\hosts";
        Console.WriteLine("Windows detected!");
    }
    var ask = Console.ReadLine();

    if (ask == "block")
    {
        StartBlocking(filePath);
    }
    else {
        StopBlocking(filePath);
    }
    
}

private static void Main()
{
     Console.WriteLine("Running...");   

     Init();
}

}