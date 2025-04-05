using System.Drawing.Imaging;

namespace ShortcutMaker
{
    public partial class OptionsForm : Form
    {
        bool isLoading = true;
        public OptionsForm()
        {
            InitializeComponent();
            comboBoxImageLayout.SelectedIndex = 4;
        }

        private void ReturnButton_Click(object sender, EventArgs e) => Form1.BaseForm.OpenChildForm(Form1.BaseForm.mainForm);
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Form1.BaseForm.SaveSettings();
            File.Delete(Form1.backgroundFilePath);
            panelBackgroundImage.BackgroundImage.Save(Form1.backgroundFilePath, ImageFormat.Png);
            saveButton.BackColor = Color.Transparent;
        }

        private void ColorPicker_MouseHoverColor_ColorChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            UnsavedChanges();
            colorPicker_MouseHover.SetColor(Color.FromArgb((int)numericUpDown_MouseHover.Value, colorPicker_MouseHover.SelectedColor));
            ShortcutButtonControl.HoverColor = colorPicker_MouseHover.SelectedColor;
            RefreshItems();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            UnsavedChanges();
            colorPicker_MouseHover.SetColor(Color.FromArgb((int)numericUpDown_MouseHover.Value, colorPicker_MouseHover.SelectedColor));
            ShortcutButtonControl.HoverColor = colorPicker_MouseHover.SelectedColor;
            RefreshItems();
        }
        private void NumericUpDown_Size_ValueChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            UnsavedChanges();
            Settings.ShortcutButtonControl_Size = (int)numericUpDown_Size.Value;
            ShortcutButtonControl.SCSize = new(Settings.ShortcutButtonControl_Size, Settings.ShortcutButtonControl_Size);
            RefreshItems();
        }

        private void UnsavedChanges()
        {
            Form1.BaseForm.Text = "Shortcut Maker *";
            saveButton.BackColor = Color.IndianRed;
        }

        private static void RefreshItems()
        {
            foreach (ShortcutButtonControl button in Form1.BaseForm.mainForm.panel.Controls)
                button.RefreshShortcut();
            foreach (ShortcutControl button in Form1.BaseForm.ShortcutList)
                button.ChangeSize(new(Settings.ShortcutButtonControl_Size, Settings.ShortcutButtonControl_Size));
            Form1.BaseForm.mainForm.panel.Refresh();
        }

        public void FinishLoadingData() => isLoading = false;

        private void PanelBackgroundImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new()
            {
                Multiselect = false,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.tiff;*.tif;*.jpe;*.jfif;*.bmp;*.dib;*.rle;*.gif;"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(openFileDialog.FileName);
                    Form1.BaseForm.mainForm.panel.BackgroundImage = panelBackgroundImage.BackgroundImage = new Bitmap(img);
                    img.Dispose();
                }

                if (!isLoading)
                    UnsavedChanges();
            }
        }

        private void ColorPickerPanelBackground_ColorChanged(object sender, EventArgs e)
        {
            Form1.BaseForm.ChangeAplicationBackgroundColor(colorPickerPanelBackground.SelectedColor);
        }

        public void ChangeIconsColor(Color color)
        {
            returnButton.FlatAppearance.MouseOverBackColor = color;
            saveButton.FlatAppearance.MouseOverBackColor = color;

            returnButton.BackgroundImage = Settings.ReturnIcon;
            saveButton.BackgroundImage = Settings.SaveIcon;
        }

        private void CheckBoxBackgroundUseImage_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundUseImageChanged();

            if (!isLoading)
                UnsavedChanges();
        }

        public void BackgroundUseImageChanged()
        {
            if (checkBoxBackgroundUseImage.Checked)
            {
                panelBackgroundImage.Visible = true;
                Form1.BaseForm.mainForm.panel.BackgroundImage = panelBackgroundImage.BackgroundImage;
            }
            else
            {
                panelBackgroundImage.Visible = false;
                Form1.BaseForm.mainForm.panel.BackgroundImage = null;
            }
        }

        private void ComboBoxImageLayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;

            Form1.BaseForm.mainForm.panel.BackgroundImageLayout = (ImageLayout)comboBoxImageLayout.SelectedIndex;
            UnsavedChanges();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonUpdate.Text = "Updating...";
            Form1.BaseForm.InstalUpdate();
        }
    }
}