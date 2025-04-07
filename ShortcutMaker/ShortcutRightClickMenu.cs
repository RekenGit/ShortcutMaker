namespace ShortcutMaker
{
    public partial class ShortcutRightClickMenu : Form
    {
        public int ShortcutId { get; set; }

        public ShortcutRightClickMenu()
        {
            InitializeComponent();
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            Form1.BaseForm.CloneShortcut(ShortcutId);
            Close();
        }
        ShortcutControl sc, editSC;
        private void imageButton2_Click(object sender, EventArgs e)
        {
            imageButton1.Visible = imageButton2.Visible = imageButton3.Visible = false;
            sc = Form1.BaseForm.ShortcutList.First(x => x.Id == ShortcutId);
            editSC = new(sc);
            editSC.Id = ShortcutId;
            editSC.IsAMenu = true;
            Size newSize = new Size(editSC.Size.Width + 4, editSC.Size.Height + 4);
            MinimumSize = Size = newSize;
            editSC.Parent = this;
            editSC.Dock = DockStyle.Fill;
        }

        private void imageButton3_Click(object sender, EventArgs e)
        {
            Close();
            if (MessageBox.Show($"Are you sure you want to remove this shortcut?", "Remove Shortcut", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
                Form1.BaseForm.RemoveShortcut(ShortcutId);
        }

        private void ShortcutRightClickMenu_Deactivate(object sender, EventArgs e)
        {
            editSC?.SetChangesToOrginal();
            //MessageBox.Show($"{Location} | {Cursor.Position} | {Width}, {Height} \n " +
                //$"{Location.X <= Cursor.Position.X} | {Location.X + Width >= Cursor.Position.X} | {Location.Y <= Cursor.Position.Y} | {Location.Y + Height >= Cursor.Position.Y} \n" +
                //$"{Location.X} <= {Cursor.Position.X} | {Location.X + Width} >= {Cursor.Position.X} | {Location.Y} <= {Cursor.Position.Y} | {Location.Y + Height} >= {Cursor.Position.Y}");
            if (!(Location.X <= Cursor.Position.X &&
                Location.X + Width >= Cursor.Position.X &&
                Location.Y <= Cursor.Position.Y &&
                Location.Y + Height >= Cursor.Position.Y))
            Close();
        }
    }
}
