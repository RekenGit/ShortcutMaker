namespace ShortcutMaker
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            panel1 = new Panel();
            saveButton = new Button();
            returnButton = new Button();
            panel = new FlowLayoutPanel();
            panel4 = new Panel();
            button1 = new Button();
            labelVersionInstaled = new Label();
            label11 = new Label();
            label12 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            comboBoxImageLayout = new ComboBox();
            colorPickerPanelBackground = new ColorPickerPanel();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            panelBackgroundImage = new Panel();
            checkBoxBackgroundUseImage = new CheckBox();
            panel2 = new Panel();
            numericUpDown_Size = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            numericUpDown_MouseHover = new NumericUpDown();
            colorPicker_MouseHover = new ColorPickerPanel();
            label1 = new Label();
            label2 = new Label();
            labelInstalInfo = new Label();
            panel1.SuspendLayout();
            panel.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Size).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MouseHover).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(returnButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(36, 173);
            panel1.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Transparent;
            saveButton.BackgroundImage = (Image)resources.GetObject("saveButton.BackgroundImage");
            saveButton.BackgroundImageLayout = ImageLayout.Center;
            saveButton.Cursor = Cursors.Hand;
            saveButton.Dock = DockStyle.Bottom;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            saveButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            saveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 90);
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            saveButton.Location = new Point(0, 135);
            saveButton.Name = "saveButton";
            saveButton.Padding = new Padding(2);
            saveButton.Size = new Size(36, 38);
            saveButton.TabIndex = 2;
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.Transparent;
            returnButton.BackgroundImage = (Image)resources.GetObject("returnButton.BackgroundImage");
            returnButton.BackgroundImageLayout = ImageLayout.Center;
            returnButton.Cursor = Cursors.Hand;
            returnButton.Dock = DockStyle.Top;
            returnButton.FlatAppearance.BorderSize = 0;
            returnButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            returnButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            returnButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 90);
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            returnButton.Location = new Point(0, 0);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(36, 36);
            returnButton.TabIndex = 1;
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += ReturnButton_Click;
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.BackColor = Color.Transparent;
            panel.Controls.Add(panel4);
            panel.Controls.Add(panel3);
            panel.Controls.Add(panel2);
            panel.Controls.Add(panel6);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(36, 0);
            panel.Name = "panel";
            panel.Size = new Size(275, 173);
            panel.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(80, 80, 100);
            panel4.Controls.Add(labelInstalInfo);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(labelVersionInstaled);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(2, 2);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(226, 155);
            panel4.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(80, 100, 100);
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(31, 92);
            button1.Margin = new Padding(30);
            button1.Name = "button1";
            button1.Size = new Size(165, 23);
            button1.TabIndex = 4;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelVersionInstaled
            // 
            labelVersionInstaled.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelVersionInstaled.ForeColor = Color.White;
            labelVersionInstaled.Location = new Point(120, 42);
            labelVersionInstaled.Name = "labelVersionInstaled";
            labelVersionInstaled.Size = new Size(103, 20);
            labelVersionInstaled.TabIndex = 3;
            labelVersionInstaled.Text = "1.0";
            labelVersionInstaled.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(4, 43);
            label11.Name = "label11";
            label11.Size = new Size(110, 20);
            label11.TabIndex = 0;
            label11.Text = "Instaled Version:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Top;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(226, 31);
            label12.TabIndex = 2;
            label12.Text = "App Information";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(80, 80, 100);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(comboBoxImageLayout);
            panel3.Controls.Add(colorPickerPanelBackground);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(panelBackgroundImage);
            panel3.Controls.Add(checkBoxBackgroundUseImage);
            panel3.Location = new Point(2, 161);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(226, 218);
            panel3.TabIndex = 6;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(4, 133);
            label10.Name = "label10";
            label10.Size = new Size(110, 23);
            label10.TabIndex = 12;
            label10.Text = "Image layout:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxImageLayout
            // 
            comboBoxImageLayout.FormattingEnabled = true;
            comboBoxImageLayout.Items.AddRange(new object[] { "None", "Tile", "Center", "Stretch", "Zoom" });
            comboBoxImageLayout.Location = new Point(120, 133);
            comboBoxImageLayout.Name = "comboBoxImageLayout";
            comboBoxImageLayout.Size = new Size(103, 23);
            comboBoxImageLayout.TabIndex = 11;
            comboBoxImageLayout.SelectedIndexChanged += ComboBoxImageLayout_SelectedIndexChanged;
            // 
            // colorPickerPanelBackground
            // 
            colorPickerPanelBackground.BackColor = Color.Transparent;
            colorPickerPanelBackground.Location = new Point(120, 191);
            colorPickerPanelBackground.Name = "colorPickerPanelBackground";
            colorPickerPanelBackground.Size = new Size(103, 20);
            colorPickerPanelBackground.TabIndex = 9;
            colorPickerPanelBackground.ColorChanged += ColorPickerPanelBackground_ColorChanged;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(4, 191);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 10;
            label9.Text = "Color:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(4, 161);
            label8.Name = "label8";
            label8.Size = new Size(159, 24);
            label8.TabIndex = 8;
            label8.Text = "Use image as background:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(4, 42);
            label4.Name = "label4";
            label4.Size = new Size(110, 78);
            label4.TabIndex = 0;
            label4.Text = "Image:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(226, 31);
            label7.TabIndex = 2;
            label7.Text = "Background";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBackgroundImage
            // 
            panelBackgroundImage.BackColor = Color.Silver;
            panelBackgroundImage.BackgroundImageLayout = ImageLayout.Zoom;
            panelBackgroundImage.Location = new Point(120, 42);
            panelBackgroundImage.Margin = new Padding(1);
            panelBackgroundImage.Name = "panelBackgroundImage";
            panelBackgroundImage.Size = new Size(103, 78);
            panelBackgroundImage.TabIndex = 7;
            panelBackgroundImage.Click += PanelBackgroundImage_Click;
            // 
            // checkBoxBackgroundUseImage
            // 
            checkBoxBackgroundUseImage.CheckAlign = ContentAlignment.MiddleCenter;
            checkBoxBackgroundUseImage.Location = new Point(169, 162);
            checkBoxBackgroundUseImage.Name = "checkBoxBackgroundUseImage";
            checkBoxBackgroundUseImage.Size = new Size(54, 24);
            checkBoxBackgroundUseImage.TabIndex = 7;
            checkBoxBackgroundUseImage.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxBackgroundUseImage.UseVisualStyleBackColor = true;
            checkBoxBackgroundUseImage.CheckedChanged += CheckBoxBackgroundUseImage_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(80, 80, 100);
            panel2.Controls.Add(numericUpDown_Size);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(2, 383);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 69);
            panel2.TabIndex = 5;
            // 
            // numericUpDown_Size
            // 
            numericUpDown_Size.CausesValidation = false;
            numericUpDown_Size.Location = new Point(120, 42);
            numericUpDown_Size.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numericUpDown_Size.Minimum = new decimal(new int[] { 80, 0, 0, 0 });
            numericUpDown_Size.Name = "numericUpDown_Size";
            numericUpDown_Size.Size = new Size(103, 23);
            numericUpDown_Size.TabIndex = 0;
            numericUpDown_Size.Value = new decimal(new int[] { 80, 0, 0, 0 });
            numericUpDown_Size.ValueChanged += NumericUpDown_Size_ValueChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(4, 42);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 0;
            label5.Text = "Size:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(226, 31);
            label6.TabIndex = 2;
            label6.Text = "Shortcut";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(80, 80, 100);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(numericUpDown_MouseHover);
            panel6.Controls.Add(colorPicker_MouseHover);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(2, 456);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(226, 87);
            panel6.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 61);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 3;
            label3.Text = "Color alpha:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_MouseHover
            // 
            numericUpDown_MouseHover.Location = new Point(120, 60);
            numericUpDown_MouseHover.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown_MouseHover.Name = "numericUpDown_MouseHover";
            numericUpDown_MouseHover.Size = new Size(103, 23);
            numericUpDown_MouseHover.TabIndex = 0;
            numericUpDown_MouseHover.ValueChanged += NumericUpDown1_ValueChanged;
            // 
            // colorPicker_MouseHover
            // 
            colorPicker_MouseHover.BackColor = Color.Transparent;
            colorPicker_MouseHover.Location = new Point(120, 34);
            colorPicker_MouseHover.Name = "colorPicker_MouseHover";
            colorPicker_MouseHover.Size = new Size(103, 20);
            colorPicker_MouseHover.TabIndex = 0;
            colorPicker_MouseHover.ColorChanged += ColorPicker_MouseHoverColor_ColorChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 34);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Color:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(226, 31);
            label2.TabIndex = 2;
            label2.Text = "Shortcut [Hovered]";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInstalInfo
            // 
            labelInstalInfo.Dock = DockStyle.Bottom;
            labelInstalInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelInstalInfo.ForeColor = Color.White;
            labelInstalInfo.ImageAlign = ContentAlignment.TopLeft;
            labelInstalInfo.Location = new Point(0, 121);
            labelInstalInfo.Name = "labelInstalInfo";
            labelInstalInfo.Size = new Size(226, 34);
            labelInstalInfo.TabIndex = 5;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 80);
            ClientSize = new Size(311, 173);
            Controls.Add(panel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OptionsForm";
            Text = "OptionsForm";
            panel1.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Size).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MouseHover).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button returnButton;
        public FlowLayoutPanel panel;
        private Panel panel6;
        private Label label1;
        public ColorPickerPanel colorPicker_MouseHover;
        private ColorPickerPanel colorPickerPanel1;
        private Label label3;
        private Label label2;
        public NumericUpDown numericUpDown_MouseHover;
        private Panel panel2;
        private Label label5;
        private Label label6;
        public NumericUpDown numericUpDown_Size;
        public Button saveButton;
        private Panel panel3;
        private Label label4;
        private Label label7;
        public Panel panelBackgroundImage;
        private Label label8;
        private Label label9;
        public ColorPickerPanel colorPickerPanelBackground;
        public CheckBox checkBoxBackgroundUseImage;
        public Panel panel1;
        private Label label10;
        public ComboBox comboBoxImageLayout;
        private Panel panel4;
        private Button button1;
        private Label label11;
        private Label label12;
        public Label labelVersionInstaled;
        public Label labelInstalInfo;
    }
}