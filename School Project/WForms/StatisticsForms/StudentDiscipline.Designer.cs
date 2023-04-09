namespace School_Project.WForms.StatisticsForms
{
    partial class StudentDiscipline
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
            groupBoxStudentsList = new GroupBox();
            buttonStudentEdit = new Button();
            buttonStudentRemove = new Button();
            listBoxStudents = new ListBox();
            groupBoxDisciplinesList = new GroupBox();
            buttonStudentDisciplinesAdding = new Button();
            checkedListBoxDisciplines = new CheckedListBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBoxStudentsList.SuspendLayout();
            groupBoxDisciplinesList.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxStudentsList
            // 
            groupBoxStudentsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxStudentsList.Controls.Add(buttonStudentEdit);
            groupBoxStudentsList.Controls.Add(buttonStudentRemove);
            groupBoxStudentsList.Controls.Add(listBoxStudents);
            groupBoxStudentsList.Location = new Point(13, 13);
            groupBoxStudentsList.Name = "groupBoxStudentsList";
            groupBoxStudentsList.Size = new Size(305, 556);
            groupBoxStudentsList.TabIndex = 4;
            groupBoxStudentsList.TabStop = false;
            groupBoxStudentsList.Text = "Lista de Estudantes";
            // 
            // buttonStudentEdit
            // 
            buttonStudentEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonStudentEdit.AutoSize = true;
            buttonStudentEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStudentEdit.Location = new Point(179, 518);
            buttonStudentEdit.Name = "buttonStudentEdit";
            buttonStudentEdit.Size = new Size(120, 31);
            buttonStudentEdit.TabIndex = 0;
            buttonStudentEdit.Text = "Editar";
            buttonStudentEdit.UseVisualStyleBackColor = true;
            buttonStudentEdit.Click += ButtonStudentEdit_Click;
            // 
            // buttonStudentRemove
            // 
            buttonStudentRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonStudentRemove.AutoSize = true;
            buttonStudentRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStudentRemove.Location = new Point(6, 518);
            buttonStudentRemove.Name = "buttonStudentRemove";
            buttonStudentRemove.Size = new Size(120, 31);
            buttonStudentRemove.TabIndex = 0;
            buttonStudentRemove.Text = "Remover";
            buttonStudentRemove.UseVisualStyleBackColor = true;
            buttonStudentRemove.Click += ButtonStudentRemove_Click;
            // 
            // listBoxStudents
            // 
            listBoxStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 15;
            listBoxStudents.Location = new Point(6, 22);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(293, 469);
            listBoxStudents.TabIndex = 2;
            listBoxStudents.SelectedIndexChanged += ListBoxStudents_SelectedIndexChanged;
            // 
            // groupBoxDisciplinesList
            // 
            groupBoxDisciplinesList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxDisciplinesList.Controls.Add(buttonStudentDisciplinesAdding);
            groupBoxDisciplinesList.Controls.Add(checkedListBoxDisciplines);
            groupBoxDisciplinesList.Location = new Point(342, 13);
            groupBoxDisciplinesList.Name = "groupBoxDisciplinesList";
            groupBoxDisciplinesList.Size = new Size(445, 556);
            groupBoxDisciplinesList.TabIndex = 5;
            groupBoxDisciplinesList.TabStop = false;
            groupBoxDisciplinesList.Text = "Lista de Disciplinas";
            // 
            // buttonStudentDisciplinesAdding
            // 
            buttonStudentDisciplinesAdding.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonStudentDisciplinesAdding.AutoSize = true;
            buttonStudentDisciplinesAdding.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStudentDisciplinesAdding.Location = new Point(127, 518);
            buttonStudentDisciplinesAdding.Name = "buttonStudentDisciplinesAdding";
            buttonStudentDisciplinesAdding.Size = new Size(190, 31);
            buttonStudentDisciplinesAdding.TabIndex = 3;
            buttonStudentDisciplinesAdding.Text = "Adicionar ou Remover";
            buttonStudentDisciplinesAdding.UseVisualStyleBackColor = true;
            buttonStudentDisciplinesAdding.Click += ButtonStudentDisciplinesAdding_Click;
            // 
            // checkedListBoxDisciplines
            // 
            checkedListBoxDisciplines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBoxDisciplines.FormattingEnabled = true;
            checkedListBoxDisciplines.Location = new Point(6, 22);
            checkedListBoxDisciplines.Name = "checkedListBoxDisciplines";
            checkedListBoxDisciplines.Size = new Size(433, 472);
            checkedListBoxDisciplines.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(817, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 556);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(97, 518);
            button1.Name = "button1";
            button1.Size = new Size(187, 31);
            button1.TabIndex = 4;
            button1.Text = "Adicionar Notas";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(375, 475);
            dataGridView1.TabIndex = 5;
            // 
            // StudentDiscipline
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1224, 587);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxDisciplinesList);
            Controls.Add(groupBoxStudentsList);
            KeyPreview = true;
            Name = "StudentDiscipline";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulário Adicionar Disciplinas ao Estudante";
            Load += WinFormStudentDiscipline_Load;
            KeyDown += WinForm_KeyDown;
            groupBoxStudentsList.ResumeLayout(false);
            groupBoxStudentsList.PerformLayout();
            groupBoxDisciplinesList.ResumeLayout(false);
            groupBoxDisciplinesList.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxStudentsList;
        private Button buttonStudentEdit;
        private Button buttonStudentRemove;
        private ListBox listBoxStudents;
        private GroupBox groupBoxDisciplinesList;
        private Button buttonStudentDisciplinesAdding;
        private CheckedListBox checkedListBoxDisciplines;
        private GroupBox groupBox1;
        private Button button1;
        private DataGridView dataGridView1;
    }
}