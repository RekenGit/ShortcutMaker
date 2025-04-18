﻿namespace ShortcutMaker.RekenControls
{
    partial class ColorPickerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPickerControl));
            textBoxColor = new TextBox();
            colorPicker_panel = new Panel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxColor
            // 
            textBoxColor.BorderStyle = BorderStyle.FixedSingle;
            textBoxColor.Dock = DockStyle.Left;
            textBoxColor.ImeMode = ImeMode.NoControl;
            textBoxColor.Location = new Point(0, 0);
            textBoxColor.Margin = new Padding(0);
            textBoxColor.MaxLength = 7;
            textBoxColor.Multiline = true;
            textBoxColor.Name = "textBoxColor";
            textBoxColor.RightToLeft = RightToLeft.No;
            textBoxColor.Size = new Size(56, 20);
            textBoxColor.TabIndex = 20;
            textBoxColor.TabStop = false;
            textBoxColor.Text = "000000";
            textBoxColor.WordWrap = false;
            textBoxColor.Leave += TextBoxColor_Leave;
            // 
            // colorPicker_panel
            // 
            colorPicker_panel.BackgroundImageLayout = ImageLayout.Center;
            colorPicker_panel.BorderStyle = BorderStyle.FixedSingle;
            colorPicker_panel.Cursor = Cursors.Hand;
            colorPicker_panel.Dock = DockStyle.Fill;
            colorPicker_panel.Location = new Point(0, 0);
            colorPicker_panel.Name = "colorPicker_panel";
            colorPicker_panel.Size = new Size(37, 20);
            colorPicker_panel.TabIndex = 19;
            colorPicker_panel.Click += ColorPicker_panel_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(colorPicker_panel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(56, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(37, 20);
            panel1.TabIndex = 21;
            // 
            // ColorPickerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Controls.Add(textBoxColor);
            Name = "ColorPickerControl";
            Size = new Size(93, 20);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxColor;
        private Panel colorPicker_panel;
        private Panel panel1;
    }
}
