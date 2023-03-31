using School_Project.ClassesFolder;

namespace School_Project.WForms.CoursesForms
{
    partial class DisciplineAdd
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            labelDisciplineID = new Label();
            labelDisciplineName = new Label();
            textBoxDisciplineName = new TextBox();
            numericUpDownNumberHours = new NumericUpDown();
            numericUpDownDisciplineID = new NumericUpDown();
            buttonDisciplineSave = new Button();
            buttonDisciplineCancel = new Button();
            listBoxDisciplines = new ListBox();
            buttonDisciplineEdit = new Button();
            buttonDisciplineRemove = new Button();
            groupBoxDisciplineAdding = new GroupBox();
            transparentTabControl1 = new TransparentTabControl();
            tabPage1 = new TabPage();
            buttonStore = new Button();
            buttonClear = new Button();
            tabPage2 = new TabPage();
            checkedListBox1 = new CheckedListBox();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage4 = new TabPage();
            button1 = new Button();
            button2 = new Button();
            panelBottom = new Panel();
            buttonEdit = new Button();
            buttonRemove = new Button();
            buttonExit = new Button();
            buttonNew = new Button();
            buttonPrint = new Button();
            buttonAddCourses = new Button();
            tabPage5 = new TabPage();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisciplineID).BeginInit();
            groupBoxDisciplineAdding.SuspendLayout();
            transparentTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tabPage4.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(labelDisciplineID, 0, 0);
            tableLayoutPanel1.Controls.Add(labelDisciplineName, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxDisciplineName, 1, 1);
            tableLayoutPanel1.Controls.Add(numericUpDownNumberHours, 1, 2);
            tableLayoutPanel1.Controls.Add(numericUpDownDisciplineID, 1, 0);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(680, 244);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 186);
            label1.Name = "label1";
            label1.Size = new Size(164, 34);
            label1.TabIndex = 2;
            label1.Text = "Carga Horária da Disciplina:";
            // 
            // labelDisciplineID
            // 
            labelDisciplineID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelDisciplineID.AutoSize = true;
            labelDisciplineID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDisciplineID.Location = new Point(3, 32);
            labelDisciplineID.Name = "labelDisciplineID";
            labelDisciplineID.Size = new Size(164, 17);
            labelDisciplineID.TabIndex = 0;
            labelDisciplineID.Text = "ID da Disciplina:";
            // 
            // labelDisciplineName
            // 
            labelDisciplineName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelDisciplineName.AutoSize = true;
            labelDisciplineName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDisciplineName.Location = new Point(3, 113);
            labelDisciplineName.Name = "labelDisciplineName";
            labelDisciplineName.Size = new Size(164, 17);
            labelDisciplineName.TabIndex = 1;
            labelDisciplineName.Text = "Nome da Disciplina:";
            // 
            // textBoxDisciplineName
            // 
            textBoxDisciplineName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxDisciplineName.Location = new Point(173, 109);
            textBoxDisciplineName.Name = "textBoxDisciplineName";
            textBoxDisciplineName.Size = new Size(504, 25);
            textBoxDisciplineName.TabIndex = 4;
            textBoxDisciplineName.KeyUp += TextBox_KeyUp;
            // 
            // numericUpDownNumberHours
            // 
            numericUpDownNumberHours.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownNumberHours.Location = new Point(173, 190);
            numericUpDownNumberHours.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDownNumberHours.Name = "numericUpDownNumberHours";
            numericUpDownNumberHours.Size = new Size(504, 25);
            numericUpDownNumberHours.TabIndex = 5;
            numericUpDownNumberHours.TextAlign = HorizontalAlignment.Right;
            numericUpDownNumberHours.ThousandsSeparator = true;
            // 
            // numericUpDownDisciplineID
            // 
            numericUpDownDisciplineID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownDisciplineID.Enabled = false;
            numericUpDownDisciplineID.Location = new Point(173, 28);
            numericUpDownDisciplineID.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownDisciplineID.Name = "numericUpDownDisciplineID";
            numericUpDownDisciplineID.Size = new Size(504, 25);
            numericUpDownDisciplineID.TabIndex = 3;
            numericUpDownDisciplineID.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonDisciplineSave
            // 
            buttonDisciplineSave.Anchor = AnchorStyles.None;
            buttonDisciplineSave.AutoSize = true;
            buttonDisciplineSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDisciplineSave.Location = new Point(173, 488);
            buttonDisciplineSave.Name = "buttonDisciplineSave";
            buttonDisciplineSave.Size = new Size(110, 31);
            buttonDisciplineSave.TabIndex = 1;
            buttonDisciplineSave.Text = "Guardar";
            buttonDisciplineSave.UseVisualStyleBackColor = true;
            buttonDisciplineSave.Click += ButtonDisciplineSave_Click;
            // 
            // buttonDisciplineCancel
            // 
            buttonDisciplineCancel.Anchor = AnchorStyles.None;
            buttonDisciplineCancel.AutoSize = true;
            buttonDisciplineCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDisciplineCancel.Location = new Point(298, 488);
            buttonDisciplineCancel.Name = "buttonDisciplineCancel";
            buttonDisciplineCancel.Size = new Size(125, 31);
            buttonDisciplineCancel.TabIndex = 2;
            buttonDisciplineCancel.Text = "Limpar Dados";
            buttonDisciplineCancel.UseVisualStyleBackColor = true;
            buttonDisciplineCancel.Click += ButtonDisciplineCancel_Click;
            // 
            // listBoxDisciplines
            // 
            listBoxDisciplines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxDisciplines.FormattingEnabled = true;
            listBoxDisciplines.ItemHeight = 17;
            listBoxDisciplines.Location = new Point(49, 18);
            listBoxDisciplines.Name = "listBoxDisciplines";
            listBoxDisciplines.Size = new Size(710, 429);
            listBoxDisciplines.TabIndex = 0;
            // 
            // buttonDisciplineEdit
            // 
            buttonDisciplineEdit.Anchor = AnchorStyles.None;
            buttonDisciplineEdit.AutoSize = true;
            buttonDisciplineEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDisciplineEdit.Location = new Point(181, 68);
            buttonDisciplineEdit.Name = "buttonDisciplineEdit";
            buttonDisciplineEdit.Size = new Size(110, 31);
            buttonDisciplineEdit.TabIndex = 2;
            buttonDisciplineEdit.Text = "Editar";
            buttonDisciplineEdit.UseVisualStyleBackColor = true;
            buttonDisciplineEdit.Click += ButtonDisciplineEdit_Click;
            // 
            // buttonDisciplineRemove
            // 
            buttonDisciplineRemove.Anchor = AnchorStyles.None;
            buttonDisciplineRemove.AutoSize = true;
            buttonDisciplineRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDisciplineRemove.Location = new Point(181, 12);
            buttonDisciplineRemove.Name = "buttonDisciplineRemove";
            buttonDisciplineRemove.Size = new Size(110, 31);
            buttonDisciplineRemove.TabIndex = 1;
            buttonDisciplineRemove.Text = "Remover";
            buttonDisciplineRemove.UseVisualStyleBackColor = true;
            buttonDisciplineRemove.Click += ButtonDisciplineRemove_Click;
            // 
            // groupBoxDisciplineAdding
            // 
            groupBoxDisciplineAdding.Controls.Add(tableLayoutPanel1);
            groupBoxDisciplineAdding.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxDisciplineAdding.Location = new Point(23, 23);
            groupBoxDisciplineAdding.Name = "groupBoxDisciplineAdding";
            groupBoxDisciplineAdding.Size = new Size(697, 309);
            groupBoxDisciplineAdding.TabIndex = 0;
            groupBoxDisciplineAdding.TabStop = false;
            groupBoxDisciplineAdding.Text = "Adicionar Disciplina";
            // 
            // transparentTabControl1
            // 
            transparentTabControl1.Controls.Add(tabPage1);
            transparentTabControl1.Controls.Add(tabPage2);
            transparentTabControl1.Controls.Add(tabPage3);
            transparentTabControl1.Controls.Add(tabPage4);
            transparentTabControl1.Controls.Add(tabPage5);
            transparentTabControl1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            transparentTabControl1.Location = new Point(20, 22);
            transparentTabControl1.Margin = new Padding(5);
            transparentTabControl1.Name = "transparentTabControl1";
            transparentTabControl1.Padding = new Point(30, 10);
            transparentTabControl1.SelectedIndex = 0;
            transparentTabControl1.Size = new Size(974, 595);
            transparentTabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonStore);
            tabPage1.Controls.Add(buttonDisciplineCancel);
            tabPage1.Controls.Add(buttonDisciplineSave);
            tabPage1.Controls.Add(buttonClear);
            tabPage1.Controls.Add(groupBoxDisciplineAdding);
            tabPage1.Location = new Point(4, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(20);
            tabPage1.Size = new Size(966, 551);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "1 - Ficha";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonStore
            // 
            buttonStore.Anchor = AnchorStyles.None;
            buttonStore.BackgroundImage = Properties.Resources.guardar_base_dados_regular;
            buttonStore.BackgroundImageLayout = ImageLayout.Zoom;
            buttonStore.Cursor = Cursors.Hand;
            buttonStore.FlatAppearance.BorderSize = 0;
            buttonStore.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonStore.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonStore.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonStore.FlatStyle = FlatStyle.Flat;
            buttonStore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStore.Location = new Point(453, 478);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new Size(125, 50);
            buttonStore.TabIndex = 3;
            buttonStore.TextAlign = ContentAlignment.MiddleRight;
            buttonStore.UseVisualStyleBackColor = true;
            buttonStore.Click += ButtonDisciplineSave_Click;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.None;
            buttonClear.BackgroundImage = Properties.Resources.cancelar_solido;
            buttonClear.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonClear.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonClear.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.Location = new Point(581, 478);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(125, 50);
            buttonClear.TabIndex = 4;
            buttonClear.TextAlign = ContentAlignment.MiddleRight;
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ButtonDisciplineCancel_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(checkedListBox1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5);
            tabPage2.Size = new Size(966, 551);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "2 - Lista";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = DockStyle.Right;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(721, 5);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(240, 541);
            checkedListBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(5, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(721, 541);
            dataGridView1.TabIndex = 5;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(chart1);
            tabPage3.Location = new Point(4, 40);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(966, 551);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "3 - Gráficos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(3, 3);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(694, 369);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listBoxDisciplines);
            tabPage4.Location = new Point(4, 40);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(966, 551);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(53, 12);
            button1.Name = "button1";
            button1.Size = new Size(110, 31);
            button1.TabIndex = 3;
            button1.Text = "Remover";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(53, 68);
            button2.Name = "button2";
            button2.Size = new Size(110, 31);
            button2.TabIndex = 4;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonDisciplineEdit);
            panelBottom.Controls.Add(buttonDisciplineRemove);
            panelBottom.Controls.Add(buttonEdit);
            panelBottom.Controls.Add(button1);
            panelBottom.Controls.Add(buttonRemove);
            panelBottom.Controls.Add(button2);
            panelBottom.Controls.Add(buttonExit);
            panelBottom.Controls.Add(buttonNew);
            panelBottom.Controls.Add(buttonPrint);
            panelBottom.Controls.Add(buttonAddCourses);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(20, 622);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1378, 110);
            panelBottom.TabIndex = 6;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.None;
            buttonEdit.BackgroundImage = Properties.Resources.editar_solido;
            buttonEdit.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonEdit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonEdit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.Location = new Point(460, 2);
            buttonEdit.Margin = new Padding(0);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 50);
            buttonEdit.TabIndex = 1;
            buttonEdit.TextAlign = ContentAlignment.MiddleRight;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += ButtonDisciplineEdit_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Anchor = AnchorStyles.None;
            buttonRemove.BackgroundImage = Properties.Resources.apagar_solido;
            buttonRemove.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRemove.Cursor = Cursors.Hand;
            buttonRemove.FlatAppearance.BorderSize = 0;
            buttonRemove.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonRemove.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRemove.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemove.Location = new Point(332, 2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(125, 50);
            buttonRemove.TabIndex = 0;
            buttonRemove.TextAlign = ContentAlignment.MiddleRight;
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += ButtonDisciplineRemove_Click;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.None;
            buttonExit.BackgroundImage = Properties.Resources.sair_seta_solida;
            buttonExit.BackgroundImageLayout = ImageLayout.Zoom;
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(588, 58);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(125, 50);
            buttonExit.TabIndex = 4;
            buttonExit.TextAlign = ContentAlignment.MiddleRight;
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExit_Click;
            // 
            // buttonNew
            // 
            buttonNew.Anchor = AnchorStyles.None;
            buttonNew.BackgroundImage = Properties.Resources.novo_solido;
            buttonNew.BackgroundImageLayout = ImageLayout.Zoom;
            buttonNew.Cursor = Cursors.Hand;
            buttonNew.FlatAppearance.BorderSize = 0;
            buttonNew.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonNew.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonNew.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonNew.FlatStyle = FlatStyle.Flat;
            buttonNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNew.Location = new Point(588, 2);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(125, 50);
            buttonNew.TabIndex = 2;
            buttonNew.TextAlign = ContentAlignment.MiddleRight;
            buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            buttonPrint.Anchor = AnchorStyles.None;
            buttonPrint.BackgroundImage = Properties.Resources.botao_imprimir_solido_laser;
            buttonPrint.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPrint.Cursor = Cursors.Hand;
            buttonPrint.FlatAppearance.BorderSize = 0;
            buttonPrint.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonPrint.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonPrint.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonPrint.FlatStyle = FlatStyle.Flat;
            buttonPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrint.Location = new Point(460, 58);
            buttonPrint.Margin = new Padding(0);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(125, 50);
            buttonPrint.TabIndex = 3;
            buttonPrint.TextAlign = ContentAlignment.MiddleRight;
            buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonAddCourses
            // 
            buttonAddCourses.Anchor = AnchorStyles.None;
            buttonAddCourses.BackgroundImage = Properties.Resources.adicionar_estudante_solido;
            buttonAddCourses.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAddCourses.Cursor = Cursors.Hand;
            buttonAddCourses.FlatAppearance.BorderSize = 0;
            buttonAddCourses.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonAddCourses.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAddCourses.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAddCourses.FlatStyle = FlatStyle.Flat;
            buttonAddCourses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddCourses.Location = new Point(779, 2);
            buttonAddCourses.Name = "buttonAddCourses";
            buttonAddCourses.Size = new Size(125, 50);
            buttonAddCourses.TabIndex = 5;
            buttonAddCourses.TextAlign = ContentAlignment.MiddleRight;
            buttonAddCourses.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 40);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(966, 551);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // DisciplineAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1418, 752);
            Controls.Add(panelBottom);
            Controls.Add(transparentTabControl1);
            KeyPreview = true;
            Name = "DisciplineAdd";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulário Adicionar Disciplina";
            Load += DisciplineAdd_Load;
            KeyDown += DisciplineAdd_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisciplineID).EndInit();
            groupBoxDisciplineAdding.ResumeLayout(false);
            transparentTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            tabPage4.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelDisciplineID;
        private Label labelDisciplineName;
        private TextBox textBoxDisciplineName;
        private ListBox listBoxDisciplines;
        private Button buttonDisciplineSave;
        private Button buttonDisciplineCancel;
        private Button buttonDisciplineRemove;
        private Button buttonDisciplineEdit;
        private Label label1;
        private NumericUpDown numericUpDownNumberHours;
        private GroupBox groupBoxDisciplineAdding;
        private NumericUpDown numericUpDownDisciplineID;

        private TransparentTabControl transparentTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TabPage tabPage4;
        private CheckedListBox checkedListBox1;
        private Panel panelBottom;
        private Button buttonEdit;
        private Button buttonRemove;
        private Button buttonExit;
        private Button buttonNew;
        private Button buttonPrint;
        private Button buttonAddCourses;
        private Button buttonStore;
        private Button buttonClear;
        private TabPage tabPage5;
    }
}