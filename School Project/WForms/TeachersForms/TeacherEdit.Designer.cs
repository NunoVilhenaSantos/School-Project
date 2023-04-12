namespace School_Project.WForms.TeachersForms
{
    partial class TeacherEdit
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
            buttonStore = new Button();
            buttonClear = new Button();
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
            pictureBoxPhotoDisplay = new PictureBox();
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
            groupBox1 = new GroupBox();
            tableLayoutPanelStudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalWorkLoad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStudentID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhotoDisplay).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            buttonStore.Location = new Point(589, 430);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new Size(125, 50);
            buttonStore.TabIndex = 4;
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
            buttonClear.Location = new Point(717, 430);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(125, 50);
            buttonClear.TabIndex = 5;
            buttonClear.TextAlign = ContentAlignment.MiddleRight;
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ButtonCancel_Click;
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
            tableLayoutPanelStudentData.Location = new Point(12, 22);
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
            tableLayoutPanelStudentData.TabIndex = 3;
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
            textBoxPostalCode.KeyUp += TextBox_KeyUp;
            // 
            // textBoxCity
            // 
            textBoxCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCity.Location = new Point(110, 302);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.PlaceholderText = "Cidade";
            textBoxCity.Size = new Size(172, 23);
            textBoxCity.TabIndex = 13;
            textBoxCity.KeyUp += TextBox_KeyUp;
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
            numericUpDownTotalWorkLoad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
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
            labelIDNumber.Text = "ID de\r\nProfessor:";
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
            labelName.Text = "Nome do Professor:";
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
            labelLastName.Text = "Apelido do Professor:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelStudentData.SetColumnSpan(textBoxLastName, 3);
            textBoxLastName.Location = new Point(110, 131);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Apelido do Professor";
            textBoxLastName.Size = new Size(457, 23);
            textBoxLastName.TabIndex = 7;
            textBoxLastName.KeyUp += TextBox_KeyUp;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelStudentData.SetColumnSpan(textBoxName, 3);
            textBoxName.Location = new Point(110, 74);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Nome do Professor";
            textBoxName.Size = new Size(457, 23);
            textBoxName.TabIndex = 5;
            textBoxName.KeyUp += TextBox_KeyUp;
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
            textBoxNationality.PlaceholderText = "Nacionalidade do Professor";
            textBoxNationality.Size = new Size(208, 23);
            textBoxNationality.TabIndex = 31;
            textBoxNationality.KeyUp += TextBox_KeyUp;
            // 
            // textBoxBirthPlace
            // 
            textBoxBirthPlace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxBirthPlace.Location = new Point(680, 359);
            textBoxBirthPlace.Name = "textBoxBirthPlace";
            textBoxBirthPlace.PlaceholderText = "Naturalidade do Professor:";
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
            labelAddress.Text = "Morada do Professor:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelStudentData.SetColumnSpan(textBoxAddress, 3);
            textBoxAddress.Location = new Point(110, 188);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = "Morada do Professor";
            textBoxAddress.Size = new Size(457, 23);
            textBoxAddress.TabIndex = 9;
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
            labelEmail.Text = "Email do Professor:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelStudentData.SetColumnSpan(textBoxEmail, 3);
            textBoxEmail.Location = new Point(110, 245);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email do Professor";
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
            textBoxPhone.PlaceholderText = "Telefone do Professor";
            textBoxPhone.Size = new Size(208, 23);
            textBoxPhone.TabIndex = 29;
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
            labelPhone.Text = "Telefone do Professor:";
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
            labelGenre.Text = "Género do Professor:";
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
            labelNIF.Text = "NIF do Professor:";
            // 
            // textBoxNIF
            // 
            textBoxNIF.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxNIF.Location = new Point(680, 131);
            textBoxNIF.MaxLength = 9;
            textBoxNIF.Name = "textBoxNIF";
            textBoxNIF.PlaceholderText = "NIF do Professor";
            textBoxNIF.Size = new Size(208, 23);
            textBoxNIF.TabIndex = 25;
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
            textBoxCC.PlaceholderText = "Cartão Cidadão Professor";
            textBoxCC.Size = new Size(172, 23);
            textBoxCC.TabIndex = 15;
            textBoxCC.KeyUp += TextBox_KeyUp;
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
            labelCC.Text = "Cartão Cidadão Professor:";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanelStudentData);
            groupBox1.Controls.Add(buttonStore);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1121, 489);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // TeacherEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 155, 104);
            ClientSize = new Size(1153, 523);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "TeacherEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulário Editar Professor";
            Load += WinForm_Load;
            KeyDown += WinForm_KeyDown;
            tableLayoutPanelStudentData.ResumeLayout(false);
            tableLayoutPanelStudentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalWorkLoad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStudentID).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhotoDisplay).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStore;
        private Button buttonClear;
        private TableLayoutPanel tableLayoutPanelStudentData;
        private TextBox textBoxPostalCode;
        private TextBox textBoxCity;
        private Label label1;
        private CheckBox checkBoxActive;
        private NumericUpDown numericUpDownTotalWorkLoad;
        private Label labelIDNumber;
        private Label labelTotalWorkLoad;
        private NumericUpDown numericUpDownStudentID;
        private Label labelName;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private TextBox textBoxName;
        private PictureBox pictureBoxPhotoDisplay;
        private Button buttonAddPhoto;
        private Label labelActiveOrNot;
        private TextBox textBoxNationality;
        private TextBox textBoxBirthPlace;
        private Label labelBirthPlace;
        private Label labelNationality;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private Label labelPhone;
        private ComboBox comboBoxGenre;
        private Label labelGenre;
        private Label labelBirthDate;
        private DateTimePicker dateTimePickerBirthDate;
        private Label labelNIF;
        private TextBox textBoxNIF;
        private DateTimePicker dateTimePickerCCValidDate;
        private Label labelCCValidDate;
        private TextBox textBoxCC;
        private Label labelCC;
        private Label label2;
        private GroupBox groupBox1;
    }
}