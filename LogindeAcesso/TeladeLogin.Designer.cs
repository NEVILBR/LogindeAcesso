namespace LogindeAcesso
{
    partial class TeladeLogin
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
            this.textboxusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxsenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btacessar = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxusuario
            // 
            this.textboxusuario.Location = new System.Drawing.Point(74, 61);
            this.textboxusuario.Name = "textboxusuario";
            this.textboxusuario.Size = new System.Drawing.Size(173, 20);
            this.textboxusuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // textboxsenha
            // 
            this.textboxsenha.Location = new System.Drawing.Point(74, 100);
            this.textboxsenha.Name = "textboxsenha";
            this.textboxsenha.PasswordChar = '*';
            this.textboxsenha.Size = new System.Drawing.Size(173, 20);
            this.textboxsenha.TabIndex = 0;
            this.textboxsenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // btacessar
            // 
            this.btacessar.Location = new System.Drawing.Point(74, 126);
            this.btacessar.Name = "btacessar";
            this.btacessar.Size = new System.Drawing.Size(75, 23);
            this.btacessar.TabIndex = 2;
            this.btacessar.Text = "Acessar";
            this.btacessar.UseVisualStyleBackColor = true;
            // 
            // btsair
            // 
            this.btsair.Location = new System.Drawing.Point(74, 155);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(75, 23);
            this.btsair.TabIndex = 2;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            // 
            // TeladeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 224);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btacessar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxsenha);
            this.Controls.Add(this.textboxusuario);
            this.MaximizeBox = false;
            this.Name = "TeladeLogin";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxsenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btacessar;
        private System.Windows.Forms.Button btsair;
    }
}

