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
            groupBoxDisciplineAdding = new GroupBox();
            buttonStore = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxDisciplineName = new TextBox();
            numericUpDownNumberHours = new NumericUpDown();
            numericUpDownDisciplineID = new NumericUpDown();
            buttonClear = new Button();
            groupBoxDisciplineAdding.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisciplineID).BeginInit();
            SuspendLayout();
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
            groupBoxDisciplineAdding.TabIndex = 2;
            groupBoxDisciplineAdding.TabStop = false;
            groupBoxDisciplineAdding.Text = "Editar Disciplina";
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
            buttonStore.Location = new Point(482, 305);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new Size(125, 50);
            buttonStore.TabIndex = 3;
            buttonStore.TextAlign = ContentAlignment.MiddleRight;
            buttonStore.UseVisualStyleBackColor = true;
            buttonStore.Click += ButtonSave_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 186);
            label2.Name = "label2";
            label2.Size = new Size(172, 34);
            label2.TabIndex = 2;
            label2.Text = "Carga Horária da Disciplina:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 32);
            label3.Name = "label3";
            label3.Size = new Size(172, 17);
            label3.TabIndex = 0;
            label3.Text = "ID da Disciplina:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 113);
            label4.Name = "label4";
            label4.Size = new Size(172, 17);
            label4.TabIndex = 1;
            label4.Text = "Nome da Disciplina:";
            // 
            // textBoxDisciplineName
            // 
            textBoxDisciplineName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxDisciplineName.Location = new Point(181, 109);
            textBoxDisciplineName.Name = "textBoxDisciplineName";
            textBoxDisciplineName.Size = new Size(531, 25);
            textBoxDisciplineName.TabIndex = 4;
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
            // DisciplineEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 155, 104);
            ClientSize = new Size(819, 431);
            Controls.Add(groupBoxDisciplineAdding);
            KeyPreview = true;
            Name = "DisciplineEdit";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulário Editar Disciplina";
            Load += WinFormDisciplineEdit_Load;
            KeyDown += WinForm_KeyDown;
            groupBoxDisciplineAdding.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisciplineID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDisciplineAdding;
        private Button buttonStore;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxDisciplineName;
        private NumericUpDown numericUpDownNumberHours;
        private NumericUpDown numericUpDownDisciplineID;
        private Button buttonClear;
    }
}