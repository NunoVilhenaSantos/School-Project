namespace School_Project.WForms.JoelForms
{
    partial class FormCliente
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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            ColNome = new DataGridViewTextBoxColumn();
            ColApelido = new DataGridViewTextBoxColumn();
            ColOMorada = new DataGridViewTextBoxColumn();
            ColTelemovel = new DataGridViewTextBoxColumn();
            ColNIF = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            //button1.BackgroundImage = Resources.botaoProcurar;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(907, 161);
            button1.Name = "button1";
            button1.Size = new Size(189, 57);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            //button2.BackgroundImage = Resources.botao_novoCliente;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(886, 505);
            button2.Name = "button2";
            button2.Size = new Size(189, 57);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 104);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(860, 111);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 5;
            label4.Text = "Código Postal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 107);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 6;
            label5.Text = "Apelido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(655, 111);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 7;
            label6.Text = "NIF";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 27);
            textBox2.TabIndex = 12;
            textBox2.Text = "Nome";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(980, 111);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(496, 107);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 16;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(701, 111);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, ColNome, ColApelido, ColOMorada, ColTelemovel, ColNIF });
            dataGridView1.Location = new Point(33, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1072, 259);
            dataGridView1.TabIndex = 23;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.Visible = false;
            colId.Width = 300;
            // 
            // ColNome
            // 
            ColNome.HeaderText = "Nome";
            ColNome.MinimumWidth = 20;
            ColNome.Name = "ColNome";
            ColNome.Width = 150;
            // 
            // ColApelido
            // 
            ColApelido.HeaderText = "Apelido";
            ColApelido.MinimumWidth = 6;
            ColApelido.Name = "ColApelido";
            ColApelido.Width = 150;
            // 
            // ColOMorada
            // 
            ColOMorada.HeaderText = "Morada";
            ColOMorada.MinimumWidth = 6;
            ColOMorada.Name = "ColOMorada";
            ColOMorada.Width = 400;
            // 
            // ColTelemovel
            // 
            ColTelemovel.HeaderText = "Telemóvel";
            ColTelemovel.MinimumWidth = 6;
            ColTelemovel.Name = "ColTelemovel";
            ColTelemovel.Width = 130;
            // 
            // ColNIF
            // 
            ColNIF.HeaderText = "NIF";
            ColNIF.MinimumWidth = 6;
            ColNIF.Name = "ColNIF";
            ColNIF.Width = 175;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 174);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 24;
            label1.Text = "Resultado da pesquisa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 49);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 25;
            label3.Text = "Pesquisa de Cliente";
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 582);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox8);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            MinimumSize = new Size(897, 528);
            Name = "FormCliente";
            Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn ColNome;
        private DataGridViewTextBoxColumn ColApelido;
        private DataGridViewTextBoxColumn ColOMorada;
        private DataGridViewTextBoxColumn ColTelemovel;
        private DataGridViewTextBoxColumn ColNIF;
        private Label label1;
        private Label label3;
    }
}