namespace ShortcutMaker
{
    partial class MainForm
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
            panel1 = new Panel();
            opacityScrollBar = new VScrollBar();
            panel2 = new Panel();
            editButton = new Button();
            lockWindowButton = new Button();
            optionsButton = new Button();
            panel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel1.Controls.Add(opacityScrollBar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lockWindowButton);
            panel1.Controls.Add(optionsButton);
            panel1.Controls.Add(editButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(36, 173);
            panel1.TabIndex = 1;
            // 
            // opacityScrollBar
            // 
            opacityScrollBar.Cursor = Cursors.SizeNS;
            opacityScrollBar.Dock = DockStyle.Left;
            opacityScrollBar.Location = new Point(8, 72);
            opacityScrollBar.Margin = new Padding(8);
            opacityScrollBar.Maximum = 110;
            opacityScrollBar.Minimum = 10;
            opacityScrollBar.Name = "opacityScrollBar";
            opacityScrollBar.Size = new Size(19, 63);
            opacityScrollBar.TabIndex = 4;
            opacityScrollBar.Tag = "20; 116";
            opacityScrollBar.Value = 70;
            opacityScrollBar.Visible = false;
            opacityScrollBar.Scroll += OpacityScrollBar_Scroll;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 63);
            panel2.TabIndex = 6;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Transparent;
            editButton.BackgroundImage = ResourceTemp.editIcon;
            editButton.BackgroundImageLayout = ImageLayout.Center;
            editButton.Cursor = Cursors.Hand;
            editButton.Dock = DockStyle.Top;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            editButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            editButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 90);
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            editButton.Location = new Point(0, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(36, 36);
            editButton.TabIndex = 5;
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += EditButton_Click;
            // 
            // lockWindowButton
            // 
            lockWindowButton.BackColor = Color.Transparent;
            lockWindowButton.BackgroundImage = ResourceTemp.padlockClose;
            lockWindowButton.BackgroundImageLayout = ImageLayout.Center;
            lockWindowButton.Cursor = Cursors.Hand;
            lockWindowButton.Dock = DockStyle.Bottom;
            lockWindowButton.FlatAppearance.BorderSize = 0;
            lockWindowButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            lockWindowButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            lockWindowButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 90);
            lockWindowButton.FlatStyle = FlatStyle.Flat;
            lockWindowButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lockWindowButton.Location = new Point(0, 135);
            lockWindowButton.Name = "lockWindowButton";
            lockWindowButton.Padding = new Padding(2);
            lockWindowButton.Size = new Size(36, 38);
            lockWindowButton.TabIndex = 3;
            lockWindowButton.UseVisualStyleBackColor = false;
            lockWindowButton.Click += LockWindowButton_Click;
            // 
            // optionsButton
            // 
            optionsButton.BackColor = Color.Transparent;
            optionsButton.BackgroundImage = ResourceTemp.optionsIcon;
            optionsButton.BackgroundImageLayout = ImageLayout.Center;
            optionsButton.Cursor = Cursors.Hand;
            optionsButton.Dock = DockStyle.Top;
            optionsButton.FlatAppearance.BorderSize = 0;
            optionsButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            optionsButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            optionsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 90);
            optionsButton.FlatStyle = FlatStyle.Flat;
            optionsButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            optionsButton.Location = new Point(0, 36);
            optionsButton.Name = "optionsButton";
            optionsButton.Size = new Size(36, 36);
            optionsButton.TabIndex = 4;
            optionsButton.UseVisualStyleBackColor = false;
            optionsButton.Click += OptionsButton_Click;
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.BackColor = Color.Transparent;
            panel.BackgroundImageLayout = ImageLayout.Zoom;
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(36, 0);
            panel.Name = "panel";
            panel.Size = new Size(275, 173);
            panel.TabIndex = 3;
            panel.Click += panel_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 80);
            ClientSize = new Size(311, 173);
            Controls.Add(panel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button editButton;
        private Button optionsButton;
        private Button lockWindowButton;
        public VScrollBar opacityScrollBar;
        public FlowLayoutPanel panel;
        public Panel panel1;
        private Panel panel2;
    }
}