using System.Runtime.CompilerServices;

namespace ShortcutMaker.RekenControls
{
    public partial class ImageButton : UserControl
    {
        public Image TextImage
        {
            get => pictureBox.Image;
            set
            {
                pictureBox.Image = value;
            }
        }
        public string TextLabel
        {
            get => label.Text;
            set
            {
                label.Text = value;
            }
        }
        public bool UseHoverEffect { get; set; } = true;
        public Color HoverBackColor { get; set; } = Color.FromArgb(255, 70, 70, 90);
        private Color backColor = Color.FromArgb(255, 80, 80, 100);
        private bool isHovered = false;

        public ImageButton()
        {
            InitializeComponent();
            TextImage = pictureBox.Image;
            Text = label.Text;
            backColor = BackColor;
        }
        private void ImageButton_Resize(object sender, EventArgs e)
        {
            pictureBox.Width = pictureBox.Height;
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            if (!UseHoverEffect || isHovered)
                return;

            isHovered = true;
            BackColor = HoverBackColor;
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (!UseHoverEffect)
                return;

            isHovered = false;
            BackColor = backColor;
        }

        private void ImageButton_BackColorChanged(object sender, EventArgs e)
        {
            if (isHovered)
                return;
            backColor = BackColor;
        }

        private void Button_Click(object sender, EventArgs e) => OnClick(e);
    }
}
