using System.Diagnostics;
using System.Net;


try
{
    string githubProjectLink = "https://github.com/RekenGit/ShortcutMaker/tree/master/";

    var c = new WebClient();
    c.DownloadProgressChanged += (se, e) =>
    {
        Console.Clear();
        Console.Write($"{e.BytesReceived / 1024 / 1024}MB / {e.TotalBytesToReceive / 1024 / 1024}MB");
    };
    File.Delete(Directory.GetCurrentDirectory()+ "\\DiscordReport.exe");
    File.Delete(Directory.GetCurrentDirectory()+ "\\Newtonsoft.Json.dll");
    var filePath = Directory.GetCurrentDirectory() + "\\";
    await c.DownloadFileTaskAsync(githubProjectLink + "DiscordReport.exe", filePath + "DiscordReport.exe");
    await c.DownloadFileTaskAsync(githubProjectLink + "Newtonsoft.Json.dll", filePath + "Newtonsoft.Json.dll");

    try { Process.Start(filePath + "DiscordReport.exe"); } catch { }
    Process.GetCurrentProcess().Kill();
}
catch (Exception e) { Console.Write(e); }