using System.Diagnostics;

namespace ShortcutMaker
{
    public partial class ShortcutButtonControl : UserControl
    {
        public int Id { get; set; }
        private string shortcutPath = "";
        private bool isShortcutAnimated;
        private int shortcutFontSize;

        public static Color HoverColor { get; set; } = Color.FromArgb(30, 0, 0, 0);
        public static Size SCSize { get; set; } = new(80, 80);
        public void RefreshShortcut()
        {
            Size = SCSize;
            label1.BackColor = HoverColor;
        }

        public ShortcutButtonControl(int id, string title, string path, bool isIconVisible, Color titleColor, Color backgroundColor, Bitmap icon, int fontSize, bool isAnimated)
        {
            InitializeComponent();
            Id = id;
            ChangeShortcutData(title, path, isIconVisible, titleColor, backgroundColor, icon, fontSize, isAnimated);
        }
        public void ChangeShortcutData(string title, string path, bool isIconVisible, Color titleColor, Color backgroundColor, Bitmap icon, int fontSize, bool isAnimated)
        {
            label1.Text = title;
            label1.ForeColor = titleColor;
            pictureBox1.Image = icon;
            shortcutPath = path;
            pictureBox1.Visible = isIconVisible;
            BackColor = backgroundColor;
            if (isIconVisible)
            {
                label1.Parent = pictureBox1;
                label1.Location = new Point(0, 0);
                label1.Padding = new Padding(0, 0, 0, 10);
                label1.TextAlign = ContentAlignment.BottomCenter;
            }
            else
            {
                label1.Parent = this;
                label1.Location = new Point(3, 3);
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.Padding = new Padding(0);
            }
            isShortcutAnimated = isAnimated;
            shortcutFontSize = fontSize;
            label1.Font = new Font("Segoe UI", shortcutFontSize, FontStyle.Bold);
            label1.BackColor = HoverColor;
            Size = SCSize;
        }
        private void ShortcutButtonControl_MouseHover(object sender, EventArgs e) => ShortcutButtonControl_MouseActions(true);
        private void ShortcutButtonControl_MouseLeave(object sender, EventArgs e) => ShortcutButtonControl_MouseActions(false);
        private void ShortcutButtonControl_MouseActions(bool isOver)
        {
            label1.BackColor = isOver ? Color.FromArgb(0, 0, 0, 0) : HoverColor;
            if (!isShortcutAnimated)
                return;
            pictureBox1.SizeMode = isOver ? PictureBoxSizeMode.CenterImage : PictureBoxSizeMode.StretchImage;
            if (pictureBox1.Visible)
                return;
            label1.Font = new Font("Segoe UI", shortcutFontSize, isOver ? (FontStyle.Bold | FontStyle.Underline) : FontStyle.Bold);
        }

        private void ShortcutButtonControl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(shortcutPath))
            {
                MessageBox.Show($"Path for shortcut named \"{label1.Text}\" is not set yet.");
                return;
            }

            try
            {
                Process process = new()
                {
                    StartInfo = new ProcessStartInfo(shortcutPath)
                    {
                        UseShellExecute = true
                    }
                };
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Shortcut named \"{label1.Text}\" have invalid path!\nPath: {shortcutPath}\n\nError: {ex}");
            }
        }
    }
}
