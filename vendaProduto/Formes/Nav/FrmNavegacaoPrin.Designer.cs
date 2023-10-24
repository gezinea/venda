namespace ErpSigmaVenda.Navegacao
{
    partial class FrmNavegacaoPrin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNavegacaoPrin));
            this.btCadastro = new System.Windows.Forms.Button();
            this.btVendas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastro
            // 
            this.btCadastro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastro.Image = global::ErpSigmaVenda.Properties.Resources.edit__1_;
            this.btCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastro.Location = new System.Drawing.Point(131, 11);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(113, 49);
            this.btCadastro.TabIndex = 1;
            this.btCadastro.Text = "Cadastros";
            this.btCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadastro.UseVisualStyleBackColor = false;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // btVendas
            // 
            this.btVendas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVendas.Image = ((System.Drawing.Image)(resources.GetObject("btVendas.Image")));
            this.btVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVendas.Location = new System.Drawing.Point(12, 12);
            this.btVendas.Name = "btVendas";
            this.btVendas.Size = new System.Drawing.Size(113, 48);
            this.btVendas.TabIndex = 0;
            this.btVendas.Text = "Vendas";
            this.btVendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btVendas.UseVisualStyleBackColor = false;
            this.btVendas.Click += new System.EventHandler(this.btVendas_Click);
            // 
            // NavegacaoPrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 224);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.btVendas);
            this.Name = "NavegacaoPrin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NavegacaoPrin";
            this.Load += new System.EventHandler(this.NavegacaoPrin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btVendas;
        private System.Windows.Forms.Button btCadastro;
    }
}