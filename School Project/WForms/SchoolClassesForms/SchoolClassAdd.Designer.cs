using School_Project.ClassesFolder;
using School_Project.Properties;

namespace School_Project.WForms.SchoolClassesForms
{
    partial class SchoolClassAdd
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolClassAdd));
            labelSchoolClassID = new Label();
            labelSchoolClassName = new Label();
            labelStudentLastName = new Label();
            textBoxSchoolClassAcronym = new TextBox();
            textBoxSchoolClassName = new TextBox();
            tableLayoutPanelStudentData = new TableLayoutPanel();
            numericUpDownTotalCourses = new NumericUpDown();
            label6 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            numericUpDownSchoolClassID = new NumericUpDown();
            numericUpDownTotalNumberEnrolledStudents = new NumericUpDown();
            label2 = new Label();
            dateTimePickerBeginCourse = new DateTimePicker();
            dateTimePickerEndCourse = new DateTimePicker();
            dateTimePickerEndHour = new DateTimePicker();
            dateTimePickerBeginHour = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            labelTotalNumberEnrolledStudents = new Label();
            label5 = new Label();
            numericUpDownWorkingHours = new NumericUpDown();
            buttonAddPhoto = new Button();
            checkedListBoxStudents = new CheckedListBox();
            tabPage1 = new TabPage();
            buttonStore = new Button();
            buttonClear = new Button();
            tabPage2 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewSchoolClasses = new DataGridView();
            checkedListBoxCourses = new CheckedListBox();
            tabPage3 = new TabPage();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button7 = new Button();
            button6 = new Button();
            buttonPrint = new Button();
            panelBottom = new Panel();
            button4 = new Button();
            button9 = new Button();
            buttonEdit = new Button();
            buttonRemove = new Button();
            buttonClose = new Button();
            buttonNew = new Button();
            openFileDialog1 = new OpenFileDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            transparentTabControl1 = new TransparentTabControl();
            tableLayoutPanelStudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSchoolClassID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalNumberEnrolledStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWorkingHours).BeginInit();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchoolClasses).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panelBottom.SuspendLayout();
            transparentTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // labelSchoolClassID
            // 
            labelSchoolClassID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelSchoolClassID.AutoSize = true;
            labelSchoolClassID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSchoolClassID.Location = new Point(3, 18);
            labelSchoolClassID.Name = "labelSchoolClassID";
            labelSchoolClassID.Size = new Size(94, 17);
            labelSchoolClassID.TabIndex = 0;
            labelSchoolClassID.Text = "ID da Turma:";
            // 
            // labelSchoolClassName
            // 
            labelSchoolClassName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelSchoolClassName.AutoSize = true;
            labelSchoolClassName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSchoolClassName.Location = new Point(3, 62);
            labelSchoolClassName.Name = "labelSchoolClassName";
            labelSchoolClassName.Size = new Size(94, 34);
            labelSchoolClassName.TabIndex = 4;
            labelSchoolClassName.Text = "Acrónimo Turma:";
            // 
            // labelStudentLastName
            // 
            labelStudentLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelStudentLastName.AutoSize = true;
            labelStudentLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentLastName.Location = new Point(3, 115);
            labelStudentLastName.Name = "labelStudentLastName";
            labelStudentLastName.Size = new Size(94, 34);
            labelStudentLastName.TabIndex = 6;
            labelStudentLastName.Text = "Nome da Turma:";
            // 
            // textBoxSchoolClassAcronym
            // 
            textBoxSchoolClassAcronym.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSchoolClassAcronym.CharacterCasing = CharacterCasing.Upper;
            textBoxSchoolClassAcronym.Location = new Point(103, 68);
            textBoxSchoolClassAcronym.Name = "textBoxSchoolClassAcronym";
            textBoxSchoolClassAcronym.PlaceholderText = "Acrónimo Turma";
            textBoxSchoolClassAcronym.Size = new Size(228, 23);
            textBoxSchoolClassAcronym.TabIndex = 5;
            textBoxSchoolClassAcronym.KeyPress += TextBoxNames_KeyPress;
            textBoxSchoolClassAcronym.KeyUp += TextBox_KeyUp;
            // 
            // textBoxSchoolClassName
            // 
            textBoxSchoolClassName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSchoolClassName.Location = new Point(103, 121);
            textBoxSchoolClassName.Name = "textBoxSchoolClassName";
            textBoxSchoolClassName.PlaceholderText = "Nome da Turma";
            textBoxSchoolClassName.Size = new Size(228, 23);
            textBoxSchoolClassName.TabIndex = 7;
            textBoxSchoolClassName.KeyPress += TextBoxNames_KeyPress;
            textBoxSchoolClassName.KeyUp += TextBox_KeyUp;
            // 
            // tableLayoutPanelStudentData
            // 
            tableLayoutPanelStudentData.Anchor = AnchorStyles.None;
            tableLayoutPanelStudentData.ColumnCount = 5;
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanelStudentData.Controls.Add(numericUpDownTotalCourses, 3, 1);
            tableLayoutPanelStudentData.Controls.Add(label6, 2, 1);
            tableLayoutPanelStudentData.Controls.Add(label1, 0, 4);
            tableLayoutPanelStudentData.Controls.Add(labelSchoolClassID, 0, 0);
            tableLayoutPanelStudentData.Controls.Add(labelSchoolClassName, 0, 1);
            tableLayoutPanelStudentData.Controls.Add(pictureBox1, 4, 0);
            tableLayoutPanelStudentData.Controls.Add(labelStudentLastName, 0, 2);
            tableLayoutPanelStudentData.Controls.Add(textBoxSchoolClassName, 1, 2);
            tableLayoutPanelStudentData.Controls.Add(textBoxSchoolClassAcronym, 1, 1);
            tableLayoutPanelStudentData.Controls.Add(numericUpDownSchoolClassID, 1, 0);
            tableLayoutPanelStudentData.Controls.Add(numericUpDownTotalNumberEnrolledStudents, 3, 0);
            tableLayoutPanelStudentData.Controls.Add(label2, 2, 4);
            tableLayoutPanelStudentData.Controls.Add(dateTimePickerBeginCourse, 1, 4);
            tableLayoutPanelStudentData.Controls.Add(dateTimePickerEndCourse, 3, 4);
            tableLayoutPanelStudentData.Controls.Add(dateTimePickerEndHour, 3, 5);
            tableLayoutPanelStudentData.Controls.Add(dateTimePickerBeginHour, 1, 5);
            tableLayoutPanelStudentData.Controls.Add(label3, 0, 5);
            tableLayoutPanelStudentData.Controls.Add(label4, 2, 5);
            tableLayoutPanelStudentData.Controls.Add(labelTotalNumberEnrolledStudents, 2, 0);
            tableLayoutPanelStudentData.Controls.Add(label5, 2, 2);
            tableLayoutPanelStudentData.Controls.Add(numericUpDownWorkingHours, 3, 2);
            tableLayoutPanelStudentData.Controls.Add(buttonAddPhoto, 4, 5);
            tableLayoutPanelStudentData.Location = new Point(13, 17);
            tableLayoutPanelStudentData.Name = "tableLayoutPanelStudentData";
            tableLayoutPanelStudentData.RowCount = 6;
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelStudentData.Size = new Size(870, 323);
            tableLayoutPanelStudentData.TabIndex = 0;
            // 
            // numericUpDownTotalCourses
            // 
            numericUpDownTotalCourses.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownTotalCourses.Enabled = false;
            numericUpDownTotalCourses.Location = new Point(437, 68);
            numericUpDownTotalCourses.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownTotalCourses.Name = "numericUpDownTotalCourses";
            numericUpDownTotalCourses.Size = new Size(228, 23);
            numericUpDownTotalCourses.TabIndex = 14;
            numericUpDownTotalCourses.TextAlign = HorizontalAlignment.Right;
            numericUpDownTotalCourses.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(337, 62);
            label6.Name = "label6";
            label6.Size = new Size(94, 34);
            label6.TabIndex = 14;
            label6.Text = "Total dos Cursos:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 221);
            label1.Name = "label1";
            label1.Size = new Size(94, 34);
            label1.TabIndex = 8;
            label1.Text = "Inicio formação:";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(671, 3);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanelStudentData.SetRowSpan(pictureBox1, 5);
            pictureBox1.Size = new Size(196, 259);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // numericUpDownSchoolClassID
            // 
            numericUpDownSchoolClassID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownSchoolClassID.Enabled = false;
            numericUpDownSchoolClassID.Location = new Point(103, 15);
            numericUpDownSchoolClassID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownSchoolClassID.Name = "numericUpDownSchoolClassID";
            numericUpDownSchoolClassID.Size = new Size(228, 23);
            numericUpDownSchoolClassID.TabIndex = 1;
            numericUpDownSchoolClassID.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownTotalNumberEnrolledStudents
            // 
            numericUpDownTotalNumberEnrolledStudents.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownTotalNumberEnrolledStudents.Enabled = false;
            numericUpDownTotalNumberEnrolledStudents.Location = new Point(437, 15);
            numericUpDownTotalNumberEnrolledStudents.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownTotalNumberEnrolledStudents.Name = "numericUpDownTotalNumberEnrolledStudents";
            numericUpDownTotalNumberEnrolledStudents.Size = new Size(228, 23);
            numericUpDownTotalNumberEnrolledStudents.TabIndex = 3;
            numericUpDownTotalNumberEnrolledStudents.TextAlign = HorizontalAlignment.Right;
            numericUpDownTotalNumberEnrolledStudents.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(337, 221);
            label2.Name = "label2";
            label2.Size = new Size(94, 34);
            label2.TabIndex = 10;
            label2.Text = "Fim formação:";
            // 
            // dateTimePickerBeginCourse
            // 
            dateTimePickerBeginCourse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerBeginCourse.Location = new Point(103, 227);
            dateTimePickerBeginCourse.Name = "dateTimePickerBeginCourse";
            dateTimePickerBeginCourse.Size = new Size(228, 23);
            dateTimePickerBeginCourse.TabIndex = 9;
            // 
            // dateTimePickerEndCourse
            // 
            dateTimePickerEndCourse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerEndCourse.Location = new Point(437, 227);
            dateTimePickerEndCourse.Name = "dateTimePickerEndCourse";
            dateTimePickerEndCourse.Size = new Size(228, 23);
            dateTimePickerEndCourse.TabIndex = 11;
            // 
            // dateTimePickerEndHour
            // 
            dateTimePickerEndHour.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerEndHour.Format = DateTimePickerFormat.Time;
            dateTimePickerEndHour.Location = new Point(437, 282);
            dateTimePickerEndHour.Name = "dateTimePickerEndHour";
            dateTimePickerEndHour.Size = new Size(228, 23);
            dateTimePickerEndHour.TabIndex = 15;
            // 
            // dateTimePickerBeginHour
            // 
            dateTimePickerBeginHour.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerBeginHour.Format = DateTimePickerFormat.Time;
            dateTimePickerBeginHour.Location = new Point(103, 282);
            dateTimePickerBeginHour.Name = "dateTimePickerBeginHour";
            dateTimePickerBeginHour.Size = new Size(228, 23);
            dateTimePickerBeginHour.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 285);
            label3.Name = "label3";
            label3.Size = new Size(94, 17);
            label3.TabIndex = 12;
            label3.Text = "Hora Inicio:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(337, 285);
            label4.Name = "label4";
            label4.Size = new Size(94, 17);
            label4.TabIndex = 14;
            label4.Text = "Hora Fim";
            // 
            // labelTotalNumberEnrolledStudents
            // 
            labelTotalNumberEnrolledStudents.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelTotalNumberEnrolledStudents.AutoSize = true;
            labelTotalNumberEnrolledStudents.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalNumberEnrolledStudents.Location = new Point(337, 1);
            labelTotalNumberEnrolledStudents.Name = "labelTotalNumberEnrolledStudents";
            labelTotalNumberEnrolledStudents.Size = new Size(94, 51);
            labelTotalNumberEnrolledStudents.TabIndex = 2;
            labelTotalNumberEnrolledStudents.Text = "Total Estudantes Inscritos:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(337, 115);
            label5.Name = "label5";
            label5.Size = new Size(94, 34);
            label5.TabIndex = 3;
            label5.Text = "Total Horas dos Cursos:";
            // 
            // numericUpDownWorkingHours
            // 
            numericUpDownWorkingHours.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownWorkingHours.Enabled = false;
            numericUpDownWorkingHours.Location = new Point(437, 121);
            numericUpDownWorkingHours.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownWorkingHours.Name = "numericUpDownWorkingHours";
            numericUpDownWorkingHours.Size = new Size(228, 23);
            numericUpDownWorkingHours.TabIndex = 4;
            numericUpDownWorkingHours.TextAlign = HorizontalAlignment.Right;
            numericUpDownWorkingHours.ThousandsSeparator = true;
            // 
            // buttonAddPhoto
            // 
            buttonAddPhoto.Anchor = AnchorStyles.None;
            buttonAddPhoto.BackgroundImage = Resources.importar_foto;
            buttonAddPhoto.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAddPhoto.Cursor = Cursors.Hand;
            buttonAddPhoto.FlatAppearance.BorderSize = 0;
            buttonAddPhoto.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonAddPhoto.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAddPhoto.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAddPhoto.FlatStyle = FlatStyle.Flat;
            buttonAddPhoto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddPhoto.Location = new Point(706, 269);
            buttonAddPhoto.Margin = new Padding(0);
            buttonAddPhoto.Name = "buttonAddPhoto";
            buttonAddPhoto.Size = new Size(125, 50);
            buttonAddPhoto.TabIndex = 8;
            buttonAddPhoto.TextAlign = ContentAlignment.MiddleRight;
            buttonAddPhoto.UseVisualStyleBackColor = true;
            buttonAddPhoto.Click += ButtonAddPhoto_Click;
            // 
            // checkedListBoxStudents
            // 
            checkedListBoxStudents.Dock = DockStyle.Fill;
            checkedListBoxStudents.FormattingEnabled = true;
            checkedListBoxStudents.Location = new Point(1131, 3);
            checkedListBoxStudents.Name = "checkedListBoxStudents";
            checkedListBoxStudents.Size = new Size(276, 564);
            checkedListBoxStudents.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(tableLayoutPanelStudentData);
            tabPage1.Controls.Add(buttonStore);
            tabPage1.Controls.Add(buttonClear);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(10);
            tabPage1.Size = new Size(1416, 566);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "1 - Ficha";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonStore
            // 
            buttonStore.Anchor = AnchorStyles.None;
            buttonStore.BackgroundImage = Resources.guardar_base_dados_regular;
            buttonStore.BackgroundImageLayout = ImageLayout.Zoom;
            buttonStore.Cursor = Cursors.Hand;
            buttonStore.FlatAppearance.BorderSize = 0;
            buttonStore.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonStore.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonStore.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonStore.FlatStyle = FlatStyle.Flat;
            buttonStore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStore.Location = new Point(597, 503);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new Size(125, 50);
            buttonStore.TabIndex = 13;
            buttonStore.TextAlign = ContentAlignment.MiddleRight;
            buttonStore.UseVisualStyleBackColor = true;
            buttonStore.Click += ButtonSave_Click;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.None;
            buttonClear.BackgroundImage = Resources.cancelar_solido;
            buttonClear.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonClear.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonClear.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.Location = new Point(725, 503);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(125, 50);
            buttonClear.TabIndex = 9;
            buttonClear.TextAlign = ContentAlignment.MiddleRight;
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ButtonCancel_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 38);
            tabPage2.Margin = new Padding(10);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(10);
            tabPage2.Size = new Size(1416, 566);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "2 - Lista";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(dataGridViewSchoolClasses, 0, 0);
            tableLayoutPanel1.Controls.Add(checkedListBoxStudents, 2, 0);
            tableLayoutPanel1.Controls.Add(checkedListBoxCourses, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1410, 570);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewSchoolClasses
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSchoolClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSchoolClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewSchoolClasses.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSchoolClasses.Dock = DockStyle.Fill;
            dataGridViewSchoolClasses.Location = new Point(3, 3);
            dataGridViewSchoolClasses.Name = "dataGridViewSchoolClasses";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewSchoolClasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewSchoolClasses.RowTemplate.Height = 25;
            dataGridViewSchoolClasses.Size = new Size(840, 564);
            dataGridViewSchoolClasses.TabIndex = 0;
            dataGridViewSchoolClasses.CellBeginEdit += DataGridViewSchoolClasses_CellBeginEdit;
            dataGridViewSchoolClasses.CellEnter += DataGridViewSchoolClasses_CellEnter;
            dataGridViewSchoolClasses.Scroll += DataGridViewSchoolClasses_Scroll;
            // 
            // checkedListBoxCourses
            // 
            checkedListBoxCourses.Dock = DockStyle.Fill;
            checkedListBoxCourses.FormattingEnabled = true;
            checkedListBoxCourses.Location = new Point(849, 3);
            checkedListBoxCourses.Name = "checkedListBoxCourses";
            checkedListBoxCourses.Size = new Size(276, 564);
            checkedListBoxCourses.TabIndex = 0;
            checkedListBoxCourses.SelectedIndexChanged += CheckedListBoxCourses_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(chart2);
            tabPage3.Controls.Add(chart1);
            tabPage3.Location = new Point(4, 38);
            tabPage3.Margin = new Padding(10);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(10);
            tabPage3.Size = new Size(1416, 566);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "3 - Gráficos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(742, 282);
            chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart2.Series.Add(series1);
            chart2.Size = new Size(661, 263);
            chart2.TabIndex = 7;
            chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(742, 13);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(661, 263);
            chart1.TabIndex = 6;
            chart1.Text = "chart1";
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.BackgroundImage = Resources.pesquisar;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.CheckedBackColor = Color.Transparent;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(170, 58);
            button7.Name = "button7";
            button7.Size = new Size(125, 50);
            button7.TabIndex = 12;
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.BackgroundImage = Resources.pesquisar_negrito;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.CheckedBackColor = Color.Transparent;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(170, 2);
            button6.Name = "button6";
            button6.Size = new Size(125, 50);
            button6.TabIndex = 11;
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            buttonPrint.Anchor = AnchorStyles.None;
            buttonPrint.BackgroundImage = Resources.botao_imprimir_solido_laser;
            buttonPrint.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPrint.Cursor = Cursors.Hand;
            buttonPrint.FlatAppearance.BorderSize = 0;
            buttonPrint.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonPrint.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonPrint.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonPrint.FlatStyle = FlatStyle.Flat;
            buttonPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrint.Location = new Point(597, 58);
            buttonPrint.Margin = new Padding(0);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(125, 50);
            buttonPrint.TabIndex = 1;
            buttonPrint.TextAlign = ContentAlignment.MiddleRight;
            buttonPrint.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(button4);
            panelBottom.Controls.Add(button9);
            panelBottom.Controls.Add(button6);
            panelBottom.Controls.Add(button7);
            panelBottom.Controls.Add(buttonEdit);
            panelBottom.Controls.Add(buttonRemove);
            panelBottom.Controls.Add(buttonClose);
            panelBottom.Controls.Add(buttonNew);
            panelBottom.Controls.Add(buttonPrint);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(20, 631);
            panelBottom.Margin = new Padding(0);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1424, 110);
            panelBottom.TabIndex = 1;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackgroundImage = Resources.adicionar_estudante_solido;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.CheckedBackColor = Color.Transparent;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1207, 2);
            button4.Name = "button4";
            button4.Size = new Size(125, 50);
            button4.TabIndex = 13;
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += ButtonAddStudents_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.BackgroundImage = Resources.adicionar_disciplina_solido;
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.CheckedBackColor = Color.Transparent;
            button9.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button9.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(925, 2);
            button9.Name = "button9";
            button9.Size = new Size(125, 50);
            button9.TabIndex = 14;
            button9.TextAlign = ContentAlignment.MiddleRight;
            button9.UseVisualStyleBackColor = true;
            button9.Click += ButtonAddCourses_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.None;
            buttonEdit.BackgroundImage = Resources.editar_solido;
            buttonEdit.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonEdit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonEdit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.Location = new Point(597, 2);
            buttonEdit.Margin = new Padding(0);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 50);
            buttonEdit.TabIndex = 5;
            buttonEdit.TextAlign = ContentAlignment.MiddleRight;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += ButtonStudentEdit_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Anchor = AnchorStyles.None;
            buttonRemove.BackgroundImage = Resources.apagar_solido;
            buttonRemove.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRemove.Cursor = Cursors.Hand;
            buttonRemove.FlatAppearance.BorderSize = 0;
            buttonRemove.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonRemove.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRemove.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemove.Location = new Point(469, 2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(125, 50);
            buttonRemove.TabIndex = 4;
            buttonRemove.TextAlign = ContentAlignment.MiddleRight;
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += ButtonStudentRemove_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.None;
            buttonClose.BackgroundImage = Resources.sair_seta_solida;
            buttonClose.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.Location = new Point(725, 58);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(125, 50);
            buttonClose.TabIndex = 3;
            buttonClose.TextAlign = ContentAlignment.MiddleRight;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += ButtonExit_Click;
            // 
            // buttonNew
            // 
            buttonNew.Anchor = AnchorStyles.None;
            buttonNew.BackgroundImage = Resources.novo_solido;
            buttonNew.BackgroundImageLayout = ImageLayout.Zoom;
            buttonNew.Cursor = Cursors.Hand;
            buttonNew.FlatAppearance.BorderSize = 0;
            buttonNew.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonNew.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonNew.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonNew.FlatStyle = FlatStyle.Flat;
            buttonNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNew.Location = new Point(725, 2);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(125, 50);
            buttonNew.TabIndex = 2;
            buttonNew.TextAlign = ContentAlignment.MiddleRight;
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += ButtonNew_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.RestoreDirectory = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // transparentTabControl1
            // 
            transparentTabControl1.Controls.Add(tabPage1);
            transparentTabControl1.Controls.Add(tabPage2);
            transparentTabControl1.Controls.Add(tabPage3);
            transparentTabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            transparentTabControl1.Location = new Point(20, 20);
            transparentTabControl1.MaximumSize = new Size(1424, 630);
            transparentTabControl1.Multiline = true;
            transparentTabControl1.Name = "transparentTabControl1";
            transparentTabControl1.Padding = new Point(15, 10);
            transparentTabControl1.SelectedIndex = 0;
            transparentTabControl1.Size = new Size(1424, 608);
            transparentTabControl1.TabIndex = 0;
            // 
            // SchoolClassAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1464, 761);
            Controls.Add(panelBottom);
            Controls.Add(transparentTabControl1);
            KeyPreview = true;
            Name = "SchoolClassAdd";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulário Adicionar Turmas";
            Load += WinFormStudentAdd_Load;
            KeyDown += WinForm_KeyDown;
            tableLayoutPanelStudentData.ResumeLayout(false);
            tableLayoutPanelStudentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSchoolClassID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalNumberEnrolledStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWorkingHours).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchoolClasses).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panelBottom.ResumeLayout(false);
            transparentTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelSchoolClassID;
        private Label labelSchoolClassName;
        private Label labelStudentLastName;
        private TextBox textBoxSchoolClassAcronym;
        private TextBox textBoxSchoolClassName;
        private TableLayoutPanel tableLayoutPanelStudentData;
        private NumericUpDown numericUpDownSchoolClassID;
        private CheckedListBox checkedListBoxStudents;
        private Label labelTotalNumberEnrolledStudents;
        private NumericUpDown numericUpDownTotalNumberEnrolledStudents;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerBeginCourse;
        private DateTimePicker dateTimePickerEndCourse;
        private DateTimePicker dateTimePickerEndHour;
        private DateTimePicker dateTimePickerBeginHour;
        private Label label3;
        private Label label4;
        private TransparentTabControl transparentTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private CheckedListBox checkedListBoxCourses;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private NumericUpDown numericUpDownWorkingHours;
        private Label label5;
        private Button buttonPrint;
        private Panel panelBottom;
        private Button buttonEdit;
        private Button buttonRemove;
        private Button buttonClose;
        private Button buttonNew;
        private DataGridView dataGridViewSchoolClasses;
        private PictureBox pictureBox1;
        private Button buttonAddPhoto;
        private Button buttonClear;
        private OpenFileDialog openFileDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonStore;
        private Button button7;
        private Button button6;
        private Button button4;
        private Button button9;
        private NumericUpDown numericUpDownTotalCourses;
        private Label label6;
    }
}