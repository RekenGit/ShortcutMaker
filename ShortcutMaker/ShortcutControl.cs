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
        public ContentAlignment SelectedTextAlign { get; set; }
        public bool IsAnimated { get; set; }
        public string Path { get; set; }
        public Color TitleColor { get; set; }
        public Color BackgroundColor { get; set; }
        private bool isDoneCreating = false;
        private static readonly string iconDirectoryPath = Form1.applicationDataDirectory + "Icons\\";
        public ShortcutControl()
        {
            InitializeComponent();
            labelTitle.Location = pictureBoxIcon.Location;
            labelTitle.Parent = pictureBoxIcon;
            labelTitle.TextAlign = SelectedTextAlign = ContentAlignment.TopLeft;
            comboBoxTextAlign.SelectedIndex = Form1.GetIdByAligment(SelectedTextAlign);

            Id = ++lastId;
            labelTitle.Text = Title = "Shortcut";
            IsIconVisible = true;
            TitleColor = Color.White;
            BackgroundColor = Color.Black;
            FontSize = 10;
            IsAnimated = true;
            isDoneCreating = true;
            ShortcutIcon = new(120, 120);
            ShortcutIcon.Save(iconDirectoryPath + $"{Id}.png", ImageFormat.Png);
        }
        public ShortcutControl(string id, string title, string isIconVisible, string color, string backColor, string backAlpha, string fontSize, string textAlign, string isAnimated, string path)
        {
            if (!int.TryParse(id, out int _id))
            {
                MessageBox.Show($"Shortcut named \"{title}\" cant be loaded, Id is wrong!");
                return;
            }
            InitializeComponent();
            labelTitle.Parent = pictureBoxIcon;
            labelTitle.Location = new(0, 0);
            if (int.TryParse(textAlign, out int _textAlign))
                SelectedTextAlign = labelTitle.TextAlign = Form1.GetAligmentById(_textAlign);
            comboBoxTextAlign.SelectedIndex = Form1.GetIdByAligment(SelectedTextAlign);

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
            if (Boolean.TryParse(isIconVisible, out bool _isIconVisible))
            {
                checkBox1.Checked = IsIconVisible = _isIconVisible;
                pictureBoxIcon.BackgroundImage = _isIconVisible ? ShortcutIcon : null;
            }
            TitleColor = labelTitle.ForeColor = (Color)new ColorConverter().ConvertFromString("#" + color);
            colorPickerPanelTitle.SetColor(TitleColor);
            if (!int.TryParse(backAlpha, out int _alpha))
            {
                MessageBox.Show($"Shortcut named \"{title}\" cant be loaded, Background Alpha is wrong!");
                return;
            }
            BackgroundColor = pictureBoxIcon.BackColor = Color.FromArgb(_alpha, (Color)new ColorConverter().ConvertFromString("#" + backColor));
            colorPickerPanelBackground.SetColor(BackgroundColor);
            Path = textBox1.Text = path;
            if (!int.TryParse(fontSize, out int _fontSize))
                _fontSize = 10;
            numericUpDownFontSize.Value = FontSize = _fontSize;
            labelTitle.Font = new Font("Segoe UI", (int)numericUpDownFontSize.Value, FontStyle.Bold);
            if (Boolean.TryParse(isAnimated, out bool _isAnimated))
                checkBox2.Checked = IsAnimated = _isAnimated;
            isDoneCreating = true;
        }

        public void ChangeSize(Size newSize) => labelTitle.Size = pictureBoxIcon.Size = newSize;

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
                    ShortcutIcon = new Bitmap(Image.FromFile(imageName), 120, 120);
                    pictureBoxIcon.BackgroundImage = IsIconVisible ? ShortcutIcon : null;
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
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Path = textBox1.Text;
            ShortcutChanged();
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            IsIconVisible = checkBox1.Checked;
            pictureBoxIcon.BackgroundImage = IsIconVisible ? ShortcutIcon : null;
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

        private void ComboBoxTextAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTextAlign = labelTitle.TextAlign = Form1.GetAligmentById(comboBoxTextAlign.SelectedIndex);
            ShortcutChanged();
        }
    }
}
