namespace Projeto_WindowsForm
{
    partial class Cadastrar
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
            this.codigo = new System.Windows.Forms.Label();
            this.nomes = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.Label();
            this.cidades = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.Label();
            this.estados = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cadastro = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.codigos = new System.Windows.Forms.MaskedTextBox();
            this.telefones = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(77, 101);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(57, 21);
            this.codigo.TabIndex = 0;
            this.codigo.Text = "Código";
            this.codigo.Click += new System.EventHandler(this.codigo_Click);
            // 
            // nomes
            // 
            this.nomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomes.Location = new System.Drawing.Point(177, 148);
            this.nomes.Name = "nomes";
            this.nomes.Size = new System.Drawing.Size(100, 22);
            this.nomes.TabIndex = 3;
            this.nomes.TextChanged += new System.EventHandler(this.nomes_TextChanged);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(81, 149);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(53, 21);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome";
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(77, 202);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(71, 21);
            this.telefone.TabIndex = 4;
            this.telefone.Text = "Telefone";
            // 
            // cidades
            // 
            this.cidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidades.Location = new System.Drawing.Point(177, 247);
            this.cidades.Name = "cidades";
            this.cidades.Size = new System.Drawing.Size(100, 22);
            this.cidades.TabIndex = 7;
            this.cidades.TextChanged += new System.EventHandler(this.cidades_TextChanged);
            // 
            // cidade
            // 
            this.cidade.AutoSize = true;
            this.cidade.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade.Location = new System.Drawing.Point(81, 248);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(58, 21);
            this.cidade.TabIndex = 6;
            this.cidade.Text = "Cidade";
            // 
            // estados
            // 
            this.estados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estados.Location = new System.Drawing.Point(177, 295);
            this.estados.Name = "estados";
            this.estados.Size = new System.Drawing.Size(100, 22);
            this.estados.TabIndex = 9;
            this.estados.TextChanged += new System.EventHandler(this.estados_TextChanged);
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.Location = new System.Drawing.Point(81, 296);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(60, 21);
            this.estado.TabIndex = 8;
            this.estado.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cadastrar Pessoa";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cadastro
            // 
            this.cadastro.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cadastro.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro.ForeColor = System.Drawing.Color.Black;
            this.cadastro.Location = new System.Drawing.Point(22, 399);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(144, 39);
            this.cadastro.TabIndex = 11;
            this.cadastro.Text = "Cadastrar";
            this.cadastro.UseVisualStyleBackColor = false;
            this.cadastro.Click += new System.EventHandler(this.cadastro_Click);
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.voltar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.Black;
            this.voltar.Location = new System.Drawing.Point(193, 399);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(144, 39);
            this.voltar.TabIndex = 12;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // codigos
            // 
            this.codigos.Location = new System.Drawing.Point(177, 102);
            this.codigos.Mask = "99999";
            this.codigos.Name = "codigos";
            this.codigos.Size = new System.Drawing.Size(100, 20);
            this.codigos.TabIndex = 13;
            this.codigos.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codigos_MaskInputRejected);
            // 
            // telefones
            // 
            this.telefones.Location = new System.Drawing.Point(177, 202);
            this.telefones.Mask = "(99)99999-9999";
            this.telefones.Name = "telefones";
            this.telefones.Size = new System.Drawing.Size(100, 20);
            this.telefones.TabIndex = 14;
            this.telefones.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefones_MaskInputRejected);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.telefones);
            this.Controls.Add(this.codigos);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.cadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estados);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.cidades);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.nomes);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.codigo);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.TextBox nomes;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.TextBox cidades;
        private System.Windows.Forms.Label cidade;
        private System.Windows.Forms.TextBox estados;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cadastro;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.MaskedTextBox codigos;
        private System.Windows.Forms.MaskedTextBox telefones;
    }
}