namespace School_Project.WForms.InitialForms
{
    partial class FormAbout
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
            uC_About1 = new UControl.UC_About();
            SuspendLayout();
            // 
            // uC_About1
            // 
            uC_About1.BackColor = Color.Transparent;
            uC_About1.Dock = DockStyle.Fill;
            uC_About1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uC_About1.Location = new Point(0, 0);
            uC_About1.Name = "uC_About1";
            uC_About1.Size = new Size(584, 401);
            uC_About1.TabIndex = 0;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 36, 100);
            ClientSize = new Size(584, 401);
            Controls.Add(uC_About1);
            DoubleBuffered = true;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormAbout";
            Load += FormAbout_Load;
            KeyDown += WinForm_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private UControl.UC_About uC_About1;
    }
}