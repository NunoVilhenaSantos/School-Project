namespace School_Project.WForms.JoelForms
{
    partial class FormAdicionarNovoClt
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
            txtMorada = new TextBox();
            txtLocalidade = new TextBox();
            txtTelemovel = new TextBox();
            txtEmail = new TextBox();
            txtApelido = new TextBox();
            txtCodigoPostal = new TextBox();
            txtNIF = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            btnEditar = new Button();
            btnAdicionarCliente = new Button();
            SuspendLayout();
            // 
            // txtMorada
            // 
            txtMorada.Location = new Point(75, 129);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(354, 27);
            txtMorada.TabIndex = 0;
            // 
            // txtLocalidade
            // 
            txtLocalidade.Location = new Point(255, 189);
            txtLocalidade.Name = "txtLocalidade";
            txtLocalidade.Size = new Size(174, 27);
            txtLocalidade.TabIndex = 1;
            // 
            // txtTelemovel
            // 
            txtTelemovel.Location = new Point(75, 242);
            txtTelemovel.Name = "txtTelemovel";
            txtTelemovel.Size = new Size(125, 27);
            txtTelemovel.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(206, 242);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(255, 62);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(174, 27);
            txtApelido.TabIndex = 4;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(75, 189);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(165, 27);
            txtCodigoPostal.TabIndex = 5;
            // 
            // txtNIF
            // 
            txtNIF.Location = new Point(75, 300);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(125, 27);
            txtNIF.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(75, 62);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(157, 27);
            txtNome.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 20);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 8;
            label1.Text = "Dados do Cliente";
            // 
            // btnEditar
            // 
            //btnEditar.Image = Resources.botao_Editar;
            btnEditar.Location = new Point(318, 293);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 50);
            btnEditar.TabIndex = 9;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.Location = new Point(864, 686);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(84, 40);
            btnAdicionarCliente.TabIndex = 10;
            btnAdicionarCliente.Text = "Guardar";
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            // 
            // FormAdicionarNovoClt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 738);
            Controls.Add(btnAdicionarCliente);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtNIF);
            Controls.Add(txtCodigoPostal);
            Controls.Add(txtApelido);
            Controls.Add(txtEmail);
            Controls.Add(txtTelemovel);
            Controls.Add(txtLocalidade);
            Controls.Add(txtMorada);
            Name = "FormAdicionarNovoClt";
            Text = "FormAdicionarNovoClt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMorada;
        private TextBox txtLocalidade;
        private TextBox txtTelemovel;
        private TextBox txtEmail;
        private TextBox txtApelido;
        private TextBox txtCodigoPostal;
        private TextBox txtNIF;
        private TextBox txtNome;
        private Label label1;
        private Button btnEditar;
        private Button btnAdicionarCliente;
    }
}