using System.Diagnostics;
using System.Net;

try
{
    string githubProjectLink = "https://github.com/RekenGit/ShortcutMaker/tree/master/ShortcutMaker/UpdateFiles/";
    string[] filesToUpdate = { "ShortcutMakerUpdate.deps.json", "ShortcutMakerUpdate.dll", "ShortcutMakerUpdate.exe", "ShortcutMakerUpdate.pdb", "ShortcutMakerUpdate.runtimeconfig.json" };
    string[] filesToDownload = { "runtimes/win/lib/net8.0/Microsoft.Win32.SystemEvents.dll", "Microsoft.Win32.SystemEvents.dll", "ShortcutMaker.deps.json", "ShortcutMaker.dll", "ShortcutMaker.exe", "ShortcutMaker.pdb", "ShortcutMaker.runtimeconfig.json", "System.Drawing.Common.dll", "System.Private.Windows.Core.dll" };

    var c = new WebClient();
    c.DownloadProgressChanged += (se, e) =>
    {
        Console.Clear();
        Console.Write($"{e.BytesReceived / 1024 / 1024}MB / {e.TotalBytesToReceive / 1024 / 1024}MB");
    };
    foreach (string file in filesToUpdate)
        File.Delete(Directory.GetCurrentDirectory()+ $"\\{file}");

    var filePath = Directory.GetCurrentDirectory() + "\\";
    foreach (string file in filesToDownload)
        await c.DownloadFileTaskAsync(githubProjectLink + file, filePath + file);
    
    try { Process.Start(filePath + "ShortcutMaker.exe"); } catch { }
    Process.GetCurrentProcess().Kill();
}
catch (Exception e) { Console.Write(e); }