using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
{
    string ssid = "Free-Wifi";
    string configFilePath = "/etc/hostapd/hostapd.conf";

System.IO.File.WriteAllText(configFilePath, $"interface=wlan0\nssid={ssid}\ndriver=nl80211\nhw_mode=g\nchannel=7\nlogger_syslog=-1\nlogger_syslog_level=2\nlogger_stdout=-1\nlogger_stdout_level=2\n");


    ExecuteCommand($"sudo hostapd {configFilePath}");

    Console.WriteLine("Pressione qualquer tecla para desativar o honeypot...");
    Console.ReadKey();
}

static void ExecuteCommand(string command)
{
    Process process = new Process
    {
        StartInfo = new ProcessStartInfo
        {
            FileName = "/bin/bash",
            Arguments = $"-c \"{command}\"",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        }
    };

    process.OutputDataReceived += (sender, e) =>
    {
        if (!string.IsNullOrEmpty(e.Data))
        {
            Console.WriteLine("STDOUT: " + e.Data);
        }
    };

    process.ErrorDataReceived += (sender, e) =>
    {
        if (!string.IsNullOrEmpty(e.Data))
        {
            Console.WriteLine("STDERR: " + e.Data);
        }
    };

    process.Start();
    process.BeginOutputReadLine();
    process.BeginErrorReadLine();
    process.WaitForExit();
}

}

