﻿using School_Project.ClassFolder;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            groupBoxDisciplineAdding = new GroupBox();
            buttonStore = new Button();
            buttonClear = new Button();
            transparentTabControl1 = new TransparentTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            checkedListBox1 = new CheckedListBox();
            tabPage5 = new TabPage();
            dataGridViewSearch = new DataGridView();
            tabPage3 = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage4 = new TabPage();
            panelBottom = new Panel();
            comboBoxSearchList = new ComboBox();
            comboBoxSearchOptions = new ComboBox();
            buttonSearch = new Button();
            buttonSearchForm = new Button();
            buttonEdit = new Button();
            buttonRemove = new Button();
            buttonExit = new Button();
            buttonNew = new Button();
            buttonPrint = new Button();
            buttonAddStudents = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisciplineID).BeginInit();
            groupBoxDisciplineAdding.SuspendLayout();
            transparentTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
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
            tableLayoutPanel1.Location = new Point(23, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(715, 244);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 186);
            label1.Name = "label1";
            label1.Size = new Size(172, 34);
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
            labelDisciplineID.Size = new Size(172, 17);
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
            labelDisciplineName.Size = new Size(172, 17);
            labelDisciplineName.TabIndex = 1;
            labelDisciplineName.Text = "Nome da Disciplina:";
            // 
            // textBoxDisciplineName
            // 
            textBoxDisciplineName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxDisciplineName.Location = new Point(181, 109);
            textBoxDisciplineName.Name = "textBoxDisciplineName";
            textBoxDisciplineName.Size = new Size(531, 25);
            textBoxDisciplineName.TabIndex = 4;
            textBoxDisciplineName.KeyUp += TextBox_KeyUp;
            // 
            // numericUpDownNumberHours
            // 
            numericUpDownNumberHours.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownNumberHours.Location = new Point(181, 190);
            numericUpDownNumberHours.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDownNumberHours.Name = "numericUpDownNumberHours";
            numericUpDownNumberHours.Size = new Size(531, 25);
            numericUpDownNumberHours.TabIndex = 5;
            numericUpDownNumberHours.TextAlign = HorizontalAlignment.Right;
            numericUpDownNumberHours.ThousandsSeparator = true;
            // 
            // numericUpDownDisciplineID
            // 
            numericUpDownDisciplineID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownDisciplineID.Enabled = false;
            numericUpDownDisciplineID.Location = new Point(181, 28);
            numericUpDownDisciplineID.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownDisciplineID.Name = "numericUpDownDisciplineID";
            numericUpDownDisciplineID.Size = new Size(531, 25);
            numericUpDownDisciplineID.TabIndex = 3;
            numericUpDownDisciplineID.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBoxDisciplineAdding
            // 
            groupBoxDisciplineAdding.Controls.Add(buttonStore);
            groupBoxDisciplineAdding.Controls.Add(tableLayoutPanel1);
            groupBoxDisciplineAdding.Controls.Add(buttonClear);
            groupBoxDisciplineAdding.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxDisciplineAdding.Location = new Point(23, 23);
            groupBoxDisciplineAdding.Name = "groupBoxDisciplineAdding";
            groupBoxDisciplineAdding.Padding = new Padding(20);
            groupBoxDisciplineAdding.Size = new Size(768, 378);
            groupBoxDisciplineAdding.TabIndex = 0;
            groupBoxDisciplineAdding.TabStop = false;
            groupBoxDisciplineAdding.Text = "Adicionar Disciplina";
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
            buttonStore.Location = new Point(485, 305);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new Size(125, 50);
            buttonStore.TabIndex = 3;
            buttonStore.TextAlign = ContentAlignment.MiddleRight;
            buttonStore.UseVisualStyleBackColor = true;
            buttonStore.Click += ButtonSave_Click;
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
            buttonClear.Location = new Point(613, 305);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(125, 50);
            buttonClear.TabIndex = 4;
            buttonClear.TextAlign = ContentAlignment.MiddleRight;
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ButtonCancel_Click;
            // 
            // transparentTabControl1
            // 
            transparentTabControl1.Controls.Add(tabPage1);
            transparentTabControl1.Controls.Add(tabPage2);
            transparentTabControl1.Controls.Add(tabPage5);
            transparentTabControl1.Controls.Add(tabPage3);
            transparentTabControl1.Controls.Add(tabPage4);
            transparentTabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            transparentTabControl1.Location = new Point(20, 22);
            transparentTabControl1.Margin = new Padding(5);
            transparentTabControl1.Name = "transparentTabControl1";
            transparentTabControl1.Padding = new Point(30, 10);
            transparentTabControl1.SelectedIndex = 0;
            transparentTabControl1.Size = new Size(1044, 470);
            transparentTabControl1.TabIndex = 5;
            transparentTabControl1.SelectedIndexChanged += TransparentTabControl1_SelectedIndexChanged;
            transparentTabControl1.TabIndexChanged += TransparentTabControl1_TabIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBoxDisciplineAdding);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(20);
            tabPage1.Size = new Size(1036, 428);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "1 - Ficha";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 38);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5);
            tabPage2.Size = new Size(1036, 428);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "2 - Lista";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel2.Controls.Add(checkedListBox1, 1, 0);
            tableLayoutPanel2.Location = new Point(1, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1036, 424);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(771, 418);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellBeginEdit += DataGridView_CellBeginEdit;
            dataGridView1.CellEnter += DataGridView_CellEnter;
            dataGridView1.Scroll += DataGridView_Scroll;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(780, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(253, 418);
            checkedListBox1.TabIndex = 1;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dataGridViewSearch);
            tabPage5.Location = new Point(4, 38);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1036, 428);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "3 - Pesquisar";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSearch
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewSearch.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewSearch.Dock = DockStyle.Fill;
            dataGridViewSearch.Location = new Point(0, 0);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.RowTemplate.Height = 25;
            dataGridViewSearch.Size = new Size(1036, 428);
            dataGridViewSearch.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(chart1);
            tabPage3.Location = new Point(4, 38);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1036, 428);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "4 - Gráficos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(3, 3);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1030, 422);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 38);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1036, 428);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "5 - Lista";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            panelBottom.BorderStyle = BorderStyle.FixedSingle;
            panelBottom.Controls.Add(comboBoxSearchList);
            panelBottom.Controls.Add(comboBoxSearchOptions);
            panelBottom.Controls.Add(buttonSearch);
            panelBottom.Controls.Add(buttonSearchForm);
            panelBottom.Controls.Add(buttonEdit);
            panelBottom.Controls.Add(buttonRemove);
            panelBottom.Controls.Add(buttonExit);
            panelBottom.Controls.Add(buttonNew);
            panelBottom.Controls.Add(buttonPrint);
            panelBottom.Controls.Add(buttonAddStudents);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(20, 501);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1044, 110);
            panelBottom.TabIndex = 6;
            // 
            // comboBoxSearchList
            // 
            comboBoxSearchList.FormattingEnabled = true;
            comboBoxSearchList.Location = new Point(2, 74);
            comboBoxSearchList.Name = "comboBoxSearchList";
            comboBoxSearchList.Size = new Size(357, 23);
            comboBoxSearchList.TabIndex = 42;
            // 
            // comboBoxSearchOptions
            // 
            comboBoxSearchOptions.FormattingEnabled = true;
            comboBoxSearchOptions.Location = new Point(139, 20);
            comboBoxSearchOptions.Name = "comboBoxSearchOptions";
            comboBoxSearchOptions.Size = new Size(220, 23);
            comboBoxSearchOptions.TabIndex = 41;
            comboBoxSearchOptions.SelectedIndexChanged += ComboBoxSearchOptions_SelectedIndexChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.None;
            buttonSearch.BackgroundImage = Properties.Resources.pesquisar_negrito;
            buttonSearch.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonSearch.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSearch.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.Location = new Point(8, 1);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(125, 50);
            buttonSearch.TabIndex = 40;
            buttonSearch.TextAlign = ContentAlignment.MiddleRight;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // buttonSearchForm
            // 
            buttonSearchForm.Anchor = AnchorStyles.None;
            buttonSearchForm.BackgroundImage = Properties.Resources.pesquisar_negrito;
            buttonSearchForm.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSearchForm.Cursor = Cursors.Hand;
            buttonSearchForm.FlatAppearance.BorderSize = 0;
            buttonSearchForm.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonSearchForm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSearchForm.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSearchForm.FlatStyle = FlatStyle.Flat;
            buttonSearchForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchForm.Location = new Point(383, 57);
            buttonSearchForm.Name = "buttonSearchForm";
            buttonSearchForm.Size = new Size(125, 50);
            buttonSearchForm.TabIndex = 39;
            buttonSearchForm.TextAlign = ContentAlignment.MiddleRight;
            buttonSearchForm.UseVisualStyleBackColor = true;
            buttonSearchForm.Click += ButtonSearchForm_Click;
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
            buttonEdit.Location = new Point(511, 1);
            buttonEdit.Margin = new Padding(0);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 50);
            buttonEdit.TabIndex = 1;
            buttonEdit.TextAlign = ContentAlignment.MiddleRight;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += ButtonEdit_Click;
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
            buttonRemove.Location = new Point(383, 1);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(125, 50);
            buttonRemove.TabIndex = 0;
            buttonRemove.TextAlign = ContentAlignment.MiddleRight;
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += ButtonRemove_Click;
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
            buttonExit.Location = new Point(639, 57);
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
            buttonNew.Location = new Point(639, 1);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(125, 50);
            buttonNew.TabIndex = 2;
            buttonNew.TextAlign = ContentAlignment.MiddleRight;
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += ButtonNew_Click;
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
            buttonPrint.Location = new Point(511, 57);
            buttonPrint.Margin = new Padding(0);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(125, 50);
            buttonPrint.TabIndex = 3;
            buttonPrint.TextAlign = ContentAlignment.MiddleRight;
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += ButtonPrint_Click;
            // 
            // buttonAddStudents
            // 
            buttonAddStudents.Anchor = AnchorStyles.None;
            buttonAddStudents.BackgroundImage = Properties.Resources.adicionar_estudante_solido;
            buttonAddStudents.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAddStudents.Cursor = Cursors.Hand;
            buttonAddStudents.FlatAppearance.BorderSize = 0;
            buttonAddStudents.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonAddStudents.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAddStudents.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAddStudents.FlatStyle = FlatStyle.Flat;
            buttonAddStudents.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddStudents.Location = new Point(849, 1);
            buttonAddStudents.Name = "buttonAddStudents";
            buttonAddStudents.Size = new Size(125, 50);
            buttonAddStudents.TabIndex = 5;
            buttonAddStudents.TextAlign = ContentAlignment.MiddleRight;
            buttonAddStudents.UseVisualStyleBackColor = true;
            buttonAddStudents.Click += ButtonAddEnrollments_Click;
            // 
            // DisciplineAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 204, 202);
            ClientSize = new Size(1084, 631);
            Controls.Add(panelBottom);
            Controls.Add(transparentTabControl1);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "DisciplineAdd";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulário Adicionar Disciplina";
            Load += DisciplineAdd_Load;
            KeyDown += WinForm_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisciplineID).EndInit();
            groupBoxDisciplineAdding.ResumeLayout(false);
            transparentTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelDisciplineID;
        private Label labelDisciplineName;
        private TextBox textBoxDisciplineName;
        private Label label1;
        private NumericUpDown numericUpDownNumberHours;
        private GroupBox groupBoxDisciplineAdding;
        private NumericUpDown numericUpDownDisciplineID;

        private TransparentTabControl transparentTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TabPage tabPage4;
        private Panel panelBottom;
        private Button buttonEdit;
        private Button buttonRemove;
        private Button buttonExit;
        private Button buttonNew;
        private Button buttonPrint;
        private Button buttonAddStudents;
        private Button buttonStore;
        private Button buttonClear;
        private TabPage tabPage5;
        private ComboBox comboBoxSearchList;
        private ComboBox comboBoxSearchOptions;
        private Button buttonSearch;
        private Button buttonSearchForm;
        private DataGridView dataGridViewSearch;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
        private CheckedListBox checkedListBox1;
    }
}