namespace School_Project.WForms.InitialForms
{
    partial class MainWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWinForm));
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novaToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            salvarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            visualizarImpressãoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            desfazerToolStripMenuItem = new ToolStripMenuItem();
            refazerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            recortarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selecionarTudoToolStripMenuItem = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            personalizarToolStripMenuItem = new ToolStripMenuItem();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sumárioToolStripMenuItem = new ToolStripMenuItem();
            índiceToolStripMenuItem = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            buttonCloseProgram = new Button();
            buttonListagens = new Button();
            buttonSchoolClass = new Button();
            buttonCharts = new Button();
            buttonStudent = new Button();
            buttonStudenDisciplines = new Button();
            buttonDiscipline = new Button();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, ferramentasToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaToolStripMenuItem, abrirToolStripMenuItem, toolStripSeparator, salvarToolStripMenuItem, salvarComoToolStripMenuItem, toolStripSeparator1, imprimirToolStripMenuItem, visualizarImpressãoToolStripMenuItem, toolStripSeparator2, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novaToolStripMenuItem
            // 
            novaToolStripMenuItem.Image = (Image)resources.GetObject("novaToolStripMenuItem.Image");
            novaToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            novaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            novaToolStripMenuItem.Size = new Size(180, 22);
            novaToolStripMenuItem.Text = "&Nova";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Image = (Image)resources.GetObject("abrirToolStripMenuItem.Image");
            abrirToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(177, 6);
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Image = (Image)resources.GetObject("salvarToolStripMenuItem.Image");
            salvarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            salvarToolStripMenuItem.Size = new Size(180, 22);
            salvarToolStripMenuItem.Text = "&Salvar";
            // 
            // salvarComoToolStripMenuItem
            // 
            salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            salvarComoToolStripMenuItem.Size = new Size(180, 22);
            salvarComoToolStripMenuItem.Text = "Salvar &Como";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Image = (Image)resources.GetObject("imprimirToolStripMenuItem.Image");
            imprimirToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            imprimirToolStripMenuItem.Size = new Size(180, 22);
            imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // visualizarImpressãoToolStripMenuItem
            // 
            visualizarImpressãoToolStripMenuItem.Image = (Image)resources.GetObject("visualizarImpressãoToolStripMenuItem.Image");
            visualizarImpressãoToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            visualizarImpressãoToolStripMenuItem.Name = "visualizarImpressãoToolStripMenuItem";
            visualizarImpressãoToolStripMenuItem.Size = new Size(180, 22);
            visualizarImpressãoToolStripMenuItem.Text = "Visualizar Im&pressão";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "S&air";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { desfazerToolStripMenuItem, refazerToolStripMenuItem, toolStripSeparator3, recortarToolStripMenuItem, copiarToolStripMenuItem, colarToolStripMenuItem, toolStripSeparator4, selecionarTudoToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            desfazerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            desfazerToolStripMenuItem.Size = new Size(159, 22);
            desfazerToolStripMenuItem.Text = "&Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            refazerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            refazerToolStripMenuItem.Size = new Size(159, 22);
            refazerToolStripMenuItem.Text = "&Refazer";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(156, 6);
            // 
            // recortarToolStripMenuItem
            // 
            recortarToolStripMenuItem.Image = (Image)resources.GetObject("recortarToolStripMenuItem.Image");
            recortarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            recortarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            recortarToolStripMenuItem.Size = new Size(159, 22);
            recortarToolStripMenuItem.Text = "Recor&tar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Image = (Image)resources.GetObject("copiarToolStripMenuItem.Image");
            copiarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copiarToolStripMenuItem.Size = new Size(159, 22);
            copiarToolStripMenuItem.Text = "&Copiar";
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Image = (Image)resources.GetObject("colarToolStripMenuItem.Image");
            colarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            colarToolStripMenuItem.Size = new Size(159, 22);
            colarToolStripMenuItem.Text = "&Colar";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(156, 6);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            selecionarTudoToolStripMenuItem.Size = new Size(159, 22);
            selecionarTudoToolStripMenuItem.Text = "Selecionar &Tudo";
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalizarToolStripMenuItem, opçõesToolStripMenuItem });
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new Size(84, 20);
            ferramentasToolStripMenuItem.Text = "&Ferramentas";
            // 
            // personalizarToolStripMenuItem
            // 
            personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            personalizarToolStripMenuItem.Size = new Size(137, 22);
            personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(137, 22);
            opçõesToolStripMenuItem.Text = "&Opções";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sumárioToolStripMenuItem, índiceToolStripMenuItem, pesquisarToolStripMenuItem, toolStripSeparator5, sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // sumárioToolStripMenuItem
            // 
            sumárioToolStripMenuItem.Name = "sumárioToolStripMenuItem";
            sumárioToolStripMenuItem.Size = new Size(124, 22);
            sumárioToolStripMenuItem.Text = "&Sumário";
            // 
            // índiceToolStripMenuItem
            // 
            índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            índiceToolStripMenuItem.Size = new Size(124, 22);
            índiceToolStripMenuItem.Text = "&Índice";
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(124, 22);
            pesquisarToolStripMenuItem.Text = "&Pesquisar";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(121, 6);
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(124, 22);
            sobreToolStripMenuItem.Text = "&Sobre...";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(buttonCloseProgram);
            toolStripContainer1.ContentPanel.Controls.Add(buttonListagens);
            toolStripContainer1.ContentPanel.Controls.Add(buttonSchoolClass);
            toolStripContainer1.ContentPanel.Controls.Add(buttonCharts);
            toolStripContainer1.ContentPanel.Controls.Add(buttonStudent);
            toolStripContainer1.ContentPanel.Controls.Add(buttonStudenDisciplines);
            toolStripContainer1.ContentPanel.Controls.Add(buttonDiscipline);
            toolStripContainer1.ContentPanel.Size = new Size(1134, 726);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 24);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1184, 751);
            toolStripContainer1.TabIndex = 2;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // buttonCloseProgram
            // 
            buttonCloseProgram.FlatAppearance.BorderSize = 0;
            buttonCloseProgram.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 255, 192);
            buttonCloseProgram.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonCloseProgram.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            buttonCloseProgram.FlatStyle = FlatStyle.Flat;
            buttonCloseProgram.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCloseProgram.ForeColor = Color.White;
            buttonCloseProgram.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCloseProgram.Location = new Point(30, 547);
            buttonCloseProgram.Name = "buttonCloseProgram";
            buttonCloseProgram.Size = new Size(200, 80);
            buttonCloseProgram.TabIndex = 12;
            buttonCloseProgram.Text = "Sair";
            buttonCloseProgram.TextAlign = ContentAlignment.MiddleRight;
            buttonCloseProgram.UseVisualStyleBackColor = true;
            buttonCloseProgram.Click += ButtonCloseProgram_Click;
            // 
            // buttonListagens
            // 
            buttonListagens.FlatAppearance.BorderSize = 0;
            buttonListagens.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 255, 192);
            buttonListagens.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonListagens.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            buttonListagens.FlatStyle = FlatStyle.Flat;
            buttonListagens.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListagens.ForeColor = Color.White;
            buttonListagens.Image = School_Project.Properties.Resources.Icon_printer_32x32;
            buttonListagens.ImageAlign = ContentAlignment.MiddleLeft;
            buttonListagens.Location = new Point(30, 461);
            buttonListagens.Name = "buttonListagens";
            buttonListagens.Size = new Size(200, 80);
            buttonListagens.TabIndex = 15;
            buttonListagens.Text = "Listagens";
            buttonListagens.TextAlign = ContentAlignment.MiddleRight;
            buttonListagens.UseVisualStyleBackColor = true;
            // 
            // buttonSchoolClass
            // 
            buttonSchoolClass.FlatAppearance.BorderSize = 0;
            buttonSchoolClass.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 255, 192);
            buttonSchoolClass.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonSchoolClass.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            buttonSchoolClass.FlatStyle = FlatStyle.Flat;
            buttonSchoolClass.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSchoolClass.ForeColor = Color.White;
            buttonSchoolClass.Image = School_Project.Properties.Resources.Icon_chalkboard_32x32;
            buttonSchoolClass.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSchoolClass.Location = new Point(30, 49);
            buttonSchoolClass.Name = "buttonSchoolClass";
            buttonSchoolClass.Size = new Size(200, 80);
            buttonSchoolClass.TabIndex = 13;
            buttonSchoolClass.Text = "Turmas";
            buttonSchoolClass.TextAlign = ContentAlignment.MiddleRight;
            buttonSchoolClass.UseVisualStyleBackColor = true;
            buttonSchoolClass.Click += ButtonSchoolClass_Click;
            // 
            // buttonCharts
            // 
            buttonCharts.FlatAppearance.BorderSize = 0;
            buttonCharts.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 255, 192);
            buttonCharts.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonCharts.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            buttonCharts.FlatStyle = FlatStyle.Flat;
            buttonCharts.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCharts.ForeColor = Color.White;
            buttonCharts.Image = School_Project.Properties.Resources.Icon_bar_chart_32x32;
            buttonCharts.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCharts.Location = new Point(30, 375);
            buttonCharts.Name = "buttonCharts";
            buttonCharts.Size = new Size(200, 80);
            buttonCharts.TabIndex = 14;
            buttonCharts.Text = "Gráficos";
            buttonCharts.TextAlign = ContentAlignment.MiddleRight;
            buttonCharts.UseVisualStyleBackColor = true;
            // 
            // buttonStudent
            // 
            buttonStudent.FlatAppearance.BorderSize = 0;
            buttonStudent.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 255, 192);
            buttonStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            buttonStudent.FlatStyle = FlatStyle.Flat;
            buttonStudent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStudent.ForeColor = Color.White;
            buttonStudent.Image = School_Project.Properties.Resources.Icon_id_card_32x32;
            buttonStudent.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStudent.Location = new Point(30, 117);
            buttonStudent.Name = "buttonStudent";
            buttonStudent.Size = new Size(200, 80);
            buttonStudent.TabIndex = 9;
            buttonStudent.Text = "Estudante";
            buttonStudent.TextAlign = ContentAlignment.MiddleRight;
            buttonStudent.UseVisualStyleBackColor = true;
            buttonStudent.Click += ButtonStudent_Click;
            // 
            // buttonStudenDisciplines
            // 
            buttonStudenDisciplines.FlatAppearance.BorderSize = 0;
            buttonStudenDisciplines.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 255, 192);
            buttonStudenDisciplines.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonStudenDisciplines.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            buttonStudenDisciplines.FlatStyle = FlatStyle.Flat;
            buttonStudenDisciplines.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStudenDisciplines.ForeColor = Color.White;
            buttonStudenDisciplines.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStudenDisciplines.Location = new Point(30, 289);
            buttonStudenDisciplines.Name = "buttonStudenDisciplines";
            buttonStudenDisciplines.Size = new Size(200, 80);
            buttonStudenDisciplines.TabIndex = 11;
            buttonStudenDisciplines.Text = "Estudante Disciplinas";
            buttonStudenDisciplines.TextAlign = ContentAlignment.MiddleRight;
            buttonStudenDisciplines.UseVisualStyleBackColor = true;
            buttonStudenDisciplines.Click += ButtonStudenDisciplines_Click;
            // 
            // buttonDiscipline
            // 
            buttonDiscipline.FlatAppearance.BorderSize = 0;
            buttonDiscipline.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 255, 192);
            buttonDiscipline.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonDiscipline.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            buttonDiscipline.FlatStyle = FlatStyle.Flat;
            buttonDiscipline.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDiscipline.ForeColor = Color.White;
            buttonDiscipline.Image = School_Project.Properties.Resources.Icon_book_green_32x32;
            buttonDiscipline.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDiscipline.Location = new Point(30, 203);
            buttonDiscipline.Name = "buttonDiscipline";
            buttonDiscipline.Size = new Size(200, 80);
            buttonDiscipline.TabIndex = 10;
            buttonDiscipline.Text = "Disciplina";
            buttonDiscipline.TextAlign = ContentAlignment.MiddleRight;
            buttonDiscipline.UseVisualStyleBackColor = true;
            buttonDiscipline.Click += ButtonDiscipline_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 753);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // MainWinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1184, 775);
            Controls.Add(statusStrip1);
            Controls.Add(toolStripContainer1);
            Controls.Add(menuStrip1);
            Name = "MainWinForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MainWinForm";
            Load += MainWinForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novaToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem salvarComoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem visualizarImpressãoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem recortarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem personalizarToolStripMenuItem;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sumárioToolStripMenuItem;
        private ToolStripMenuItem índiceToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private StatusStrip statusStrip1;
        private Button buttonListagens;
        private Button buttonCharts;
        private Button buttonSchoolClass;
        private Button buttonStudent;
        private Button buttonDiscipline;
        private Button buttonStudenDisciplines;
        private Button buttonCloseProgram;
    }
}