namespace School_Project.WForms.StudentsForms
{
    partial class StudentEdit
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
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxAddStudent = new GroupBox();
            tableLayoutPanelStudentData = new TableLayoutPanel();
            labelTotalWorkLoad = new Label();
            labelStudentID = new Label();
            textBoxStudentAddress = new TextBox();
            labelStudentName = new Label();
            textBoxStudentPhone = new TextBox();
            labelStudentLastName = new Label();
            textBoxStudentLastName = new TextBox();
            labelStudentPhone = new Label();
            textBoxStudentName = new TextBox();
            labelStudentAddress = new Label();
            numericUpDownStudentID = new NumericUpDown();
            numericUpDownTotalWorkLoad = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBoxAddStudent.SuspendLayout();
            tableLayoutPanelStudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStudentID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalWorkLoad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(chart1, 2, 0);
            tableLayoutPanel1.Controls.Add(groupBoxAddStudent, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1384, 561);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // chart1
            // 
            chart1.BackColor = Color.Transparent;
            chart1.BorderlineColor = Color.Transparent;
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Top;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(921, 13);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.EmptyPointStyle.CustomProperties = "LabelStyle=Bottom";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(450, 353);
            chart1.TabIndex = 13;
            chart1.Text = "chart1";
            // 
            // groupBoxAddStudent
            // 
            groupBoxAddStudent.Controls.Add(tableLayoutPanelStudentData);
            groupBoxAddStudent.Controls.Add(buttonSave);
            groupBoxAddStudent.Controls.Add(buttonCancel);
            groupBoxAddStudent.Location = new Point(13, 13);
            groupBoxAddStudent.Name = "groupBoxAddStudent";
            groupBoxAddStudent.Size = new Size(448, 430);
            groupBoxAddStudent.TabIndex = 6;
            groupBoxAddStudent.TabStop = false;
            groupBoxAddStudent.Text = "Adicionar Estudante";
            // 
            // tableLayoutPanelStudentData
            // 
            tableLayoutPanelStudentData.ColumnCount = 2;
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelStudentData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelStudentData.Controls.Add(labelTotalWorkLoad, 0, 5);
            tableLayoutPanelStudentData.Controls.Add(labelStudentID, 0, 0);
            tableLayoutPanelStudentData.Controls.Add(textBoxStudentAddress, 1, 4);
            tableLayoutPanelStudentData.Controls.Add(labelStudentName, 0, 1);
            tableLayoutPanelStudentData.Controls.Add(textBoxStudentPhone, 1, 3);
            tableLayoutPanelStudentData.Controls.Add(labelStudentLastName, 0, 2);
            tableLayoutPanelStudentData.Controls.Add(textBoxStudentLastName, 1, 2);
            tableLayoutPanelStudentData.Controls.Add(labelStudentPhone, 0, 3);
            tableLayoutPanelStudentData.Controls.Add(textBoxStudentName, 1, 1);
            tableLayoutPanelStudentData.Controls.Add(labelStudentAddress, 0, 4);
            tableLayoutPanelStudentData.Controls.Add(numericUpDownStudentID, 1, 0);
            tableLayoutPanelStudentData.Controls.Add(numericUpDownTotalWorkLoad, 1, 5);
            tableLayoutPanelStudentData.Location = new Point(6, 22);
            tableLayoutPanelStudentData.Name = "tableLayoutPanelStudentData";
            tableLayoutPanelStudentData.RowCount = 6;
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelStudentData.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelStudentData.Size = new Size(474, 346);
            tableLayoutPanelStudentData.TabIndex = 0;
            // 
            // labelTotalWorkLoad
            // 
            labelTotalWorkLoad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelTotalWorkLoad.AutoSize = true;
            labelTotalWorkLoad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalWorkLoad.Location = new Point(3, 295);
            labelTotalWorkLoad.Name = "labelTotalWorkLoad";
            labelTotalWorkLoad.Size = new Size(136, 40);
            labelTotalWorkLoad.TabIndex = 12;
            labelTotalWorkLoad.Text = "Carga Horária do Alunos:";
            // 
            // labelStudentID
            // 
            labelStudentID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentID.Location = new Point(3, 18);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(136, 20);
            labelStudentID.TabIndex = 0;
            labelStudentID.Text = "ID de Estudante:";
            // 
            // textBoxStudentAddress
            // 
            textBoxStudentAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxStudentAddress.Location = new Point(145, 245);
            textBoxStudentAddress.Name = "textBoxStudentAddress";
            textBoxStudentAddress.Size = new Size(326, 23);
            textBoxStudentAddress.TabIndex = 9;
            // 
            // labelStudentName
            // 
            labelStudentName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelStudentName.AutoSize = true;
            labelStudentName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentName.Location = new Point(3, 65);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new Size(136, 40);
            labelStudentName.TabIndex = 1;
            labelStudentName.Text = "Nome do Estudante:";
            // 
            // textBoxStudentPhone
            // 
            textBoxStudentPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxStudentPhone.Location = new Point(145, 188);
            textBoxStudentPhone.Name = "textBoxStudentPhone";
            textBoxStudentPhone.Size = new Size(326, 23);
            textBoxStudentPhone.TabIndex = 8;
            // 
            // labelStudentLastName
            // 
            labelStudentLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelStudentLastName.AutoSize = true;
            labelStudentLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentLastName.Location = new Point(3, 122);
            labelStudentLastName.Name = "labelStudentLastName";
            labelStudentLastName.Size = new Size(136, 40);
            labelStudentLastName.TabIndex = 2;
            labelStudentLastName.Text = "Apelido do Estudante:";
            // 
            // textBoxStudentLastName
            // 
            textBoxStudentLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxStudentLastName.Location = new Point(145, 131);
            textBoxStudentLastName.Name = "textBoxStudentLastName";
            textBoxStudentLastName.Size = new Size(326, 23);
            textBoxStudentLastName.TabIndex = 7;
            // 
            // labelStudentPhone
            // 
            labelStudentPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelStudentPhone.AutoSize = true;
            labelStudentPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentPhone.Location = new Point(3, 179);
            labelStudentPhone.Name = "labelStudentPhone";
            labelStudentPhone.Size = new Size(136, 40);
            labelStudentPhone.TabIndex = 3;
            labelStudentPhone.Text = "Telefone do Estudante:";
            // 
            // textBoxStudentName
            // 
            textBoxStudentName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxStudentName.Location = new Point(145, 74);
            textBoxStudentName.Name = "textBoxStudentName";
            textBoxStudentName.Size = new Size(326, 23);
            textBoxStudentName.TabIndex = 6;
            // 
            // labelStudentAddress
            // 
            labelStudentAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelStudentAddress.AutoSize = true;
            labelStudentAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentAddress.Location = new Point(3, 236);
            labelStudentAddress.Name = "labelStudentAddress";
            labelStudentAddress.Size = new Size(136, 40);
            labelStudentAddress.TabIndex = 4;
            labelStudentAddress.Text = "Morada do Estudante:";
            // 
            // numericUpDownStudentID
            // 
            numericUpDownStudentID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownStudentID.Enabled = false;
            numericUpDownStudentID.Location = new Point(145, 17);
            numericUpDownStudentID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownStudentID.Name = "numericUpDownStudentID";
            numericUpDownStudentID.Size = new Size(326, 23);
            numericUpDownStudentID.TabIndex = 11;
            numericUpDownStudentID.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownTotalWorkLoad
            // 
            numericUpDownTotalWorkLoad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownTotalWorkLoad.Enabled = false;
            numericUpDownTotalWorkLoad.Location = new Point(145, 304);
            numericUpDownTotalWorkLoad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownTotalWorkLoad.Name = "numericUpDownTotalWorkLoad";
            numericUpDownTotalWorkLoad.Size = new Size(326, 23);
            numericUpDownTotalWorkLoad.TabIndex = 13;
            numericUpDownTotalWorkLoad.TextAlign = HorizontalAlignment.Right;
            numericUpDownTotalWorkLoad.ThousandsSeparator = true;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSave.AutoSize = true;
            buttonSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.Location = new Point(223, 558);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(406, 31);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.AutoSize = true;
            buttonCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.Location = new Point(349, 558);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(406, 31);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Limpar Dados";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.PeachPuff;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(467, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(448, 535);
            dataGridView1.TabIndex = 8;
            // 
            // StudentEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 155, 104);
            ClientSize = new Size(1384, 561);
            Controls.Add(tableLayoutPanel1);
            KeyPreview = true;
            Name = "StudentEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulário Editar Estudante";
            Load += WinForm_Load;
            KeyDown += WinForm_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBoxAddStudent.ResumeLayout(false);
            groupBoxAddStudent.PerformLayout();
            tableLayoutPanelStudentData.ResumeLayout(false);
            tableLayoutPanelStudentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStudentID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalWorkLoad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxAddStudent;
        private TableLayoutPanel tableLayoutPanelStudentData;
        private Label labelTotalWorkLoad;
        private Label labelStudentID;
        private TextBox textBoxStudentAddress;
        private Label labelStudentName;
        private TextBox textBoxStudentPhone;
        private Label labelStudentLastName;
        private TextBox textBoxStudentLastName;
        private Label labelStudentPhone;
        private TextBox textBoxStudentName;
        private Label labelStudentAddress;
        private NumericUpDown numericUpDownStudentID;
        private NumericUpDown numericUpDownTotalWorkLoad;
        private Button buttonSave;
        private Button buttonCancel;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}