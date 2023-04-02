
namespace School_Project.UControl
{
    partial class UC_About
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_About));
            tabControlVersao = new TabControl();
            tabVersion = new TabPage();
            labelVersion = new Label();
            tabAbout = new TabPage();
            labelAbout = new Label();
            tabControlVersao.SuspendLayout();
            tabVersion.SuspendLayout();
            tabAbout.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlVersao
            // 
            tabControlVersao.Controls.Add(tabVersion);
            tabControlVersao.Controls.Add(tabAbout);
            tabControlVersao.Dock = DockStyle.Fill;
            tabControlVersao.Location = new Point(0, 0);
            tabControlVersao.Name = "tabControlVersao";
            tabControlVersao.SelectedIndex = 0;
            tabControlVersao.Size = new Size(596, 416);
            tabControlVersao.TabIndex = 0;
            // 
            // tabVersion
            // 
            tabVersion.BackColor = Color.FromArgb(83, 36, 100);
            tabVersion.Controls.Add(labelVersion);
            tabVersion.ForeColor = Color.Transparent;
            tabVersion.Location = new Point(4, 30);
            tabVersion.Name = "tabVersion";
            tabVersion.Padding = new Padding(15);
            tabVersion.Size = new Size(588, 382);
            tabVersion.TabIndex = 0;
            tabVersion.Text = "Versão";
            // 
            // labelVersion
            // 
            labelVersion.BackColor = Color.Transparent;
            labelVersion.BorderStyle = BorderStyle.Fixed3D;
            labelVersion.Dock = DockStyle.Fill;
            labelVersion.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelVersion.Location = new Point(15, 15);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(558, 352);
            labelVersion.TabIndex = 0;
            labelVersion.Text = resources.GetString("labelVersion.Text");
            // 
            // tabAbout
            // 
            tabAbout.BackColor = Color.FromArgb(83, 36, 100);
            tabAbout.Controls.Add(labelAbout);
            tabAbout.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabAbout.ForeColor = Color.Transparent;
            tabAbout.Location = new Point(4, 30);
            tabAbout.Name = "tabAbout";
            tabAbout.Padding = new Padding(15);
            tabAbout.Size = new Size(588, 382);
            tabAbout.TabIndex = 1;
            tabAbout.Text = "Sobre";
            // 
            // labelAbout
            // 
            labelAbout.BackColor = Color.Transparent;
            labelAbout.BorderStyle = BorderStyle.Fixed3D;
            labelAbout.Dock = DockStyle.Fill;
            labelAbout.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAbout.Location = new Point(15, 15);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(558, 352);
            labelAbout.TabIndex = 1;
            labelAbout.Text = resources.GetString("labelAbout.Text");
            // 
            // UC_About
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tabControlVersao);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UC_About";
            Size = new Size(596, 416);
            tabControlVersao.ResumeLayout(false);
            tabVersion.ResumeLayout(false);
            tabAbout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlVersao;
        private System.Windows.Forms.TabPage tabVersion;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label labelAbout;
    }
}
