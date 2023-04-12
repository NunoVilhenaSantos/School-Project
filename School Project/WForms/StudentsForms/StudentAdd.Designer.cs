using School_Project.ClassFolder;

namespace School_Project.WForms.StudentsForms
{
    partial class StudentAdd
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAdd));
            checkedListBox1 = new CheckedListBox();
            dataGridView1 = new DataGridView();
            pictureBoxPhotoDisplay = new PictureBox();
            buttonSearch = new Button();
            tableLayoutPanelStudentData = new TableLayoutPanel();
            textBoxPostalCode = new TextBox();
            textBoxCity = new TextBox();
            label1 = new Label();
            checkBoxActive = new CheckBox();
            numericUpDownTotalWorkLoad = new NumericUpDown();
            labelIDNumber = new Label();
            labelTotalWorkLoad = new Label();
            numericUpDownStudentID = new NumericUpDown();
            labelName = new Label();
            labelLastName = new Label();
            textBoxLastName = new TextBox();
            textBoxName = new TextBox();
            buttonAddPhoto = new Button();
            labelActiveOrNot = new Label();
            textBoxNationality = new TextBox();
            textBoxBirthPlace = new TextBox();
            labelBirthPlace = new Label();
            labelNationality = new Label();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            labelPhone = new Label();
            comboBoxGenre = new ComboBox();
            labelGenre = new Label();
            labelBirthDate = new Label();
            dateTimePickerBirthDate = new DateTimePicker();
            labelNIF = new Label();
            textBoxNIF = new TextBox();
            dateTimePickerCCValidDate = new DateTimePicker();
            labelCCValidDate = new Label();
            textBoxCC = new TextBox();
            labelCC = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelBottom = new Panel();
            buttonSearchForm = new Button();
            comboBoxSearchList = new ComboBox();
            comboBoxSearchOptions = new ComboBox();
            buttonEdit = new Button();
            buttonRemove = new Button();
            buttonExit = new Button();
            buttonNew = new Button();
            buttonPrint = new Button();
            buttonAddCourses = new Button();
            panelTop = new Panel();
            transparentTabControl1 = new TransparentTabControl();
            tabPage1 = new TabPage();
            buttonStore = new Button();
            buttonClear = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            dataGridViewSearch = new DataGridView();
            tabPage4 = new TabPage();
            printPreviewDialog1 = new PrintPreviewDialog();
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhotoDisplay).BeginInit();
            tableLayoutPanelStudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalWorkLoad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStudentID).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panelBottom.SuspendLayout();
            panelTop.SuspendLayout();
            transparentTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(850, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(277, 493);
            checkedListBox1.TabIndex = 1;
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
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(841, 493);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellBeginEdit += DataGridView_CellBeginEdit;
            dataGridView1.CellEnter += DataGridView_CellEnter;
            dataGridView1.Scroll += DataGridView_Scroll;
            // 
            // pictureBoxPhotoDisplay
            // 
            pictureBoxPhotoDisplay.Dock = DockStyle.Fill;
            pictureBoxPhotoDisplay.Location = new Point(894, 3);
            pictureBoxPhotoDisplay.Name = "pictureBoxPhotoDisplay";
            tableLayoutPanelStudentData.SetRowSpan(pictureBoxPhotoDisplay, 6);
            pictureBoxPhotoDisplay.Size = new Size(197, 336);
            pictureBoxPhotoDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhotoDisplay.TabIndex = 9;
            pictureBoxPhotoDisplay.TabStop = false;
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
            buttonSearch.Location = new Point(12, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(125, 50);
            buttonSearch.TabIndex = 3;
            buttonSearch.TextAlign = ContentAlignment.MiddleRight;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // tableLayoutPanelStudentData
            // 
            tableLayoutPanelStudentData.ColumnCount = 7;
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanelStudentData.Controls.Add(textBoxPostalCode, 3, 5);
            tableLayoutPanelStudentData.Controls.Add(textBoxCity, 1, 5);
            tableLayoutPanelStudentData.Controls.Add(label1, 0, 5);
            tableLayoutPanelStudentData.Controls.Add(checkBoxActive, 5, 0);
            tableLayoutPanelStudentData.Controls.Add(numericUpDownTotalWorkLoad, 3, 0);
            tableLayoutPanelStudentData.Controls.Add(labelIDNumber, 0, 0);
            tableLayoutPanelStudentData.Controls.Add(labelTotalWorkLoad, 2, 0);
            tableLayoutPanelStudentData.Controls.Add(numericUpDownStudentID, 1, 0);
            tableLayoutPanelStudentData.Controls.Add(labelName, 0, 1);
            tableLayoutPanelStudentData.Controls.Add(labelLastName, 0, 2);
            tableLayoutPanelStudentData.Controls.Add(textBoxLastName, 1, 2);
            tableLayoutPanelStudentData.Controls.Add(textBoxName, 1, 1);
            tableLayoutPanelStudentData.Controls.Add(pictureBoxPhotoDisplay, 6, 0);
            tableLayoutPanelStudentData.Controls.Add(buttonAddPhoto, 6, 6);
            tableLayoutPanelStudentData.Controls.Add(labelActiveOrNot, 4, 0);
            tableLayoutPanelStudentData.Controls.Add(textBoxNationality, 5, 5);
            tableLayoutPanelStudentData.Controls.Add(textBoxBirthPlace, 5, 6);
            tableLayoutPanelStudentData.Controls.Add(labelBirthPlace, 4, 6);
            tableLayoutPanelStudentData.Controls.Add(labelNationality, 4, 5);
            tableLayoutPanelStudentData.Controls.Add(labelAddress, 0, 3);
            tableLayoutPanelStudentData.Controls.Add(textBoxAddress, 1, 3);
            tableLayoutPanelStudentData.Controls.Add(labelEmail, 0, 4);
            tableLayoutPanelStudentData.Controls.Add(textBoxEmail, 1, 4);
            tableLayoutPanelStudentData.Controls.Add(textBoxPhone, 5, 4);
            tableLayoutPanelStudentData.Controls.Add(labelPhone, 4, 4);
            tableLayoutPanelStudentData.Controls.Add(comboBoxGenre, 5, 3);
            tableLayoutPanelStudentData.Controls.Add(labelGenre, 4, 3);
            tableLayoutPanelStudentData.Controls.Add(labelBirthDate, 4, 1);
            tableLayoutPanelStudentData.Controls.Add(dateTimePickerBirthDate, 5, 1);
            tableLayoutPanelStudentData.Controls.Add(labelNIF, 4, 2);
            tableLayoutPanelStudentData.Controls.Add(textBoxNIF, 5, 2);
            tableLayoutPanelStudentData.Controls.Add(dateTimePickerCCValidDate, 3, 6);
            tableLayoutPanelStudentData.Controls.Add(labelCCValidDate, 2, 6);
            tableLayoutPanelStudentData.Controls.Add(textBoxCC, 1, 6);
            tableLayoutPanelStudentData.Controls.Add(labelCC, 0, 6);
            tableLayoutPanelStudentData.Controls.Add(label2, 2, 5);
            tableLayoutPanelStudentData.Location = new Point(18, 18);
            tableLayoutPanelStudentData.Name = "tableLayoutPanelStudentData";
            tableLayoutPanelStudentData.RowCount = 7;
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelStudentData.Size = new Size(1094, 400);
            tableLayoutPanelStudentData.TabIndex = 0;
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPostalCode.Location = new Point(395, 302);
            textBoxPostalCode.MaxLength = 7;
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.PlaceholderText = "Código Postal";
            textBoxPostalCode.Size = new Size(172, 23);
            textBoxPostalCode.TabIndex = 17;
            // 
            // textBoxCity
            // 
            textBoxCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCity.Location = new Point(110, 302);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.PlaceholderText = "Cidade";
            textBoxCity.Size = new Size(172, 23);
            textBoxCity.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 305);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 12;
            label1.Text = "Cidade:";
            // 
            // checkBoxActive
            // 
            checkBoxActive.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            checkBoxActive.AutoSize = true;
            checkBoxActive.Location = new Point(680, 19);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(208, 19);
            checkBoxActive.TabIndex = 21;
            checkBoxActive.Text = "Ativo ou Inativo";
            checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTotalWorkLoad
            // 
            numericUpDownTotalWorkLoad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownTotalWorkLoad.Enabled = false;
            numericUpDownTotalWorkLoad.Location = new Point(395, 17);
            numericUpDownTotalWorkLoad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownTotalWorkLoad.Name = "numericUpDownTotalWorkLoad";
            numericUpDownTotalWorkLoad.Size = new Size(172, 23);
            numericUpDownTotalWorkLoad.TabIndex = 3;
            numericUpDownTotalWorkLoad.TextAlign = HorizontalAlignment.Right;
            numericUpDownTotalWorkLoad.ThousandsSeparator = true;
            // 
            // labelIDNumber
            // 
            labelIDNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelIDNumber.AutoSize = true;
            labelIDNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelIDNumber.Location = new Point(3, 11);
            labelIDNumber.Name = "labelIDNumber";
            labelIDNumber.Size = new Size(101, 34);
            labelIDNumber.TabIndex = 0;
            labelIDNumber.Text = "ID de\r\nEstudante:";
            // 
            // labelTotalWorkLoad
            // 
            labelTotalWorkLoad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelTotalWorkLoad.AutoSize = true;
            labelTotalWorkLoad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalWorkLoad.Location = new Point(288, 11);
            labelTotalWorkLoad.Name = "labelTotalWorkLoad";
            labelTotalWorkLoad.Size = new Size(101, 34);
            labelTotalWorkLoad.TabIndex = 2;
            labelTotalWorkLoad.Text = "Carga Horária\r\n Aluno:";
            // 
            // numericUpDownStudentID
            // 
            numericUpDownStudentID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownStudentID.Enabled = false;
            numericUpDownStudentID.Location = new Point(110, 17);
            numericUpDownStudentID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownStudentID.Name = "numericUpDownStudentID";
            numericUpDownStudentID.Size = new Size(172, 23);
            numericUpDownStudentID.TabIndex = 1;
            numericUpDownStudentID.TextAlign = HorizontalAlignment.Right;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(3, 68);
            labelName.Name = "labelName";
            labelName.Size = new Size(101, 34);
            labelName.TabIndex = 4;
            labelName.Text = "Nome do Estudante:";
            // 
            // labelLastName
            // 
            labelLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLastName.Location = new Point(3, 125);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(101, 34);
            labelLastName.TabIndex = 6;
            labelLastName.Text = "Apelido do Estudante:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelStudentData.SetColumnSpan(textBoxLastName, 3);
            textBoxLastName.Location = new Point(110, 131);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Apelido do Estudante";
            textBoxLastName.Size = new Size(457, 23);
            textBoxLastName.TabIndex = 7;
            textBoxLastName.KeyPress += TextBoxNames_KeyPress;
            textBoxLastName.KeyUp += TextBox_KeyUp;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelStudentData.SetColumnSpan(textBoxName, 3);
            textBoxName.Location = new Point(110, 74);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Nome do Estudante";
            textBoxName.Size = new Size(457, 23);
            textBoxName.TabIndex = 5;
            textBoxName.KeyPress += TextBoxNames_KeyPress;
            textBoxName.KeyUp += TextBox_KeyUp;
            // 
            // buttonAddPhoto
            // 
            buttonAddPhoto.Anchor = AnchorStyles.None;
            buttonAddPhoto.BackgroundImage = Properties.Resources.importar_foto;
            buttonAddPhoto.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAddPhoto.Cursor = Cursors.Hand;
            buttonAddPhoto.FlatAppearance.BorderSize = 0;
            buttonAddPhoto.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonAddPhoto.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAddPhoto.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAddPhoto.FlatStyle = FlatStyle.Flat;
            buttonAddPhoto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddPhoto.Location = new Point(930, 346);
            buttonAddPhoto.Margin = new Padding(0);
            buttonAddPhoto.Name = "buttonAddPhoto";
            buttonAddPhoto.Size = new Size(125, 50);
            buttonAddPhoto.TabIndex = 34;
            buttonAddPhoto.TextAlign = ContentAlignment.MiddleRight;
            buttonAddPhoto.UseVisualStyleBackColor = true;
            buttonAddPhoto.Click += ButtonAddPhoto_Click;
            // 
            // labelActiveOrNot
            // 
            labelActiveOrNot.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelActiveOrNot.AutoSize = true;
            labelActiveOrNot.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelActiveOrNot.Location = new Point(573, 20);
            labelActiveOrNot.Name = "labelActiveOrNot";
            labelActiveOrNot.Size = new Size(101, 17);
            labelActiveOrNot.TabIndex = 20;
            labelActiveOrNot.Text = "Ativo:";
            // 
            // textBoxNationality
            // 
            textBoxNationality.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxNationality.Location = new Point(680, 302);
            textBoxNationality.Name = "textBoxNationality";
            textBoxNationality.PlaceholderText = "Nacionalidade do Estudante";
            textBoxNationality.Size = new Size(208, 23);
            textBoxNationality.TabIndex = 31;
            textBoxNationality.KeyUp += TextBox_KeyUp;
            // 
            // textBoxBirthPlace
            // 
            textBoxBirthPlace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxBirthPlace.Location = new Point(680, 359);
            textBoxBirthPlace.Name = "textBoxBirthPlace";
            textBoxBirthPlace.PlaceholderText = "Naturalidade do Estudante:";
            textBoxBirthPlace.Size = new Size(208, 23);
            textBoxBirthPlace.TabIndex = 33;
            textBoxBirthPlace.KeyUp += TextBox_KeyUp;
            // 
            // labelBirthPlace
            // 
            labelBirthPlace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelBirthPlace.AutoSize = true;
            labelBirthPlace.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirthPlace.Location = new Point(573, 362);
            labelBirthPlace.Name = "labelBirthPlace";
            labelBirthPlace.Size = new Size(101, 17);
            labelBirthPlace.TabIndex = 32;
            labelBirthPlace.Text = "Naturalidade:";
            // 
            // labelNationality
            // 
            labelNationality.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelNationality.AutoSize = true;
            labelNationality.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNationality.Location = new Point(573, 305);
            labelNationality.Name = "labelNationality";
            labelNationality.Size = new Size(101, 17);
            labelNationality.TabIndex = 30;
            labelNationality.Text = "Nacionalidade";
            // 
            // labelAddress
            // 
            labelAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddress.Location = new Point(3, 182);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(101, 34);
            labelAddress.TabIndex = 8;
            labelAddress.Text = "Morada do Estudante:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelStudentData.SetColumnSpan(textBoxAddress, 3);
            textBoxAddress.Location = new Point(110, 188);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = "Morada do Estudante";
            textBoxAddress.Size = new Size(457, 23);
            textBoxAddress.TabIndex = 9;
            textBoxAddress.KeyPress += TextBoxNames_KeyPress;
            textBoxAddress.KeyUp += TextBox_KeyUp;
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(3, 239);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(101, 34);
            labelEmail.TabIndex = 10;
            labelEmail.Text = "Email do Estudante:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelStudentData.SetColumnSpan(textBoxEmail, 3);
            textBoxEmail.Location = new Point(110, 245);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email do Estudante";
            textBoxEmail.Size = new Size(457, 23);
            textBoxEmail.TabIndex = 11;
            textBoxEmail.KeyUp += TextBox_KeyUp;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPhone.Location = new Point(680, 245);
            textBoxPhone.MaxLength = 9;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.PlaceholderText = "Telefone do Estudante";
            textBoxPhone.Size = new Size(208, 23);
            textBoxPhone.TabIndex = 29;
            textBoxPhone.KeyPress += TextBoxStudentPhone_KeyPress;
            textBoxPhone.KeyUp += TextBox_KeyUp;
            // 
            // labelPhone
            // 
            labelPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhone.Location = new Point(573, 239);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(101, 34);
            labelPhone.TabIndex = 28;
            labelPhone.Text = "Telefone do Estudante:";
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(680, 188);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(208, 23);
            comboBoxGenre.TabIndex = 27;
            // 
            // labelGenre
            // 
            labelGenre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelGenre.AutoSize = true;
            labelGenre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelGenre.Location = new Point(573, 182);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(101, 34);
            labelGenre.TabIndex = 26;
            labelGenre.Text = "Género do Estudante:";
            // 
            // labelBirthDate
            // 
            labelBirthDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelBirthDate.AutoSize = true;
            labelBirthDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirthDate.Location = new Point(573, 68);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(101, 34);
            labelBirthDate.TabIndex = 22;
            labelBirthDate.Text = "Data Nascimento";
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerBirthDate.Location = new Point(680, 74);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(208, 23);
            dateTimePickerBirthDate.TabIndex = 23;
            // 
            // labelNIF
            // 
            labelNIF.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelNIF.AutoSize = true;
            labelNIF.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNIF.Location = new Point(573, 125);
            labelNIF.Name = "labelNIF";
            labelNIF.Size = new Size(101, 34);
            labelNIF.TabIndex = 24;
            labelNIF.Text = "NIF do Estudante:";
            // 
            // textBoxNIF
            // 
            textBoxNIF.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxNIF.Location = new Point(680, 131);
            textBoxNIF.MaxLength = 9;
            textBoxNIF.Name = "textBoxNIF";
            textBoxNIF.PlaceholderText = "NIF do Estudante";
            textBoxNIF.Size = new Size(208, 23);
            textBoxNIF.TabIndex = 25;
            textBoxNIF.KeyPress += TextBoxStudentPhone_KeyPress;
            textBoxNIF.KeyUp += TextBox_KeyUp;
            // 
            // dateTimePickerCCValidDate
            // 
            dateTimePickerCCValidDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerCCValidDate.Location = new Point(395, 359);
            dateTimePickerCCValidDate.Name = "dateTimePickerCCValidDate";
            dateTimePickerCCValidDate.Size = new Size(172, 23);
            dateTimePickerCCValidDate.TabIndex = 19;
            // 
            // labelCCValidDate
            // 
            labelCCValidDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelCCValidDate.AutoSize = true;
            labelCCValidDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCCValidDate.Location = new Point(288, 354);
            labelCCValidDate.Name = "labelCCValidDate";
            labelCCValidDate.Size = new Size(101, 34);
            labelCCValidDate.TabIndex = 18;
            labelCCValidDate.Text = "Data Validade CC:";
            // 
            // textBoxCC
            // 
            textBoxCC.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCC.CharacterCasing = CharacterCasing.Upper;
            textBoxCC.Location = new Point(110, 359);
            textBoxCC.MaxLength = 12;
            textBoxCC.Name = "textBoxCC";
            textBoxCC.PlaceholderText = "Cartão Cidadão Estudante";
            textBoxCC.Size = new Size(172, 23);
            textBoxCC.TabIndex = 15;
            // 
            // labelCC
            // 
            labelCC.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelCC.AutoSize = true;
            labelCC.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCC.Location = new Point(3, 345);
            labelCC.Name = "labelCC";
            labelCC.Size = new Size(101, 51);
            labelCC.TabIndex = 14;
            labelCC.Text = "Cartão Cidadão Estudante:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(288, 305);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 16;
            label2.Text = "Código Postal:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Controls.Add(checkedListBox1, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1130, 499);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1130, 505);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonSearchForm);
            panelBottom.Controls.Add(comboBoxSearchList);
            panelBottom.Controls.Add(comboBoxSearchOptions);
            panelBottom.Controls.Add(buttonEdit);
            panelBottom.Controls.Add(buttonRemove);
            panelBottom.Controls.Add(buttonSearch);
            panelBottom.Controls.Add(buttonExit);
            panelBottom.Controls.Add(buttonNew);
            panelBottom.Controls.Add(buttonPrint);
            panelBottom.Controls.Add(buttonAddCourses);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(20, 581);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1144, 110);
            panelBottom.TabIndex = 1;
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
            buttonSearchForm.Location = new Point(473, 58);
            buttonSearchForm.Name = "buttonSearchForm";
            buttonSearchForm.Size = new Size(125, 50);
            buttonSearchForm.TabIndex = 12;
            buttonSearchForm.TextAlign = ContentAlignment.MiddleRight;
            buttonSearchForm.UseVisualStyleBackColor = true;
            buttonSearchForm.Click += ButtonSearchForm_Click;
            // 
            // comboBoxSearchList
            // 
            comboBoxSearchList.FormattingEnabled = true;
            comboBoxSearchList.Location = new Point(28, 72);
            comboBoxSearchList.Name = "comboBoxSearchList";
            comboBoxSearchList.Size = new Size(386, 23);
            comboBoxSearchList.TabIndex = 7;
            // 
            // comboBoxSearchOptions
            // 
            comboBoxSearchOptions.FormattingEnabled = true;
            comboBoxSearchOptions.Location = new Point(135, 16);
            comboBoxSearchOptions.Name = "comboBoxSearchOptions";
            comboBoxSearchOptions.Size = new Size(279, 23);
            comboBoxSearchOptions.TabIndex = 6;
            comboBoxSearchOptions.SelectedIndexChanged += ComboBoxSearchOptions_SelectedIndexChanged;
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
            buttonEdit.Location = new Point(601, 2);
            buttonEdit.Margin = new Padding(0);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 50);
            buttonEdit.TabIndex = 1;
            buttonEdit.TextAlign = ContentAlignment.MiddleRight;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += ButtonStudentEdit_Click;
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
            buttonRemove.Location = new Point(473, 2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(125, 50);
            buttonRemove.TabIndex = 2;
            buttonRemove.TextAlign = ContentAlignment.MiddleRight;
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += ButtonStudentRemove_Click;
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
            buttonExit.Location = new Point(729, 58);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(125, 50);
            buttonExit.TabIndex = 5;
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
            buttonNew.Location = new Point(729, 2);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(125, 50);
            buttonNew.TabIndex = 0;
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
            buttonPrint.Location = new Point(601, 58);
            buttonPrint.Margin = new Padding(0);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(125, 50);
            buttonPrint.TabIndex = 3;
            buttonPrint.TextAlign = ContentAlignment.MiddleRight;
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += ButtonPrint_Click;
            // 
            // buttonAddCourses
            // 
            buttonAddCourses.Anchor = AnchorStyles.None;
            buttonAddCourses.BackgroundImage = Properties.Resources.adicionar_disciplina_solido;
            buttonAddCourses.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAddCourses.Cursor = Cursors.Hand;
            buttonAddCourses.FlatAppearance.BorderSize = 0;
            buttonAddCourses.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonAddCourses.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAddCourses.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAddCourses.FlatStyle = FlatStyle.Flat;
            buttonAddCourses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddCourses.Location = new Point(926, 2);
            buttonAddCourses.Name = "buttonAddCourses";
            buttonAddCourses.Size = new Size(125, 50);
            buttonAddCourses.TabIndex = 4;
            buttonAddCourses.TextAlign = ContentAlignment.MiddleRight;
            buttonAddCourses.UseVisualStyleBackColor = true;
            buttonAddCourses.Click += ButtonAddEnrollments_Click;
            // 
            // panelTop
            // 
            panelTop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTop.Controls.Add(transparentTabControl1);
            panelTop.Location = new Point(20, 22);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1144, 553);
            panelTop.TabIndex = 0;
            // 
            // transparentTabControl1
            // 
            transparentTabControl1.Controls.Add(tabPage1);
            transparentTabControl1.Controls.Add(tabPage2);
            transparentTabControl1.Controls.Add(tabPage3);
            transparentTabControl1.Controls.Add(tabPage4);
            transparentTabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            transparentTabControl1.Location = new Point(3, 3);
            transparentTabControl1.MaximumSize = new Size(1424, 630);
            transparentTabControl1.Multiline = true;
            transparentTabControl1.Name = "transparentTabControl1";
            transparentTabControl1.Padding = new Point(15, 10);
            transparentTabControl1.SelectedIndex = 0;
            transparentTabControl1.Size = new Size(1138, 547);
            transparentTabControl1.TabIndex = 0;
            transparentTabControl1.SelectedIndexChanged += TransparentTabControl1_SelectedIndexChanged;
            transparentTabControl1.TabIndexChanged += TransparentTabControl1_TabIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonStore);
            tabPage1.Controls.Add(buttonClear);
            tabPage1.Controls.Add(tableLayoutPanelStudentData);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(15);
            tabPage1.Size = new Size(1130, 505);
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
            buttonStore.Location = new Point(594, 437);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new Size(125, 50);
            buttonStore.TabIndex = 1;
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
            buttonClear.Location = new Point(722, 437);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(125, 50);
            buttonClear.TabIndex = 2;
            buttonClear.TextAlign = ContentAlignment.MiddleRight;
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ButtonCancel_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 38);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(15);
            tabPage2.Size = new Size(1130, 505);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "2 - Lista";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridViewSearch);
            tabPage3.Location = new Point(4, 38);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1130, 505);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "3 - Pesquisa";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewSearch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewSearch.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewSearch.Dock = DockStyle.Fill;
            dataGridViewSearch.Location = new Point(0, 0);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewSearch.RowTemplate.Height = 25;
            dataGridViewSearch.Size = new Size(1130, 505);
            dataGridViewSearch.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(chart1);
            tabPage4.Location = new Point(4, 38);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1130, 505);
            tabPage4.TabIndex = 2;
            tabPage4.Text = "4 - Gráficos";
            tabPage4.UseVisualStyleBackColor = true;
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
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // StudentAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1184, 711);
            Controls.Add(panelTop);
            Controls.Add(panelBottom);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "StudentAdd";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulário Adicionar Estudante";
            Load += WinFormLoading_Load;
            KeyDown += WinFormAdd_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhotoDisplay).EndInit();
            tableLayoutPanelStudentData.ResumeLayout(false);
            tableLayoutPanelStudentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalWorkLoad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStudentID).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panelBottom.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            transparentTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        private CheckedListBox checkedListBox1;
        private DataGridView dataGridView1;
        private TransparentTabControl transparentTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private PictureBox pictureBoxPhotoDisplay;
        private Panel panelBottom;
        private TableLayoutPanel tableLayoutPanelStudentData;
        private Label labelTotalWorkLoad;
        private Label labelIDNumber;
        private TextBox textBoxAddress;
        private Label labelName;
        private TextBox textBoxPhone;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private Label labelPhone;
        private TextBox textBoxName;
        private Label labelAddress;
        private NumericUpDown numericUpDownStudentID;
        private NumericUpDown numericUpDownTotalWorkLoad;
        private Panel panelTop;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonSearch;
        private SplitContainer splitContainer1;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Button buttonAddCourses;
        private Button buttonAddPhoto;
        private Button buttonEdit;
        private Button buttonRemove;
        private Button buttonExit;
        private Button buttonNew;
        private Button buttonPrint;
        private Button buttonStore;
        private Button buttonClear;
        private Label labelCC;
        private Label labelGenre;
        private Label labelActiveOrNot;
        private DateTimePicker dateTimePickerBirthDate;
        private Label labelBirthDate;
        private Label labelCCValidDate;
        private Label labelNIF;
        private Label labelNationality;
        private TextBox textBoxPostalCode;
        private TextBox textBoxCC;
        private TextBox textBoxNationality;
        private DateTimePicker dateTimePickerCCValidDate;
        private TextBox textBoxBirthPlace;
        private TextBox textBoxCity;
        private TextBox textBoxNIF;
        private Label labelBirthPlace;
        private ComboBox comboBoxGenre;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label1;
        private CheckBox checkBoxActive;
        private Label label2;
        private TabPage tabPage3;
        private DataGridView dataGridViewSearch;
        private ComboBox comboBoxSearchOptions;
        private ComboBox comboBoxSearchList;
        private Button buttonSearchForm;
        private NotifyIcon notifyIcon1;
    }
}