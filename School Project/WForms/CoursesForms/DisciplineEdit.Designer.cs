namespace School_Project.WForms.CoursesForms
{
    partial class DisciplineEdit
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
            tableLayoutPanelDisciplineEdit = new TableLayoutPanel();
            label1 = new Label();
            labelDisciplineID = new Label();
            labelDisciplineName = new Label();
            textBoxDisciplineName = new TextBox();
            numericUpDownNumberHours = new NumericUpDown();
            numericUpDownDisciplineID = new NumericUpDown();
            buttonDisciplineSave = new Button();
            buttonDisciplineCancel = new Button();
            tableLayoutPanelDisciplineEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisciplineID).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelDisciplineEdit
            // 
            tableLayoutPanelDisciplineEdit.ColumnCount = 2;
            tableLayoutPanelDisciplineEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelDisciplineEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelDisciplineEdit.Controls.Add(label1, 0, 2);
            tableLayoutPanelDisciplineEdit.Controls.Add(labelDisciplineID, 0, 0);
            tableLayoutPanelDisciplineEdit.Controls.Add(labelDisciplineName, 0, 1);
            tableLayoutPanelDisciplineEdit.Controls.Add(textBoxDisciplineName, 1, 1);
            tableLayoutPanelDisciplineEdit.Controls.Add(numericUpDownNumberHours, 1, 2);
            tableLayoutPanelDisciplineEdit.Controls.Add(numericUpDownDisciplineID, 1, 0);
            tableLayoutPanelDisciplineEdit.Location = new Point(12, 12);
            tableLayoutPanelDisciplineEdit.Name = "tableLayoutPanelDisciplineEdit";
            tableLayoutPanelDisciplineEdit.RowCount = 3;
            tableLayoutPanelDisciplineEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelDisciplineEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelDisciplineEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelDisciplineEdit.Size = new Size(680, 200);
            tableLayoutPanelDisciplineEdit.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 146);
            label1.Name = "label1";
            label1.Size = new Size(198, 40);
            label1.TabIndex = 2;
            label1.Text = "Carga Horária da Disciplina:";
            // 
            // labelDisciplineID
            // 
            labelDisciplineID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelDisciplineID.AutoSize = true;
            labelDisciplineID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDisciplineID.Location = new Point(3, 23);
            labelDisciplineID.Name = "labelDisciplineID";
            labelDisciplineID.Size = new Size(198, 20);
            labelDisciplineID.TabIndex = 0;
            labelDisciplineID.Text = "ID da Disciplina:";
            // 
            // labelDisciplineName
            // 
            labelDisciplineName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelDisciplineName.AutoSize = true;
            labelDisciplineName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDisciplineName.Location = new Point(3, 89);
            labelDisciplineName.Name = "labelDisciplineName";
            labelDisciplineName.Size = new Size(198, 20);
            labelDisciplineName.TabIndex = 1;
            labelDisciplineName.Text = "Nome da Disciplina:";
            // 
            // textBoxDisciplineName
            // 
            textBoxDisciplineName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxDisciplineName.Location = new Point(207, 87);
            textBoxDisciplineName.Name = "textBoxDisciplineName";
            textBoxDisciplineName.Size = new Size(470, 23);
            textBoxDisciplineName.TabIndex = 4;
            textBoxDisciplineName.KeyUp += TextBox_KeyUp;
            // 
            // numericUpDownNumberHours
            // 
            numericUpDownNumberHours.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownNumberHours.Location = new Point(207, 154);
            numericUpDownNumberHours.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDownNumberHours.Name = "numericUpDownNumberHours";
            numericUpDownNumberHours.Size = new Size(470, 23);
            numericUpDownNumberHours.TabIndex = 5;
            numericUpDownNumberHours.TextAlign = HorizontalAlignment.Right;
            numericUpDownNumberHours.ThousandsSeparator = true;
            // 
            // numericUpDownDisciplineID
            // 
            numericUpDownDisciplineID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownDisciplineID.Enabled = false;
            numericUpDownDisciplineID.Location = new Point(207, 21);
            numericUpDownDisciplineID.Name = "numericUpDownDisciplineID";
            numericUpDownDisciplineID.Size = new Size(470, 23);
            numericUpDownDisciplineID.TabIndex = 7;
            numericUpDownDisciplineID.TextAlign = HorizontalAlignment.Right;
            numericUpDownDisciplineID.ThousandsSeparator = true;
            // 
            // buttonDisciplineSave
            // 
            buttonDisciplineSave.AutoSize = true;
            buttonDisciplineSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDisciplineSave.Location = new Point(510, 218);
            buttonDisciplineSave.Name = "buttonDisciplineSave";
            buttonDisciplineSave.Size = new Size(90, 31);
            buttonDisciplineSave.TabIndex = 0;
            buttonDisciplineSave.Text = "Guardar";
            buttonDisciplineSave.UseVisualStyleBackColor = true;
            buttonDisciplineSave.Click += ButtonDisciplineSave_Click;
            // 
            // buttonDisciplineCancel
            // 
            buttonDisciplineCancel.AutoSize = true;
            buttonDisciplineCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDisciplineCancel.Location = new Point(606, 218);
            buttonDisciplineCancel.Name = "buttonDisciplineCancel";
            buttonDisciplineCancel.Size = new Size(86, 31);
            buttonDisciplineCancel.TabIndex = 0;
            buttonDisciplineCancel.Text = "Cancelar";
            buttonDisciplineCancel.UseVisualStyleBackColor = true;
            buttonDisciplineCancel.Click += ButtonDisciplineCancel_Click;
            // 
            // DisciplineEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(703, 259);
            Controls.Add(buttonDisciplineCancel);
            Controls.Add(buttonDisciplineSave);
            Controls.Add(tableLayoutPanelDisciplineEdit);
            KeyPreview = true;
            Name = "DisciplineEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulário Editar Disciplina";
            Load += WinFormDisciplineEdit_Load;
            KeyDown += WinForm_KeyDown;
            tableLayoutPanelDisciplineEdit.ResumeLayout(false);
            tableLayoutPanelDisciplineEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisciplineID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelDisciplineEdit;
        private Label label1;
        private Label labelDisciplineID;
        private Label labelDisciplineName;
        private TextBox textBoxDisciplineName;
        private Button buttonDisciplineSave;
        private Button buttonDisciplineCancel;
        private NumericUpDown numericUpDownNumberHours;
        private NumericUpDown numericUpDownDisciplineID;
    }
}