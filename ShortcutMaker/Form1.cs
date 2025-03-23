using System.Diagnostics;
using System.Net;

namespace ShortcutMaker
{
    public partial class Form1 : Form
    {
        private readonly string version = "1.0";
        private readonly string githubProjectLink = "https://github.com/RekenGit/ShortcutMaker/tree/master/";
        string[] filesToDownload = { "ShortcutMakerUpdate.deps.json", "ShortcutMakerUpdate.dll", "ShortcutMakerUpdate.exe", "ShortcutMakerUpdate.pdb", "ShortcutMakerUpdate.runtimeconfig.json" };

        public static Form1 BaseForm { get; private set; }

        public MainForm mainForm = new();
        public OptionsForm optionsForm = new();
        public EditForm editForm = new();

        public static readonly string applicationDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ShortcutMaker\\";
        public static readonly string backgroundFilePath = applicationDataDirectory + "Background.png";
        public List<ShortcutControl> ShortcutList { get; private set; } = [];
        public List<ShortcutButtonControl> ShortcutButtonList { get; private set; } = [];

        public Form1()
        {
            BaseForm = this;
            InitializeComponent();

            if (!Directory.Exists(applicationDataDirectory))
                Directory.CreateDirectory(applicationDataDirectory);
            if (!Directory.Exists(applicationDataDirectory + "\\Icons"))
                Directory.CreateDirectory(applicationDataDirectory + "\\Icons");
            if (File.Exists(backgroundFilePath))
            {
                Image img = Image.FromFile(backgroundFilePath);
                mainForm.panel.BackgroundImage = optionsForm.panelBackgroundImage.BackgroundImage = new Bitmap(img);
                img.Dispose();
            }
            LoadSettingsFromFile();
            LoadShortcutsFromFile();
            OpenChildForm(mainForm);
            optionsForm.labelVersionInstaled.Text = version;
            CheckForUpdate();
        }

        private async void CheckForUpdate()
        {
            try
            {
                string newVersion = version;
                WebClient c = new();
                var s = await c.DownloadStringTaskAsync(githubProjectLink + "Version.txt");
                if (s.Contains("~"))
                {
                    string[] arr = s.Split('~');
                    newVersion = arr[1];
                }
                if (float.Parse(newVersion.Replace('.', ',')) > float.Parse(version.Replace('.', ',')))
                {
                    optionsForm.buttonUpdate.Text = $"Update to {newVersion}";
                    optionsForm.buttonUpdate.Enabled = true;
                    MessageBox.Show("New version is available!\nGo to settings tab and Update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        public async void InstalUpdate()
        {
            if (Directory.Exists(Directory.GetCurrentDirectory() + "\\update")) Directory.Delete(Directory.GetCurrentDirectory() + "\\update", true);

            try
            {
                WebClient c = new();
                c.DownloadProgressChanged += (se, e) =>
                {
                    optionsForm.labelInstalInfo.Text = $"{e.BytesReceived / 1024 / 1024}MB / {e.TotalBytesToReceive / 1024 / 1024}MB";
                };
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\update");
                string filePath = Directory.GetCurrentDirectory() + "\\update\\";
                foreach (string file in filesToDownload)
                    await c.DownloadFileTaskAsync(githubProjectLink + "UpdateInstaller/UpdateFiles/" + file, filePath + "\\" + file);
                try { Process.Start(filePath + "\\ShortcutMakerUpdate.exe"); } catch { }
                Process.GetCurrentProcess().Kill();
            }
            catch { }
        }

        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            activeForm?.Hide();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            viewPanel.Controls.Add(childForm);
            viewPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Shortcut Methods
        public void AddShortcut()
        {
            ShortcutControl sc = new();
            ShortcutList.Add(sc);
            editForm.panel.Controls.Add(sc);

            ShortcutButtonControl scB = new(sc.Id, sc.Title, sc.Path, sc.IsIconVisible, sc.TitleColor, sc.BackgroundColor, sc.ShortcutIcon, sc.FontSize, sc.IsAnimated);
            ShortcutButtonList.Add(scB);
            mainForm.panel.Controls.Add(scB);
        }
        public void AddShortcut(string id, string title, string isIconVisible, string titleColor, string backgroundColor, string backgroundAlpha, string fontSize, string isAnimated, string path)
        {
            ShortcutControl sc = new(id, title, isIconVisible, titleColor, backgroundColor, backgroundAlpha, fontSize, isAnimated, path);
            ShortcutList.Add(sc);
            editForm.panel.Controls.Add(sc);

            ShortcutButtonControl scB = new(sc.Id, sc.Title, sc.Path, sc.IsIconVisible, sc.TitleColor, sc.BackgroundColor, sc.ShortcutIcon, sc.FontSize, sc.IsAnimated);
            ShortcutButtonList.Add(scB);
            mainForm.panel.Controls.Add(scB);
        }

        public void RemoveShortcut(int id)
        {
            ShortcutControl sc = ShortcutList.First(x => x.Id == id);
            editForm.panel.Controls.Remove(sc);
            ShortcutList.Remove(sc);

            ShortcutButtonControl scB = ShortcutButtonList.First(x => x.Id == id);
            mainForm.panel.Controls.Remove(scB);
            ShortcutButtonList.Remove(scB);
        }

        public void ChangeShortcut(int id)
        {
            ShortcutControl sc = ShortcutList.First(x => x.Id == id);
            ShortcutButtonControl scB = ShortcutButtonList.First(x => x.Id == id);
            scB.ChangeShortcutData(sc.Title, sc.Path, sc.IsIconVisible, sc.TitleColor, sc.BackgroundColor, sc.ShortcutIcon, sc.FontSize, sc.IsAnimated);
            //ShortcutViewPanel.Controls.Clear();
            //ShortcutViewPanel.Controls.AddRange(shortcutButtonList.ToArray());
            mainForm.panel.Refresh();
        }
        #endregion

        #region FileSaved
        private void LoadSettingsFromFile()
        {
            if (!File.Exists(applicationDataDirectory + "config.cfg"))
            {
                SaveSettings();
                return;
            }
            using (StreamReader sr = new(applicationDataDirectory + "config.cfg"))
            {
                Dictionary<string, object> settings = Settings.GetDictionaryFromCFGFile(sr.ReadToEnd());

                Size = (Size)settings["size"];
                mainForm.opacityScrollBar.Value = (int)settings["opacity"];
                optionsForm.numericUpDown_MouseHover.Value = (int)settings["hover-opacity"];
                optionsForm.colorPicker_MouseHover.SetColor(Color.FromArgb((int)optionsForm.numericUpDown_MouseHover.Value, (Color)settings["hover-color"]));
                ShortcutButtonControl.HoverColor = optionsForm.colorPicker_MouseHover.SelectedColor;
                optionsForm.numericUpDown_Size.Value = Settings.ShortcutButtonControl_Size = (int)settings["shortcut-size"] >= 80 || (int)settings["shortcut-size"] <= 120 ? (int)settings["shortcut-size"] : 80;
                ShortcutButtonControl.SCSize = new(Settings.ShortcutButtonControl_Size, Settings.ShortcutButtonControl_Size);
                optionsForm.checkBoxBackgroundUseImage.Checked = (bool)settings["background-image-bool"];
                optionsForm.BackgroundUseImageChanged();
                optionsForm.colorPickerPanelBackground.SetColor((Color)settings["background-color"]);
                ChangeAplicationBackgroundColor(optionsForm.colorPickerPanelBackground.SelectedColor);
                optionsForm.comboBoxImageLayout.SelectedIndex = (int)settings["background-layout"];
                mainForm.panel.BackgroundImageLayout = (ImageLayout)optionsForm.comboBoxImageLayout.SelectedIndex;

                optionsForm.FinishLoadingData();
            }
        }

        private void LoadShortcutsFromFile()
        {
            if (!File.Exists(applicationDataDirectory + "shortcut.cfg"))
                return;

            using (StreamReader sr = new(applicationDataDirectory + "shortcut.cfg"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        continue;
                    string[] shortcutData = line.Split(";");
                    AddShortcut(shortcutData[0], shortcutData[1], shortcutData[2], shortcutData[3], shortcutData[4], shortcutData[5], shortcutData[6], shortcutData[7], shortcutData[8]);
                }
            }
        }

        public void SaveShortcuts()
        {
            using (StreamWriter sw = new(applicationDataDirectory + "shortcut.cfg"))
            {
                foreach (ShortcutControl shortcut in ShortcutList)
                    sw.WriteLine($"{shortcut.Id};{shortcut.Title};{shortcut.IsIconVisible};{$"{shortcut.TitleColor.R:X2}{shortcut.TitleColor.G:X2}{shortcut.TitleColor.B:X2}"};{$"{shortcut.BackgroundColor.R:X2}{shortcut.BackgroundColor.G:X2}{shortcut.BackgroundColor.B:X2}"};{(int)shortcut.BackgroundColor.A};{shortcut.FontSize};{shortcut.IsAnimated};{shortcut.Path}");
            }
        }

        public void SaveSettings()
        {
            Text = "Shortcut Maker";
            if (!File.Exists(applicationDataDirectory + "config.cfg"))
                File.Create(applicationDataDirectory + "config.cfg").Close();

            using (StreamWriter sw = new(applicationDataDirectory + "config.cfg"))
            {
                Dictionary<string[], object> settings = new()
                {
                    {["Saved preferences", ""], null},
                    {["Aplication size (Min: Width=242, Height=212)", "size"], Size},
                    {["Aplication opacity in lock mode (10 - 100)", "opacity"], (int)mainForm.opacityScrollBar.Value},

                    {["Options", ""], null},
                    {["Mouse hover color", "hover-color"], optionsForm.colorPicker_MouseHover.SelectedColor},
                    {["Mouse hover opacity (0 - 255)", "hover-opacity"], (int)optionsForm.numericUpDown_MouseHover.Value},
                    {["Shortcut button size (80 - 120)", "shortcut-size"], Settings.ShortcutButtonControl_Size},
                    {["Aplication background should be a image", "background-image-bool"], optionsForm.checkBoxBackgroundUseImage.Checked},
                    {["Aplication background color", "background-color"], optionsForm.colorPickerPanelBackground.SelectedColor},
                    {["Background image layout (0 - 4)", "background-layout"], optionsForm.comboBoxImageLayout.SelectedIndex},
                    
                    //{["Test", ""], null},
                    //{["string", "1"], "test"},
                    //{["int", "2"], 123},
                    //{["decimal", "3"], 123.1m},
                    //{["bool", "4"], true},
                    //{["size", "5"], new Size(1, 20)},
                    //{["point", "6"], new Point(1, 20)},
                    //{["color", "7"], Color.AliceBlue},
                    //{["string[]", "8"], new[]{"1e", "2e", "3e"} },
                    //{["string[]", "9"], new List<string> {"1e", "2e", "3e"} },
                };
                sw.Write(Settings.GenerateCFGFileFromDictionary(settings));
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (activeForm == optionsForm || activeForm == editForm)
                        this.viewPanel.Focus();
                    break;
                case Keys.F1:
                    OpenChildForm(mainForm);
                    break;
                case Keys.F2:
                    OpenChildForm(editForm);
                    break;
                case Keys.F3:
                    OpenChildForm(optionsForm);
                    break;
                case Keys.Home:
                    mainForm.panel1.Visible = !mainForm.panel1.Visible;
                    Size = new Size(Size.Width + (mainForm.panel1.Visible ? 36 : -36), Size.Height);
                    break;
                case Keys.G:
                    if (mainForm.isWindowLocked && RectangleToScreen(Bounds).Contains(PointToScreen(Cursor.Position)))
                    {
                        Cursor.Current = Cursors.SizeAll;
                        BaseForm.Location = new Point(Cursor.Position.X - BaseForm.Width / 2, Cursor.Position.Y - BaseForm.Height / 2);
                    }
                    break;
            }

            if (activeForm == optionsForm)
                if (e.Control && e.KeyCode == Keys.S)
                    optionsForm.saveButton.PerformClick();
            else if (activeForm == editForm)
                if (e.KeyCode == Keys.Enter)
                    SaveShortcuts();

            //Cursor.Current = Cursors.Default;
        }
        #endregion

        public void ChangeAplicationBackgroundColor(Color color)
        {
            viewPanel.BackColor = mainForm.BackColor = optionsForm.BackColor = editForm.BackColor = color;
            Settings.isDarkMode = color.R * 0.2126 + color.G * 0.7152 + color.B * 0.0722 < 200;

            if (color.R * 0.2126 + color.G * 0.7152 + color.B * 0.0722 < 50)
            {
                //Dark
                mainForm.panel1.BackColor = optionsForm.panel1.BackColor = editForm.panel1.BackColor = Color.FromArgb(30, 255, 255, 255);
                optionsForm.panel.BackColor = editForm.panel.BackColor = Color.FromArgb(10, 255, 255, 255);
            }
            else
            {
                //Light
                mainForm.panel1.BackColor = optionsForm.panel1.BackColor = editForm.panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
                optionsForm.panel.BackColor = editForm.panel.BackColor = Color.FromArgb(10, 0, 0, 0);
            }

            Color c = Color.FromArgb(100, color);
            mainForm.ChangeIconsColor(c);
            editForm.ChangeIconsColor(c);
            optionsForm.ChangeIconsColor(c);
        }
    }
}
