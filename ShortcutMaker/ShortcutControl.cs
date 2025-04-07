using System.Drawing.Imaging;

namespace ShortcutMaker
{
    public partial class ShortcutControl : UserControl
    {
        static int lastId = 0;
        public int Id { get; set; }
        public bool IsAMenu { get; set; } = false;
        public string Title { get; set; }
        public Bitmap ShortcutIcon { get; set; }
        public bool IsIconVisible { get; set; }
        public int FontSize { get; set; }
        public ContentAlignment SelectedTextAlign { get; set; }
        public bool IsAnimated { get; set; }
        public string Path { get; set; }
        public Color TitleColor { get; set; }
        public Color BackgroundColor { get; set; }
        public bool IsModified { get; private set; } = false;
        private bool isDoneCreating = false;
        private static readonly string iconDirectoryPath = Form1.applicationDataDirectory + "Icons\\";
        #region Create
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
            colorPickerPanelTitle.SetColor(TitleColor);
            BackgroundColor = Color.Black;
            colorPickerPanelBackground.SetColor(BackgroundColor);
            FontSize = 10;
            IsAnimated = true;
            isDoneCreating = true;
            ShortcutIcon = new(ResourceTemp.no_image, 120, 120);
            ShortcutIcon.Save(iconDirectoryPath + $"{Id}.png", ImageFormat.Png);
        }
        //public ShortcutControl(string title, Bitmap icon, bool isIconVisible, int fontSize, ContentAlignment textAlign, bool isAnimated, string path, Color titleColor, Color backColor)
        //{
        //    InitializeComponent();
        //    labelTitle.Parent = pictureBoxIcon;
        //    labelTitle.Location = new(0, 0);

        //    Id = ++lastId;
        //    ChangeShortcutData(title, icon, isIconVisible, fontSize, textAlign, isAnimated, path, titleColor, backColor);

        //    isDoneCreating = true;
        //}
        public ShortcutControl(ShortcutControl sc)
        {
            InitializeComponent();
            labelTitle.Parent = pictureBoxIcon;
            labelTitle.Location = new(0, 0);

            Id = ++lastId;
            ChangeShortcutData(sc.Title, sc.ShortcutIcon, sc.IsIconVisible, sc.FontSize, sc.SelectedTextAlign, sc.IsAnimated, sc.Path, sc.TitleColor, sc.colorPickerPanelBackground.SelectedColor, sc.IsModified);
            isDoneCreating = true;
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
            if (int.TryParse(textAlign, out int _textAlign))
                SelectedTextAlign = labelTitle.TextAlign = Form1.GetAligmentById(_textAlign);
            comboBoxTextAlign.SelectedIndex = Form1.GetIdByAligment(SelectedTextAlign);
            isDoneCreating = true;
        }
        #endregion

        public void ChangeShortcutData(string title, Bitmap icon, bool isIconVisible, int fontSize, ContentAlignment textAlign, bool isAnimated, string path, Color titleColor, Color backColor, bool isModified)
        {
            titleTextBox.Text = labelTitle.Text = Title = title;
            Image img = icon;
            ShortcutIcon = new Bitmap(img);
            //img.Dispose();
            if (!File.Exists(iconDirectoryPath + $"{Id}.png"))
                ShortcutIcon.Save(iconDirectoryPath + $"{Id}.png", ImageFormat.Png);
            checkBox1.Checked = IsIconVisible = isIconVisible;
            pictureBoxIcon.BackgroundImage = IsIconVisible ? ShortcutIcon : null;
            numericUpDownFontSize.Value = FontSize = fontSize;
            SelectedTextAlign = labelTitle.TextAlign = textAlign;
            comboBoxTextAlign.SelectedIndex = Form1.GetIdByAligment(SelectedTextAlign);
            checkBox2.Checked = IsAnimated = isAnimated;
            Path = textBox1.Text = path;
            TitleColor = labelTitle.ForeColor = titleColor;
            colorPickerPanelTitle.SetColor(TitleColor);
            colorPickerPanelBackground.SetColor(backColor);
            numericUpDownAlpha.Value = backColor.A;
            BackgroundColor = pictureBoxIcon.BackColor = colorPickerPanelBackground.SelectedColor;
            if (isModified)
            {
                IsModified = true;
                buttonSave.BackColor = Color.YellowGreen;
            }
            else
            {
                IsModified = false;
                buttonSave.BackColor = Color.FromArgb(0, 64, 64, 64);
            }
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

            ShortcutGotModified();
        }
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            Title = labelTitle.Text = titleTextBox.Text;

            ShortcutGotModified();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Path = textBox1.Text;

            ShortcutGotModified();
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            IsIconVisible = checkBox1.Checked;
            pictureBoxIcon.BackgroundImage = IsIconVisible ? ShortcutIcon : null;

            ShortcutGotModified();
        }
        private void NumericUpDownFontSize_ValueChanged(object sender, EventArgs e)
        {
            FontSize = (int)numericUpDownFontSize.Value;
            labelTitle.Font = new Font("Segoe UI", FontSize, FontStyle.Bold);

            ShortcutGotModified();
        }
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            IsAnimated = checkBox2.Checked;

            ShortcutGotModified();
        }

        private void ColorPickerPanelTitle_ColorChanged(object sender, EventArgs e)
        {
            TitleColor = labelTitle.ForeColor = colorPickerPanelTitle.SelectedColor;

            ShortcutGotModified();
        }

        private void NumericUpDownAlpha_ValueChanged(object sender, EventArgs e)
        {
            BackgroundColor = pictureBoxIcon.BackColor = Color.FromArgb((int)numericUpDownAlpha.Value, colorPickerPanelBackground.SelectedColor);
            colorPickerPanelBackground.SetColor(BackgroundColor);

            ShortcutGotModified();
        }

        private void ColorPickerPanelBackground_ColorChanged(object sender, EventArgs e)
        {
            BackgroundColor = pictureBoxIcon.BackColor = Color.FromArgb((int)numericUpDownAlpha.Value, colorPickerPanelBackground.SelectedColor);
            colorPickerPanelBackground.SetColor(BackgroundColor);

            ShortcutGotModified();
        }

        private void ComboBoxTextAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTextAlign = labelTitle.TextAlign = Form1.GetAligmentById(comboBoxTextAlign.SelectedIndex);

            ShortcutGotModified();
        }
        private void ShortcutGotModified()
        {
            if (isDoneCreating)
            {
                IsModified = true;
                buttonSave.BackColor = Color.YellowGreen;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            IsModified = false;
            buttonSave.BackColor = Color.FromArgb(0, 64, 64, 64);
            SetChangesToOrginal();

            Form1.BaseForm.ChangeShortcut(Id, IsAMenu);
        }

        public void SetChangesToOrginal()
        {
            if (IsAMenu)
            {
                ShortcutControl orginal = Form1.BaseForm.ShortcutList.First(x => x.Id == Id);
                orginal?.ChangeShortcutData(Title, ShortcutIcon, IsIconVisible, FontSize, SelectedTextAlign, IsAnimated, Path, TitleColor, BackgroundColor, IsModified);
            }
        }
    }
}
