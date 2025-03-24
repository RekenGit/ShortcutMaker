using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ShortcutMaker
{
    public partial class ColorPickerPanel : UserControl
    {
        public Color SelectedColor { get; private set; }
        private string lastTextColor = "";
        public ColorPickerPanel()
        {
            InitializeComponent();
        }

        [Browsable(true), Category("Action"), Description("Invoked when color changed")]
        public event EventHandler ColorChanged;

        public void SetColor(Color color)
        {
            SelectedColor = colorPicker_panel.BackColor = color;
            lastTextColor = textBoxColor.Text = $"{SelectedColor.R:X2}{SelectedColor.G:X2}{SelectedColor.B:X2}";
        }

        private void ColorPicker_panel_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new()
            {
                FullOpen = true,
                Color = SelectedColor
            };
            if (MyDialog.ShowDialog() == DialogResult.OK && MyDialog.Color != SelectedColor)
            {
                SelectedColor = colorPicker_panel.BackColor = MyDialog.Color;
                lastTextColor = textBoxColor.Text = $"{SelectedColor.R:X2}{SelectedColor.G:X2}{SelectedColor.B:X2}";

                if (this.ColorChanged != null)
                    ColorChanged(this, e);
            }
        }
        private static readonly Regex r = new(@"^[0-9a-f\r\n]+$");
        private static bool VerifyHex(string _hex) => r.Match(_hex.ToLower()).Success;
        private void TextBoxColor_Leave(object sender, EventArgs e)
        {
            if (lastTextColor == textBoxColor.Text)
                return;

            string value = textBoxColor.Text.Replace("#", "");
            if (value.Length > 6)
                value = value.Substring(1, 6);
            if (string.IsNullOrEmpty(value))
                value = "000000";
            if (!VerifyHex(value))
            {
                MessageBox.Show($"Pleas make sure the digits are Hexadecimal.", "Wrong value", MessageBoxButtons.OK);
                return;
            }
            lastTextColor = textBoxColor.Text = value.PadLeft(6, '0').ToUpper();
            SelectedColor = colorPicker_panel.BackColor = (Color)new ColorConverter().ConvertFromString("#" + textBoxColor.Text);

            if (this.ColorChanged != null)
                ColorChanged(this, e);
        }
    }
}
