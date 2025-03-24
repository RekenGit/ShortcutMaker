namespace ShortcutMaker
{
    public partial class MainForm : Form
    {
        public bool isWindowLocked = false;
        private Size lastSize;
        public MainForm()
        {
            InitializeComponent();
        }
        private void OpacityScrollBar_Scroll(object sender, ScrollEventArgs e) => Form1.BaseForm.Opacity = opacityScrollBar.Value / 100.0;
        private void LockWindowButton_Click(object sender, EventArgs e)
        {
            isWindowLocked = !isWindowLocked;
            if (isWindowLocked)
            {
                lastSize = Size;
                optionsButton.Visible = editButton.Visible = false;
                Form1.BaseForm.MinimumSize = new Size(226, 171);
                //Form1.BaseForm.Size = new Size(Width, Height - 38);
                Form1.BaseForm.Location = new Point(Form1.BaseForm.Location.X + 8, Form1.BaseForm.Location.Y + 32);
                Form1.BaseForm.Opacity = opacityScrollBar.Value / 100.0;
                Form1.BaseForm.TopMost = opacityScrollBar.Visible = true;
                lockWindowButton.BackgroundImage = Settings.PadlockOpen;
                Form1.BaseForm.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                optionsButton.Visible = editButton.Visible = true;
                Form1.BaseForm.FormBorderStyle = FormBorderStyle.Sizable;
                Form1.BaseForm.MinimumSize = new Size(242, 212);
                Form1.BaseForm.Location = new Point(Form1.BaseForm.Location.X - 8, Form1.BaseForm.Location.Y - 32);
                lockWindowButton.BackgroundImage = Settings.PadlockClose;
                Form1.BaseForm.Opacity = 1.0;
                Form1.BaseForm.TopMost = opacityScrollBar.Visible = false;
                Size = lastSize;
            }
        }

        private void OptionsButton_Click(object sender, EventArgs e) => Form1.BaseForm.OpenChildForm(Form1.BaseForm.optionsForm);

        private void EditButton_Click(object sender, EventArgs e) => Form1.BaseForm.OpenChildForm(Form1.BaseForm.editForm);

        public void ChangeIconsColor(Color color)
        {
            lockWindowButton.FlatAppearance.MouseOverBackColor = color;
            optionsButton.FlatAppearance.MouseOverBackColor = color;
            editButton.FlatAppearance.MouseOverBackColor = color;

            lockWindowButton.BackgroundImage = isWindowLocked ? Settings.PadlockOpen : Settings.PadlockClose;
            optionsButton.BackgroundImage = Settings.OptionsIcon;
            editButton.BackgroundImage = Settings.EditIcon;
        }
    }
}
