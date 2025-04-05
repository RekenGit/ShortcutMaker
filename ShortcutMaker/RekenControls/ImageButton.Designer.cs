namespace ShortcutMaker.RekenControls
{
    partial class ImageButton
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            pictureBox.Dock = DockStyle.Left;
            pictureBox.Image = ResourceTemp.no_image;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(40, 40);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += Button_Click;
            pictureBox.MouseLeave += Button_MouseLeave;
            pictureBox.MouseHover += Button_MouseHover;
            // 
            // label
            // 
            label.Dock = DockStyle.Fill;
            label.Location = new Point(40, 0);
            label.Name = "label";
            label.Size = new Size(90, 40);
            label.TabIndex = 1;
            label.Text = "label1";
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Click += Button_Click;
            label.MouseLeave += Button_MouseLeave;
            label.MouseHover += Button_MouseHover;
            // 
            // ImageButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label);
            Controls.Add(pictureBox);
            Name = "ImageButton";
            Size = new Size(130, 40);
            BackColorChanged += ImageButton_BackColorChanged;
            Resize += ImageButton_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Label label;
    }
}
