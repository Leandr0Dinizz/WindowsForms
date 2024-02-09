namespace Projeto_WindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadastrar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.Color.SteelBlue;
            this.cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.ForeColor = System.Drawing.Color.OldLace;
            this.cadastrar.Location = new System.Drawing.Point(43, 119);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(161, 76);
            this.cadastrar.TabIndex = 0;
            this.cadastrar.Text = "cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.Color.SteelBlue;
            this.consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.ForeColor = System.Drawing.Color.OldLace;
            this.consultar.Location = new System.Drawing.Point(240, 119);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(161, 76);
            this.consultar.TabIndex = 1;
            this.consultar.Text = "consultar";
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // atualizar
            // 
            this.atualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar.ForeColor = System.Drawing.Color.OldLace;
            this.atualizar.Location = new System.Drawing.Point(435, 119);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(161, 76);
            this.atualizar.TabIndex = 2;
            this.atualizar.Text = "atualizar";
            this.atualizar.UseVisualStyleBackColor = false;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // excluir
            // 
            this.excluir.BackColor = System.Drawing.Color.SteelBlue;
            this.excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluir.ForeColor = System.Drawing.Color.OldLace;
            this.excluir.Location = new System.Drawing.Point(620, 119);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(161, 76);
            this.excluir.TabIndex = 3;
            this.excluir.Text = "excluir";
            this.excluir.UseVisualStyleBackColor = false;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(198, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha uma das opções abaixo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.cadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Label label1;
    }
}

