using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void imageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imageButton3_Click(object sender, EventArgs e)
        {
            Form1.BaseForm.RemoveShortcut(ShortcutId);
            Close();
        }

        private void ShortcutRightClickMenu_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
    }
}
