
namespace TesteGeraCashUnitInfo
{
    partial class FormEditar
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
            this.ltbCashUnits = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txbCashUnit = new System.Windows.Forms.TextBox();
            this.rdbREJ = new System.Windows.Forms.RadioButton();
            this.rdbRET = new System.Windows.Forms.RadioButton();
            this.rdbDEP = new System.Windows.Forms.RadioButton();
            this.rdbREC = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ltbCashUnits
            // 
            this.ltbCashUnits.FormattingEnabled = true;
            this.ltbCashUnits.Location = new System.Drawing.Point(12, 12);
            this.ltbCashUnits.Name = "ltbCashUnits";
            this.ltbCashUnits.Size = new System.Drawing.Size(142, 420);
            this.ltbCashUnits.TabIndex = 0;
            this.ltbCashUnits.SelectedIndexChanged += new System.EventHandler(this.ltbCashUnits_SelectedIndexChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(713, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(713, 41);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(713, 70);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txbCashUnit
            // 
            this.txbCashUnit.Location = new System.Drawing.Point(160, 12);
            this.txbCashUnit.Multiline = true;
            this.txbCashUnit.Name = "txbCashUnit";
            this.txbCashUnit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbCashUnit.Size = new System.Drawing.Size(547, 420);
            this.txbCashUnit.TabIndex = 4;
            // 
            // rdbREJ
            // 
            this.rdbREJ.AutoSize = true;
            this.rdbREJ.Location = new System.Drawing.Point(713, 113);
            this.rdbREJ.Name = "rdbREJ";
            this.rdbREJ.Size = new System.Drawing.Size(45, 17);
            this.rdbREJ.TabIndex = 5;
            this.rdbREJ.TabStop = true;
            this.rdbREJ.Text = "REJ";
            this.rdbREJ.UseVisualStyleBackColor = true;
            // 
            // rdbRET
            // 
            this.rdbRET.AutoSize = true;
            this.rdbRET.Location = new System.Drawing.Point(713, 136);
            this.rdbRET.Name = "rdbRET";
            this.rdbRET.Size = new System.Drawing.Size(47, 17);
            this.rdbRET.TabIndex = 6;
            this.rdbRET.TabStop = true;
            this.rdbRET.Text = "RET";
            this.rdbRET.UseVisualStyleBackColor = true;
            // 
            // rdbDEP
            // 
            this.rdbDEP.AutoSize = true;
            this.rdbDEP.Location = new System.Drawing.Point(713, 159);
            this.rdbDEP.Name = "rdbDEP";
            this.rdbDEP.Size = new System.Drawing.Size(47, 17);
            this.rdbDEP.TabIndex = 7;
            this.rdbDEP.TabStop = true;
            this.rdbDEP.Text = "DEP";
            this.rdbDEP.UseVisualStyleBackColor = true;
            // 
            // rdbREC
            // 
            this.rdbREC.AutoSize = true;
            this.rdbREC.Location = new System.Drawing.Point(713, 182);
            this.rdbREC.Name = "rdbREC";
            this.rdbREC.Size = new System.Drawing.Size(47, 17);
            this.rdbREC.TabIndex = 8;
            this.rdbREC.TabStop = true;
            this.rdbREC.Text = "REC";
            this.rdbREC.UseVisualStyleBackColor = true;
            // 
            // FormEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.rdbREC);
            this.Controls.Add(this.rdbDEP);
            this.Controls.Add(this.rdbRET);
            this.Controls.Add(this.rdbREJ);
            this.Controls.Add(this.txbCashUnit);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.ltbCashUnits);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEditar";
            this.Text = "FormEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbCashUnits;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txbCashUnit;
        private System.Windows.Forms.RadioButton rdbREJ;
        private System.Windows.Forms.RadioButton rdbRET;
        private System.Windows.Forms.RadioButton rdbDEP;
        private System.Windows.Forms.RadioButton rdbREC;
    }
}