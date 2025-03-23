namespace ShortcutMaker
{
    partial class EditForm
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
            addButton = new Button();
            returnButton = new Button();
            panel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(returnButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(36, 173);
            panel1.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Transparent;
            addButton.BackgroundImage = ResourceTemp.addIcon;
            addButton.BackgroundImageLayout = ImageLayout.Center;
            addButton.Cursor = Cursors.Hand;
            addButton.Dock = DockStyle.Top;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            addButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            addButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 90);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addButton.Location = new Point(0, 36);
            addButton.Name = "addButton";
            addButton.Size = new Size(36, 36);
            addButton.TabIndex = 6;
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddButton_Click;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.Transparent;
            returnButton.BackgroundImage = ResourceTemp.returnIcon;
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
            returnButton.TabIndex = 5;
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += ReturnButton_Click;
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.BackColor = Color.Transparent;
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(36, 0);
            panel.Name = "panel";
            panel.Size = new Size(275, 173);
            panel.TabIndex = 4;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 80);
            ClientSize = new Size(311, 173);
            Controls.Add(panel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditForm";
            Text = "EditForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button addButton;
        private Button returnButton;
        public FlowLayoutPanel panel;
        public Panel panel1;
    }
}