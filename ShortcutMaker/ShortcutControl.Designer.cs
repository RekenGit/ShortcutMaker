namespace ShortcutMaker
{
    partial class ShortcutControl
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
            titleTextBox = new TextBox();
            removeButton = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBoxIcon = new PictureBox();
            labelTitle = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label2 = new Label();
            numericUpDownFontSize = new NumericUpDown();
            colorPickerPanelTitle = new ColorPickerPanel();
            colorPickerPanelBackground = new ColorPickerPanel();
            label3 = new Label();
            numericUpDownAlpha = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFontSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlpha).BeginInit();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(3, 89);
            titleTextBox.MaxLength = 19;
            titleTextBox.Name = "titleTextBox";
            titleTextBox.PlaceholderText = "Name..";
            titleTextBox.Size = new Size(122, 23);
            titleTextBox.TabIndex = 1;
            titleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.IndianRed;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            removeButton.Location = new Point(219, 0);
            removeButton.Margin = new Padding(0);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(25, 25);
            removeButton.TabIndex = 2;
            removeButton.Text = "X";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += RemoveButton_Click;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(145, 74);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 8;
            label1.Text = "Title Color (Hex):";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(0, 170);
            textBox1.MaxLength = 1000;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Path..";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(244, 63);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.BackgroundImage = ResourceTemp.no_image;
            pictureBoxIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxIcon.Location = new Point(3, 3);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(80, 80);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIcon.TabIndex = 10;
            pictureBoxIcon.TabStop = false;
            pictureBoxIcon.Click += ImagePreview_Click;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Transparent;
            labelTitle.FlatStyle = FlatStyle.Flat;
            labelTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new Padding(0, 0, 0, 10);
            labelTitle.Size = new Size(80, 80);
            labelTitle.TabIndex = 11;
            labelTitle.Text = "Title";
            labelTitle.TextAlign = ContentAlignment.BottomCenter;
            labelTitle.UseMnemonic = false;
            labelTitle.Click += ImagePreview_Click;
            // 
            // checkBox1
            // 
            checkBox1.CheckAlign = ContentAlignment.BottomCenter;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Segoe UI", 8F);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(96, 0);
            checkBox1.Margin = new Padding(0);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.No;
            checkBox1.Size = new Size(45, 52);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Show img";
            checkBox1.TextAlign = ContentAlignment.BottomCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.CheckAlign = ContentAlignment.BottomCenter;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Cursor = Cursors.Hand;
            checkBox2.Font = new Font("Segoe UI", 8F);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(159, 0);
            checkBox2.Margin = new Padding(0);
            checkBox2.Name = "checkBox2";
            checkBox2.RightToLeft = RightToLeft.No;
            checkBox2.Size = new Size(44, 52);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "Hover anims";
            checkBox2.TextAlign = ContentAlignment.BottomCenter;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += CheckBox2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 129);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 15;
            label2.Text = "Font Size:";
            // 
            // numericUpDownFontSize
            // 
            numericUpDownFontSize.BorderStyle = BorderStyle.None;
            numericUpDownFontSize.Location = new Point(3, 146);
            numericUpDownFontSize.Margin = new Padding(2);
            numericUpDownFontSize.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            numericUpDownFontSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownFontSize.Name = "numericUpDownFontSize";
            numericUpDownFontSize.RightToLeft = RightToLeft.No;
            numericUpDownFontSize.Size = new Size(57, 19);
            numericUpDownFontSize.TabIndex = 14;
            numericUpDownFontSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownFontSize.ValueChanged += NumericUpDownFontSize_ValueChanged;
            // 
            // colorPickerPanelTitle
            // 
            colorPickerPanelTitle.BackColor = Color.Transparent;
            colorPickerPanelTitle.Location = new Point(145, 92);
            colorPickerPanelTitle.Name = "colorPickerPanelTitle";
            colorPickerPanelTitle.Size = new Size(96, 20);
            colorPickerPanelTitle.TabIndex = 19;
            colorPickerPanelTitle.ColorChanged += ColorPickerPanelTitle_ColorChanged;
            // 
            // colorPickerPanelBackground
            // 
            colorPickerPanelBackground.BackColor = Color.Transparent;
            colorPickerPanelBackground.Location = new Point(145, 146);
            colorPickerPanelBackground.Name = "colorPickerPanelBackground";
            colorPickerPanelBackground.Size = new Size(96, 20);
            colorPickerPanelBackground.TabIndex = 21;
            colorPickerPanelBackground.ColorChanged += ColorPickerPanelBackground_ColorChanged;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(96, 128);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 20;
            label3.Text = "Background Color (Hex):";
            // 
            // numericUpDownAlpha
            // 
            numericUpDownAlpha.BorderStyle = BorderStyle.None;
            numericUpDownAlpha.Location = new Point(96, 146);
            numericUpDownAlpha.Margin = new Padding(2);
            numericUpDownAlpha.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownAlpha.Name = "numericUpDownAlpha";
            numericUpDownAlpha.RightToLeft = RightToLeft.No;
            numericUpDownAlpha.Size = new Size(44, 19);
            numericUpDownAlpha.TabIndex = 22;
            numericUpDownAlpha.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownAlpha.ValueChanged += NumericUpDownAlpha_ValueChanged;
            // 
            // ShortcutControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(80, 80, 100);
            Controls.Add(numericUpDownAlpha);
            Controls.Add(colorPickerPanelBackground);
            Controls.Add(label3);
            Controls.Add(colorPickerPanelTitle);
            Controls.Add(label2);
            Controls.Add(numericUpDownFontSize);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(labelTitle);
            Controls.Add(pictureBoxIcon);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(removeButton);
            Controls.Add(titleTextBox);
            Margin = new Padding(5, 3, 5, 3);
            Name = "ShortcutControl";
            Size = new Size(244, 233);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFontSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlpha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox titleTextBox;
        private Button removeButton;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBoxIcon;
        private Label labelTitle;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label2;
        private NumericUpDown numericUpDownFontSize;
        private ColorPickerPanel colorPickerPanelTitle;
        private ColorPickerPanel colorPickerPanelBackground;
        private Label label3;
        private NumericUpDown numericUpDownAlpha;
    }
}
