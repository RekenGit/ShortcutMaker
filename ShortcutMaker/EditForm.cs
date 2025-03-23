namespace ShortcutMaker
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e) 
        {
            if (Form1.BaseForm.ShortcutList.Count >= 1)
                Form1.BaseForm.SaveShortcuts();

            Form1.BaseForm.OpenChildForm(Form1.BaseForm.mainForm);
        }
        private void AddButton_Click(object sender, EventArgs e) => Form1.BaseForm.AddShortcut();

        public void ChangeIconsColor(Color color)
        {
            addButton.FlatAppearance.MouseOverBackColor = color;
            returnButton.FlatAppearance.MouseOverBackColor = color;

            addButton.BackgroundImage = Settings.AddIcon;
            returnButton.BackgroundImage = Settings.ReturnIcon;
        }
    }
}
