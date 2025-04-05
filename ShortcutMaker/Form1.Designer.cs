namespace ShortcutMaker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            viewPanel = new Panel();
            SuspendLayout();
            // 
            // viewPanel
            // 
            viewPanel.Dock = DockStyle.Fill;
            viewPanel.Location = new Point(0, 0);
            viewPanel.Name = "viewPanel";
            viewPanel.Size = new Size(311, 173);
            viewPanel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gray;
            ClientSize = new Size(311, 173);
            Controls.Add(viewPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimumSize = new Size(242, 212);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shortcut Maker";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Panel viewPanel;
    }
}
