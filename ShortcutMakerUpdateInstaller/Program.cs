using System.Diagnostics;
using System.Net;

string githubProjectLink = "https://raw.githubusercontent.com/RekenGit/ShortcutMaker/master/ShortcutMaker/UpdateFiles/";
string[] filesToUpdate = ["ShortcutMakerUpdate.deps.json", "ShortcutMakerUpdate.dll", "ShortcutMakerUpdate.exe", "ShortcutMakerUpdate.pdb", "ShortcutMakerUpdate.runtimeconfig.json"];
string[] filesToDownload = ["Microsoft.Win32.SystemEvents.dll", "ShortcutMaker.deps.json", "ShortcutMaker.dll", "ShortcutMaker.exe", "ShortcutMaker.pdb", "ShortcutMaker.runtimeconfig.json", "System.Drawing.Common.dll", "System.Private.Windows.Core.dll", "runtimes/win/lib/net8.0/Microsoft.Win32.SystemEvents.dll"];
string message = "Start\n";
try
{
    WebClient c = new();
    c.DownloadProgressChanged += (se, e) =>
    {
        Console.Clear();
        Console.Write($"{e.BytesReceived / 1024 / 1024}MB / {e.TotalBytesToReceive / 1024 / 1024}MB");
    };
    foreach (string file in filesToUpdate)
        File.Delete(Directory.GetCurrentDirectory() + $"\\{file}");

    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\runtimes\\win\\lib\\net8.0");
    await DownloadFiles(c);
    await End();
}
catch (Exception e) 
{
    using (StreamWriter sw = new("error.txt"))
    {
        sw.WriteLine(message);
        sw.WriteLine("\n\n");
        sw.WriteLine(e.Message);
        sw.WriteLine("\n\n");
        sw.WriteLine(e.StackTrace);
    }
}

async Task DownloadFiles(WebClient c)
{
    string filePath = Directory.GetCurrentDirectory() + "\\";
    foreach (string file in filesToDownload)
    {
        message += $"Downloading file...  {githubProjectLink + file}\n";
        await c.DownloadFileTaskAsync(githubProjectLink + file, filePath + file);
    }
}

async Task End()
{
    await Task.Delay(3000);
    Process process = new()
    {
        StartInfo = new ProcessStartInfo(Directory.GetCurrentDirectory() + "\\ShortcutMaker.exe")
        {
            UseShellExecute = true
        }
    };
    process.Start();
    Process.GetCurrentProcess().Kill();
}