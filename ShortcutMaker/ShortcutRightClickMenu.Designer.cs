namespace ShortcutMaker
{
    partial class ShortcutRightClickMenu
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
            imageButton1 = new ShortcutMaker.RekenControls.ImageButton();
            imageButton2 = new ShortcutMaker.RekenControls.ImageButton();
            imageButton3 = new ShortcutMaker.RekenControls.ImageButton();
            SuspendLayout();
            // 
            // imageButton1
            // 
            imageButton1.BackColor = Color.FromArgb(80, 80, 100);
            imageButton1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            imageButton1.ForeColor = Color.White;
            imageButton1.HoverBackColor = Color.FromArgb(70, 70, 90);
            imageButton1.Location = new Point(2, 3);
            imageButton1.Margin = new Padding(0, 1, 0, 1);
            imageButton1.Name = "imageButton1";
            imageButton1.Padding = new Padding(2, 3, 2, 3);
            imageButton1.Size = new Size(132, 36);
            imageButton1.TabIndex = 0;
            imageButton1.TextImage = ResourceTemp.clone;
            imageButton1.TextLabel = "Duplicate";
            imageButton1.UseHoverEffect = true;
            imageButton1.Click += imageButton1_Click;
            // 
            // imageButton2
            // 
            imageButton2.BackColor = Color.FromArgb(80, 80, 100);
            imageButton2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            imageButton2.ForeColor = Color.White;
            imageButton2.HoverBackColor = Color.FromArgb(70, 70, 90);
            imageButton2.Location = new Point(2, 41);
            imageButton2.Margin = new Padding(0, 1, 0, 1);
            imageButton2.Name = "imageButton2";
            imageButton2.Padding = new Padding(2, 3, 2, 3);
            imageButton2.Size = new Size(132, 36);
            imageButton2.TabIndex = 1;
            imageButton2.TextImage = ResourceTemp.editIcon;
            imageButton2.TextLabel = "Edit";
            imageButton2.UseHoverEffect = true;
            imageButton2.Click += imageButton2_Click;
            // 
            // imageButton3
            // 
            imageButton3.BackColor = Color.IndianRed;
            imageButton3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            imageButton3.ForeColor = Color.White;
            imageButton3.HoverBackColor = Color.Brown;
            imageButton3.Location = new Point(2, 79);
            imageButton3.Margin = new Padding(0, 1, 0, 1);
            imageButton3.Name = "imageButton3";
            imageButton3.Padding = new Padding(2, 3, 2, 3);
            imageButton3.Size = new Size(132, 36);
            imageButton3.TabIndex = 2;
            imageButton3.TextImage = ResourceTemp.trash;
            imageButton3.TextLabel = "Remove";
            imageButton3.UseHoverEffect = true;
            imageButton3.Click += imageButton3_Click;
            // 
            // ShortcutRightClickMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(136, 118);
            ControlBox = false;
            Controls.Add(imageButton3);
            Controls.Add(imageButton2);
            Controls.Add(imageButton1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ShortcutRightClickMenu";
            Padding = new Padding(2);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "ShtortcutRightClickMenu";
            Deactivate += ShortcutRightClickMenu_Deactivate;
            ResumeLayout(false);
        }

        #endregion

        private RekenControls.ImageButton imageButton1;
        private RekenControls.ImageButton imageButton2;
        private RekenControls.ImageButton imageButton3;
    }
}