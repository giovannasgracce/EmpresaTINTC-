namespace empresaTINT
{
    partial class Excluir
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
            this.VoltarAtualizar = new System.Windows.Forms.Button();
            this.ExcluirNovo = new System.Windows.Forms.Button();
            this.ExcluirEscrever = new System.Windows.Forms.TextBox();
            this.EnderecoNovo = new System.Windows.Forms.Label();
            this.CodigoNovo = new System.Windows.Forms.Label();
            this.AtualizarTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VoltarAtualizar
            // 
            this.VoltarAtualizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.VoltarAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.VoltarAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VoltarAtualizar.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.VoltarAtualizar.Location = new System.Drawing.Point(144, 278);
            this.VoltarAtualizar.Name = "VoltarAtualizar";
            this.VoltarAtualizar.Size = new System.Drawing.Size(87, 28);
            this.VoltarAtualizar.TabIndex = 44;
            this.VoltarAtualizar.Text = "Voltar";
            this.VoltarAtualizar.UseVisualStyleBackColor = false;
            this.VoltarAtualizar.Click += new System.EventHandler(this.VoltarAtualizar_Click);
            // 
            // ExcluirNovo
            // 
            this.ExcluirNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.ExcluirNovo.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ExcluirNovo.FlatAppearance.BorderSize = 2;
            this.ExcluirNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ExcluirNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirNovo.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.ExcluirNovo.Location = new System.Drawing.Point(144, 244);
            this.ExcluirNovo.Name = "ExcluirNovo";
            this.ExcluirNovo.Size = new System.Drawing.Size(87, 28);
            this.ExcluirNovo.TabIndex = 43;
            this.ExcluirNovo.Text = "Excluir";
            this.ExcluirNovo.UseVisualStyleBackColor = false;
            this.ExcluirNovo.Click += new System.EventHandler(this.ExcluirNovo_Click);
            // 
            // ExcluirEscrever
            // 
            this.ExcluirEscrever.Location = new System.Drawing.Point(161, 138);
            this.ExcluirEscrever.Name = "ExcluirEscrever";
            this.ExcluirEscrever.Size = new System.Drawing.Size(124, 20);
            this.ExcluirEscrever.TabIndex = 39;
            this.ExcluirEscrever.TextChanged += new System.EventHandler(this.ExcluirEscrever_TextChanged);
            // 
            // EnderecoNovo
            // 
            this.EnderecoNovo.AutoSize = true;
            this.EnderecoNovo.Location = new System.Drawing.Point(105, 226);
            this.EnderecoNovo.Name = "EnderecoNovo";
            this.EnderecoNovo.Size = new System.Drawing.Size(0, 13);
            this.EnderecoNovo.TabIndex = 37;
            // 
            // CodigoNovo
            // 
            this.CodigoNovo.AutoSize = true;
            this.CodigoNovo.Location = new System.Drawing.Point(99, 141);
            this.CodigoNovo.Name = "CodigoNovo";
            this.CodigoNovo.Size = new System.Drawing.Size(43, 13);
            this.CodigoNovo.TabIndex = 35;
            this.CodigoNovo.Text = "Código:";
            // 
            // AtualizarTitulo
            // 
            this.AtualizarTitulo.AutoSize = true;
            this.AtualizarTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AtualizarTitulo.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtualizarTitulo.Location = new System.Drawing.Point(108, 38);
            this.AtualizarTitulo.Name = "AtualizarTitulo";
            this.AtualizarTitulo.Size = new System.Drawing.Size(168, 47);
            this.AtualizarTitulo.TabIndex = 34;
            this.AtualizarTitulo.Text = "Excluir";
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 388);
            this.Controls.Add(this.VoltarAtualizar);
            this.Controls.Add(this.ExcluirNovo);
            this.Controls.Add(this.ExcluirEscrever);
            this.Controls.Add(this.EnderecoNovo);
            this.Controls.Add(this.CodigoNovo);
            this.Controls.Add(this.AtualizarTitulo);
            this.Name = "Excluir";
            this.Text = "Excluir";
            this.Load += new System.EventHandler(this.Excluir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VoltarAtualizar;
        private System.Windows.Forms.Button ExcluirNovo;
        private System.Windows.Forms.TextBox ExcluirEscrever;
        private System.Windows.Forms.Label EnderecoNovo;
        private System.Windows.Forms.Label CodigoNovo;
        private System.Windows.Forms.Label AtualizarTitulo;
    }
}