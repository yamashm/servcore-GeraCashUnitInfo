
namespace TesteGeraCashUnitInfo
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
            this.txbEntrada = new System.Windows.Forms.TextBox();
            this.txbSaida = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbEntrada
            // 
            this.txbEntrada.Location = new System.Drawing.Point(12, 12);
            this.txbEntrada.MaxLength = 327670;
            this.txbEntrada.Multiline = true;
            this.txbEntrada.Name = "txbEntrada";
            this.txbEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbEntrada.Size = new System.Drawing.Size(1001, 227);
            this.txbEntrada.TabIndex = 0;
            // 
            // txbSaida
            // 
            this.txbSaida.Location = new System.Drawing.Point(12, 275);
            this.txbSaida.MaxLength = 327670;
            this.txbSaida.Multiline = true;
            this.txbSaida.Name = "txbSaida";
            this.txbSaida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbSaida.Size = new System.Drawing.Size(1001, 257);
            this.txbSaida.TabIndex = 1;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(938, 246);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(857, 246);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(12, 245);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(75, 23);
            this.btnProcessar.TabIndex = 4;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 544);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txbSaida);
            this.Controls.Add(this.txbEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEntrada;
        private System.Windows.Forms.TextBox txbSaida;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnProcessar;
    }
}

