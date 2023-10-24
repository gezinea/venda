namespace ErpSigmaVenda.Navegacao
{
    partial class FrmEscolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEscolha));
            this.btUsuario = new System.Windows.Forms.Button();
            this.btFornecedores = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.imgCliente = new System.Windows.Forms.PictureBox();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.imgProduto = new System.Windows.Forms.PictureBox();
            this.imgFornecedores = new System.Windows.Forms.PictureBox();
            this.btProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btUsuario
            // 
            this.btUsuario.Location = new System.Drawing.Point(185, 203);
            this.btUsuario.Name = "btUsuario";
            this.btUsuario.Size = new System.Drawing.Size(75, 23);
            this.btUsuario.TabIndex = 1;
            this.btUsuario.Text = "Usuario";
            this.btUsuario.UseVisualStyleBackColor = true;
            this.btUsuario.Visible = false;
            this.btUsuario.Click += new System.EventHandler(this.btUsuario_Click);
            // 
            // btFornecedores
            // 
            this.btFornecedores.Location = new System.Drawing.Point(12, 81);
            this.btFornecedores.Name = "btFornecedores";
            this.btFornecedores.Size = new System.Drawing.Size(75, 23);
            this.btFornecedores.TabIndex = 4;
            this.btFornecedores.Text = "Fornecedores";
            this.btFornecedores.UseVisualStyleBackColor = true;
            this.btFornecedores.Visible = false;
            this.btFornecedores.Click += new System.EventHandler(this.btFornecedores_Click);
            // 
            // btCliente
            // 
            this.btCliente.Location = new System.Drawing.Point(12, 203);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(75, 23);
            this.btCliente.TabIndex = 7;
            this.btCliente.Text = "Clientes";
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Visible = false;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // imgCliente
            // 
            this.imgCliente.Image = ((System.Drawing.Image)(resources.GetObject("imgCliente.Image")));
            this.imgCliente.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgCliente.InitialImage")));
            this.imgCliente.Location = new System.Drawing.Point(12, 135);
            this.imgCliente.Name = "imgCliente";
            this.imgCliente.Size = new System.Drawing.Size(75, 62);
            this.imgCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCliente.TabIndex = 6;
            this.imgCliente.TabStop = false;
            this.imgCliente.Visible = false;
            // 
            // imgUsuario
            // 
            this.imgUsuario.Image = global::ErpSigmaVenda.Properties.Resources.group;
            this.imgUsuario.Location = new System.Drawing.Point(185, 135);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(75, 62);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUsuario.TabIndex = 5;
            this.imgUsuario.TabStop = false;
            this.imgUsuario.Visible = false;
            // 
            // imgProduto
            // 
            this.imgProduto.Image = ((System.Drawing.Image)(resources.GetObject("imgProduto.Image")));
            this.imgProduto.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgProduto.InitialImage")));
            this.imgProduto.Location = new System.Drawing.Point(185, 12);
            this.imgProduto.Name = "imgProduto";
            this.imgProduto.Size = new System.Drawing.Size(75, 62);
            this.imgProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProduto.TabIndex = 3;
            this.imgProduto.TabStop = false;
            this.imgProduto.Visible = false;
            // 
            // imgFornecedores
            // 
            this.imgFornecedores.Image = global::ErpSigmaVenda.Properties.Resources.customer_service;
            this.imgFornecedores.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgFornecedores.InitialImage")));
            this.imgFornecedores.Location = new System.Drawing.Point(12, 12);
            this.imgFornecedores.Name = "imgFornecedores";
            this.imgFornecedores.Size = new System.Drawing.Size(75, 62);
            this.imgFornecedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFornecedores.TabIndex = 2;
            this.imgFornecedores.TabStop = false;
            this.imgFornecedores.Visible = false;
            // 
            // btProduto
            // 
            this.btProduto.Image = ((System.Drawing.Image)(resources.GetObject("btProduto.Image")));
            this.btProduto.Location = new System.Drawing.Point(185, 80);
            this.btProduto.Name = "btProduto";
            this.btProduto.Size = new System.Drawing.Size(75, 23);
            this.btProduto.TabIndex = 0;
            this.btProduto.Text = "Produto";
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Visible = false;
            this.btProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdmEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 242);
            this.Controls.Add(this.btCliente);
            this.Controls.Add(this.imgCliente);
            this.Controls.Add(this.imgUsuario);
            this.Controls.Add(this.btFornecedores);
            this.Controls.Add(this.imgProduto);
            this.Controls.Add(this.imgFornecedores);
            this.Controls.Add(this.btUsuario);
            this.Controls.Add(this.btProduto);
            this.Name = "AdmEscolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmEscolha";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.Button btUsuario;
        private System.Windows.Forms.PictureBox imgFornecedores;
        private System.Windows.Forms.PictureBox imgProduto;
        private System.Windows.Forms.Button btFornecedores;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.PictureBox imgCliente;
        private System.Windows.Forms.Button btCliente;
    }
}