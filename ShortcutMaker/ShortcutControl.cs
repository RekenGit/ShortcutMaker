using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace ShortcutMaker
{
    public partial class ShortcutControl : UserControl
    {
        static int lastId = 0;
        public int Id { get; set; }
        public string Title { get; set; }
        public Bitmap ShortcutIcon { get; set; }
        public bool IsIconVisible { get; set; }
        public int FontSize { get; set; }
        public bool IsAnimated { get; set; }
        public string Path { get; set; }
        public Color TitleColor { get; set; }
        public Color BackgroundColor { get; set; }
        private bool isDoneCreating = false;
        private static readonly string iconDirectoryPath = Form1.applicationDataDirectory + "Icons\\";
        public ShortcutControl()
        {
            InitializeComponent();
            labelTitle.Parent = pictureBoxIcon;

            Id = ++lastId;
            labelTitle.Text = Title = "Shortcut";
            //ShortcutIcon = ResourceTemp.noImage;
            IsIconVisible = true;
            TitleColor = Color.White;
            FontSize = 10;
            IsAnimated = true;
            isDoneCreating = true;
            ShortcutIcon.Save(iconDirectoryPath + $"{Id}.png", ImageFormat.Png);
        }
        public ShortcutControl(string id, string title, string isIconVisible, string color, string backColor, string backAlpha, string fontSize, string isAnimated, string path)
        {
            if (!int.TryParse(id, out int _id))
            {
                MessageBox.Show($"Shortcut named \"{title}\" cant be loaded, Id is wrong!");
                return;
            }
            InitializeComponent();
            labelTitle.Parent = pictureBoxIcon;

            Id = _id;
            if (Id > lastId)
                lastId = Id;
            titleTextBox.Text = labelTitle.Text = Title = title;
            if (File.Exists(iconDirectoryPath + $"{Id}.png"))
            {
                Image img = Image.FromFile(iconDirectoryPath + $"{Id}.png");
                ShortcutIcon = new Bitmap(img);
                img.Dispose();
            }
            else
                MessageBox.Show("Usuń to w huj");
            //ShortcutIcon = ResourceTemp.noImage;
            pictureBoxIcon.Image = ShortcutIcon;
            if (Boolean.TryParse(isIconVisible, out bool _isIconVisible))
                pictureBoxIcon.Visible = checkBox1.Checked = IsIconVisible = _isIconVisible;
            TitleColor = labelTitle.ForeColor = (Color)new ColorConverter().ConvertFromString("#" + color);
            colorPickerPanelTitle.SetColor(TitleColor);
            if (!int.TryParse(backAlpha, out int _alpha))
            {
                MessageBox.Show($"Shortcut named \"{title}\" cant be loaded, Background Alpha is wrong!");
                return;
            }
            BackgroundColor = pictureBoxIcon.BackColor = Color.FromArgb(_alpha, (Color)new ColorConverter().ConvertFromString("#" + backColor));
            Path = textBox1.Text = path;
            if (!int.TryParse(fontSize, out int _fontSize))
                _fontSize = 10;
            numericUpDownFontSize.Value = FontSize = _fontSize;
            labelTitle.Font = new Font("Segoe UI", (int)numericUpDownFontSize.Value, FontStyle.Bold);
            if (Boolean.TryParse(isAnimated, out bool _isAnimated))
                checkBox2.Checked = IsAnimated = _isAnimated;
            isDoneCreating = true;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to remove shortcut named \"{Title}\"?", "Remove Shortcut", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Form1.BaseForm.RemoveShortcut(Id);
        }

        private void ImagePreview_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new()
            {
                Multiselect = false,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.tiff;*.tif;*.jpe;*.jfif;*.bmp;*.dib;*.rle;*.gif;"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imageName = openFileDialog.FileName;
                    pictureBoxIcon.Image = ShortcutIcon = new Bitmap(Image.FromFile(imageName), 120, 120);
                    ShortcutIcon.Save(iconDirectoryPath + $"{Id}.png", ImageFormat.Png);
                }
            }
            ShortcutChanged();
        }
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            Title = labelTitle.Text = titleTextBox.Text;
            ShortcutChanged();
        }
        //private void ColorPicker_panel_Click(object sender, EventArgs e)
        //{
        //    ColorDialog MyDialog = new()
        //    {
        //        FullOpen = true,
        //        Color = TitleColor
        //    };
        //    if (MyDialog.ShowDialog() == DialogResult.OK)
        //        TitleColor = labelTitle.ForeColor = colorPicker_panel.BackColor = MyDialog.Color;
        //    textBoxColor.Text = $"{TitleColor.R:X2}{TitleColor.G:X2}{TitleColor.B:X2}";
        //    ShortcutChanged();
        //}
        //private void TextBoxColor_Leave(object sender, EventArgs e)
        //{
        //    string value = textBoxColor.Text.Replace("#", "");
        //    if (value.Length > 6)
        //        value = value.Substring(1, 6);
        //    if (!VerifyHex(value))
        //    {
        //        MessageBox.Show($"Pleas make sure the digits are Hexadecimal.", "Wrong value", MessageBoxButtons.OK);
        //        return;
        //    }
        //    textBoxColor.Text = value.PadLeft(6, '0').ToUpper();
        //    TitleColor = labelTitle.ForeColor = colorPicker_panel.BackColor = (Color)new ColorConverter().ConvertFromString("#" + textBoxColor.Text);
        //    ShortcutChanged();
        //}
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Path = textBox1.Text;
            ShortcutChanged();
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxIcon.Visible = IsIconVisible = checkBox1.Checked;
            if (IsIconVisible)
            {
                labelTitle.Parent = pictureBoxIcon;
                labelTitle.Location = new Point(0, 0);
                labelTitle.Padding = new Padding(0, 0, 0, 10);
                labelTitle.TextAlign = ContentAlignment.BottomCenter;
            }
            else
            {
                labelTitle.Parent = this;
                labelTitle.Location = new Point(3, 3);
                labelTitle.Padding = new Padding(0);
                labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            }
            ShortcutChanged();
        }
        private void NumericUpDownFontSize_ValueChanged(object sender, EventArgs e)
        {
            FontSize = (int)numericUpDownFontSize.Value;
            labelTitle.Font = new Font("Segoe UI", FontSize, FontStyle.Bold);
            ShortcutChanged();
        }
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            IsAnimated = checkBox2.Checked;
            ShortcutChanged();
        }
        private void ShortcutChanged()
        {
            if (isDoneCreating)
                Form1.BaseForm.ChangeShortcut(Id);
        }

        private void ColorPickerPanelTitle_ColorChanged(object sender, EventArgs e)
        {
            TitleColor = labelTitle.ForeColor = colorPickerPanelTitle.SelectedColor;
            ShortcutChanged();
        }

        private void NumericUpDownAlpha_ValueChanged(object sender, EventArgs e)
        {
            BackgroundColor = pictureBoxIcon.BackColor = Color.FromArgb((int)numericUpDownAlpha.Value, colorPickerPanelBackground.SelectedColor);
            ShortcutChanged();
        }

        private void ColorPickerPanelBackground_ColorChanged(object sender, EventArgs e)
        {
            BackgroundColor = pictureBoxIcon.BackColor = Color.FromArgb((int)numericUpDownAlpha.Value, colorPickerPanelBackground.SelectedColor);
            ShortcutChanged();
        }

    }
}
