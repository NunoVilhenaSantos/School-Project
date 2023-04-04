namespace School_Project.WForms.InitialForms
{
    partial class InitialWinForm
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
            tableLayoutPanelInitialForm = new TableLayoutPanel();
            buttonSchoolClass = new Button();
            labelTop = new Label();
            pictureBox1 = new PictureBox();
            buttonCloseProgram = new Button();
            buttonListagens = new Button();
            buttonCharts = new Button();
            buttonStudenDisciplines = new Button();
            buttonDiscipline = new Button();
            buttonStudent = new Button();
            buttonTeachers = new Button();
            buttonAbout = new Button();
            tableLayoutPanelInitialForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelInitialForm
            // 
            tableLayoutPanelInitialForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelInitialForm.ColumnCount = 2;
            tableLayoutPanelInitialForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanelInitialForm.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelInitialForm.Controls.Add(buttonSchoolClass, 0, 1);
            tableLayoutPanelInitialForm.Controls.Add(labelTop, 0, 0);
            tableLayoutPanelInitialForm.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanelInitialForm.Controls.Add(buttonCloseProgram, 0, 9);
            tableLayoutPanelInitialForm.Controls.Add(buttonListagens, 0, 7);
            tableLayoutPanelInitialForm.Controls.Add(buttonCharts, 0, 6);
            tableLayoutPanelInitialForm.Controls.Add(buttonStudenDisciplines, 0, 5);
            tableLayoutPanelInitialForm.Controls.Add(buttonDiscipline, 0, 4);
            tableLayoutPanelInitialForm.Controls.Add(buttonStudent, 0, 3);
            tableLayoutPanelInitialForm.Controls.Add(buttonTeachers, 0, 2);
            tableLayoutPanelInitialForm.Controls.Add(buttonAbout, 0, 8);
            tableLayoutPanelInitialForm.Dock = DockStyle.Fill;
            tableLayoutPanelInitialForm.Location = new Point(0, 0);
            tableLayoutPanelInitialForm.Margin = new Padding(5);
            tableLayoutPanelInitialForm.Name = "tableLayoutPanelInitialForm";
            tableLayoutPanelInitialForm.Padding = new Padding(5);
            tableLayoutPanelInitialForm.RowCount = 10;
            tableLayoutPanelInitialForm.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelInitialForm.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelInitialForm.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelInitialForm.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelInitialForm.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelInitialForm.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelInitialForm.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelInitialForm.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelInitialForm.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelInitialForm.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelInitialForm.Size = new Size(1134, 661);
            tableLayoutPanelInitialForm.TabIndex = 0;
            // 
            // buttonSchoolClass
            // 
            buttonSchoolClass.BackgroundImage = Properties.Resources.Icon_chalkboard_64x64;
            buttonSchoolClass.BackgroundImageLayout = ImageLayout.None;
            buttonSchoolClass.Dock = DockStyle.Fill;
            buttonSchoolClass.FlatAppearance.BorderSize = 0;
            buttonSchoolClass.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            buttonSchoolClass.FlatAppearance.MouseDownBackColor = Color.Yellow;
            buttonSchoolClass.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonSchoolClass.FlatStyle = FlatStyle.Flat;
            buttonSchoolClass.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSchoolClass.ForeColor = Color.White;
            buttonSchoolClass.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSchoolClass.Location = new Point(8, 73);
            buttonSchoolClass.Name = "buttonSchoolClass";
            buttonSchoolClass.Size = new Size(214, 59);
            buttonSchoolClass.TabIndex = 1;
            buttonSchoolClass.Text = "Turmas";
            buttonSchoolClass.TextAlign = ContentAlignment.MiddleRight;
            buttonSchoolClass.UseVisualStyleBackColor = true;
            buttonSchoolClass.Click += ButtonSchoolClass_Click;
            // 
            // labelTop
            // 
            labelTop.AutoSize = true;
            tableLayoutPanelInitialForm.SetColumnSpan(labelTop, 2);
            labelTop.Dock = DockStyle.Fill;
            labelTop.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTop.ForeColor = Color.White;
            labelTop.Location = new Point(8, 5);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(1118, 65);
            labelTop.TabIndex = 0;
            labelTop.Text = "Sistema de Informação de Gestão Escolar";
            labelTop.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = Properties.Resources.Students_watching_webinar;
            pictureBox1.Image = Properties.Resources.Students_watching_webinar;
            pictureBox1.Location = new Point(228, 73);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanelInitialForm.SetRowSpan(pictureBox1, 9);
            pictureBox1.Size = new Size(898, 580);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // buttonCloseProgram
            // 
            buttonCloseProgram.BackgroundImage = Properties.Resources.Icon_64x642;
            buttonCloseProgram.BackgroundImageLayout = ImageLayout.None;
            buttonCloseProgram.Dock = DockStyle.Fill;
            buttonCloseProgram.FlatAppearance.BorderSize = 0;
            buttonCloseProgram.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            buttonCloseProgram.FlatAppearance.MouseDownBackColor = Color.Yellow;
            buttonCloseProgram.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonCloseProgram.FlatStyle = FlatStyle.Flat;
            buttonCloseProgram.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCloseProgram.ForeColor = Color.White;
            buttonCloseProgram.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCloseProgram.Location = new Point(8, 593);
            buttonCloseProgram.Name = "buttonCloseProgram";
            buttonCloseProgram.Size = new Size(214, 60);
            buttonCloseProgram.TabIndex = 9;
            buttonCloseProgram.Text = "Sair";
            buttonCloseProgram.TextAlign = ContentAlignment.MiddleRight;
            buttonCloseProgram.UseVisualStyleBackColor = true;
            buttonCloseProgram.Click += ButtonCloseProgram_Click;
            // 
            // buttonListagens
            // 
            buttonListagens.BackgroundImage = Properties.Resources.Icon_printer_64x64;
            buttonListagens.BackgroundImageLayout = ImageLayout.None;
            buttonListagens.Dock = DockStyle.Fill;
            buttonListagens.FlatAppearance.BorderSize = 0;
            buttonListagens.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            buttonListagens.FlatAppearance.MouseDownBackColor = Color.Yellow;
            buttonListagens.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonListagens.FlatStyle = FlatStyle.Flat;
            buttonListagens.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListagens.ForeColor = Color.White;
            buttonListagens.ImageAlign = ContentAlignment.MiddleLeft;
            buttonListagens.Location = new Point(8, 463);
            buttonListagens.Name = "buttonListagens";
            buttonListagens.Size = new Size(214, 59);
            buttonListagens.TabIndex = 7;
            buttonListagens.Text = "Listagens";
            buttonListagens.TextAlign = ContentAlignment.MiddleRight;
            buttonListagens.UseVisualStyleBackColor = true;
            buttonListagens.Click += ButtonListagens_Click;
            // 
            // buttonCharts
            // 
            buttonCharts.BackgroundImage = Properties.Resources.Icon_64x644;
            buttonCharts.BackgroundImageLayout = ImageLayout.None;
            buttonCharts.Dock = DockStyle.Fill;
            buttonCharts.FlatAppearance.BorderSize = 0;
            buttonCharts.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            buttonCharts.FlatAppearance.MouseDownBackColor = Color.Yellow;
            buttonCharts.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonCharts.FlatStyle = FlatStyle.Flat;
            buttonCharts.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCharts.ForeColor = Color.White;
            buttonCharts.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCharts.Location = new Point(8, 398);
            buttonCharts.Name = "buttonCharts";
            buttonCharts.Size = new Size(214, 59);
            buttonCharts.TabIndex = 6;
            buttonCharts.Text = "Gráficos";
            buttonCharts.TextAlign = ContentAlignment.MiddleRight;
            buttonCharts.UseVisualStyleBackColor = true;
            buttonCharts.Click += ButtonCharts_Click;
            // 
            // buttonStudenDisciplines
            // 
            buttonStudenDisciplines.BackgroundImageLayout = ImageLayout.None;
            buttonStudenDisciplines.Dock = DockStyle.Fill;
            buttonStudenDisciplines.FlatAppearance.BorderSize = 0;
            buttonStudenDisciplines.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            buttonStudenDisciplines.FlatAppearance.MouseDownBackColor = Color.Yellow;
            buttonStudenDisciplines.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonStudenDisciplines.FlatStyle = FlatStyle.Flat;
            buttonStudenDisciplines.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStudenDisciplines.ForeColor = Color.White;
            buttonStudenDisciplines.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStudenDisciplines.Location = new Point(8, 333);
            buttonStudenDisciplines.Name = "buttonStudenDisciplines";
            buttonStudenDisciplines.Size = new Size(214, 59);
            buttonStudenDisciplines.TabIndex = 5;
            buttonStudenDisciplines.Text = "Estudante Disciplinas";
            buttonStudenDisciplines.TextAlign = ContentAlignment.MiddleRight;
            buttonStudenDisciplines.UseVisualStyleBackColor = true;
            buttonStudenDisciplines.Click += ButtonStudentDisciplines_Click;
            // 
            // buttonDiscipline
            // 
            buttonDiscipline.BackgroundImage = Properties.Resources.Icon_64x643;
            buttonDiscipline.BackgroundImageLayout = ImageLayout.None;
            buttonDiscipline.Dock = DockStyle.Fill;
            buttonDiscipline.FlatAppearance.BorderSize = 0;
            buttonDiscipline.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            buttonDiscipline.FlatAppearance.MouseDownBackColor = Color.Yellow;
            buttonDiscipline.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonDiscipline.FlatStyle = FlatStyle.Flat;
            buttonDiscipline.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDiscipline.ForeColor = Color.White;
            buttonDiscipline.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDiscipline.Location = new Point(8, 268);
            buttonDiscipline.Name = "buttonDiscipline";
            buttonDiscipline.Size = new Size(214, 59);
            buttonDiscipline.TabIndex = 4;
            buttonDiscipline.Text = "Disciplinas";
            buttonDiscipline.TextAlign = ContentAlignment.MiddleRight;
            buttonDiscipline.UseVisualStyleBackColor = true;
            buttonDiscipline.Click += ButtonDiscipline_Click;
            // 
            // buttonStudent
            // 
            buttonStudent.BackgroundImage = Properties.Resources.Icon_graduate_64x64;
            buttonStudent.BackgroundImageLayout = ImageLayout.None;
            buttonStudent.Dock = DockStyle.Fill;
            buttonStudent.FlatAppearance.BorderSize = 0;
            buttonStudent.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            buttonStudent.FlatAppearance.MouseDownBackColor = Color.Yellow;
            buttonStudent.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonStudent.FlatStyle = FlatStyle.Flat;
            buttonStudent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStudent.ForeColor = Color.White;
            buttonStudent.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStudent.Location = new Point(8, 203);
            buttonStudent.Name = "buttonStudent";
            buttonStudent.Size = new Size(214, 59);
            buttonStudent.TabIndex = 3;
            buttonStudent.Text = "Estudantes";
            buttonStudent.TextAlign = ContentAlignment.MiddleRight;
            buttonStudent.UseVisualStyleBackColor = true;
            buttonStudent.Click += ButtonStudent_Click;
            // 
            // buttonTeachers
            // 
            buttonTeachers.BackgroundImage = Properties.Resources.Icon_id_card_64x64;
            buttonTeachers.BackgroundImageLayout = ImageLayout.None;
            buttonTeachers.Dock = DockStyle.Fill;
            buttonTeachers.FlatAppearance.BorderSize = 0;
            buttonTeachers.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            buttonTeachers.FlatAppearance.MouseDownBackColor = Color.Yellow;
            buttonTeachers.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonTeachers.FlatStyle = FlatStyle.Flat;
            buttonTeachers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTeachers.ForeColor = Color.White;
            buttonTeachers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTeachers.Location = new Point(8, 138);
            buttonTeachers.Name = "buttonTeachers";
            buttonTeachers.Size = new Size(214, 59);
            buttonTeachers.TabIndex = 2;
            buttonTeachers.Text = "Professores";
            buttonTeachers.TextAlign = ContentAlignment.MiddleRight;
            buttonTeachers.UseVisualStyleBackColor = true;
            buttonTeachers.Click += ButtonTeachers_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.BackgroundImageLayout = ImageLayout.None;
            buttonAbout.Dock = DockStyle.Fill;
            buttonAbout.FlatAppearance.BorderSize = 0;
            buttonAbout.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            buttonAbout.FlatAppearance.MouseDownBackColor = Color.Yellow;
            buttonAbout.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonAbout.FlatStyle = FlatStyle.Flat;
            buttonAbout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAbout.ForeColor = Color.White;
            buttonAbout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbout.Location = new Point(8, 528);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(214, 59);
            buttonAbout.TabIndex = 8;
            buttonAbout.Text = "Sobre";
            buttonAbout.TextAlign = ContentAlignment.MiddleRight;
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += ButtonAbout_Click;
            // 
            // InitialWinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(1134, 661);
            Controls.Add(tableLayoutPanelInitialForm);
            DoubleBuffered = true;
            ForeColor = Color.Transparent;
            HelpButton = true;
            MinimumSize = new Size(1150, 700);
            Name = "InitialWinForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário Principal";
            FormClosing += WinFormInitial_FormClosing;
            Load += WinFormInitial_Load;
            tableLayoutPanelInitialForm.ResumeLayout(false);
            tableLayoutPanelInitialForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelInitialForm;
        private Button buttonStudent;
        private Button buttonDiscipline;
        private Button buttonCloseProgram;
        private PictureBox pictureBox1;
        private Button buttonStudenDisciplines;
        private Label labelTop;
        private Button buttonSchoolClass;
        private Button buttonCharts;
        private Button buttonListagens;
        private Button buttonTeachers;
        private Button buttonAbout;
    }
}