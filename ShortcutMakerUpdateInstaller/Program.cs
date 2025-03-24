using System.Diagnostics;
using System.Net;

string message = "Start\n";
try
{
    string githubProjectLink = "https://github.com/RekenGit/ShortcutMaker/tree/master/ShortcutMaker/UpdateFiles/";
    string[] filesToUpdate = { "ShortcutMakerUpdate.deps.json", "ShortcutMakerUpdate.dll", "ShortcutMakerUpdate.exe", "ShortcutMakerUpdate.pdb", "ShortcutMakerUpdate.runtimeconfig.json" };
    string[] filesToDownload = { "Microsoft.Win32.SystemEvents.dll", "ShortcutMaker.deps.json", "ShortcutMaker.dll", "ShortcutMaker.exe", "ShortcutMaker.pdb", "ShortcutMaker.runtimeconfig.json", "System.Drawing.Common.dll", "System.Private.Windows.Core.dll", "runtimes/win/lib/net8.0/Microsoft.Win32.SystemEvents.dll" };


    var c = new WebClient();
    c.DownloadProgressChanged += (se, e) =>
    {
        Console.Clear();
        Console.Write($"{e.BytesReceived / 1024 / 1024}MB / {e.TotalBytesToReceive / 1024 / 1024}MB");
    };
    message += "#1\n";
    foreach (string file in filesToUpdate)
        File.Delete(Directory.GetCurrentDirectory() + $"\\{file}");
    message += "#2\n";

    var filePath = Directory.GetCurrentDirectory() + "\\";
    /*foreach (string file in filesToDownload)
    {
        message += $"Downloading file...  {githubProjectLink + file}\n";
        await c.DownloadFileTaskAsync(githubProjectLink + file, filePath + file);
    }*/
    await c.DownloadFileTaskAsync("https://github.com/RekenGit/ShortcutMaker/tree/master/ShortcutMakerInstaller/Debug/ShortcutMakerInstaller.msi", filePath + "ShortcutMakerInstaller.msi");

    //try { Process.Start(filePath + "ShortcutMakerInstaller.msi"); } catch { }
    Process process = new()
    {
        StartInfo = new ProcessStartInfo(filePath + "ShortcutMakerInstaller.msi")
        {
            UseShellExecute = true
        }
    };
    process.Start();

    message += "#4\n";
    Process.GetCurrentProcess().Kill();
}
catch (Exception e) 
{
    using (StreamWriter sw = new("error.txt"))
    {
        sw.WriteLine(message);
        sw.WriteLine("\n-----------------------------------------------------------------------------------\n");
        sw.WriteLine(e.Message);
        sw.WriteLine("\n-----------------------------------------------------------------------------------\n");
        sw.WriteLine(e.StackTrace);
    }
}