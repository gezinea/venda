namespace ErpSigmaVenda.Navegacao
{
    partial class FrmFornecedore
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedore));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btEditar = new System.Windows.Forms.ToolStripButton();
            this.btDeletar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgFornecedores = new System.Windows.Forms.DataGridView();
            this.idFornecedoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEnderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aXfornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aXfornecedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdicionar,
            this.btEditar,
            this.btDeletar,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(405, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAdicionar
            // 
            this.btAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionar.Image")));
            this.btAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(23, 22);
            this.btAdicionar.Text = "toolStripButton1";
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btEditar
            // 
            this.btEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(23, 22);
            this.btEditar.Text = "toolStripButton2";
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btDeletar.Image")));
            this.btDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(23, 22);
            this.btDeletar.Text = "toolStripButton3";
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // dgFornecedores
            // 
            this.dgFornecedores.AllowUserToAddRows = false;
            this.dgFornecedores.AutoGenerateColumns = false;
            this.dgFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFornecedoresDataGridViewTextBoxColumn,
            this.idEnderecoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn});
            this.dgFornecedores.DataSource = this.aXfornecedoresBindingSource;
            this.dgFornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFornecedores.Location = new System.Drawing.Point(0, 25);
            this.dgFornecedores.Name = "dgFornecedores";
            this.dgFornecedores.ReadOnly = true;
            this.dgFornecedores.RowHeadersVisible = false;
            this.dgFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFornecedores.Size = new System.Drawing.Size(405, 212);
            this.dgFornecedores.TabIndex = 4;
            this.dgFornecedores.SelectionChanged += new System.EventHandler(this.dgFornecedores_SelectionChanged);
            // 
            // idFornecedoresDataGridViewTextBoxColumn
            // 
            this.idFornecedoresDataGridViewTextBoxColumn.DataPropertyName = "IdFornecedores";
            this.idFornecedoresDataGridViewTextBoxColumn.HeaderText = "IdFornecedores";
            this.idFornecedoresDataGridViewTextBoxColumn.Name = "idFornecedoresDataGridViewTextBoxColumn";
            this.idFornecedoresDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFornecedoresDataGridViewTextBoxColumn.Visible = false;
            // 
            // idEnderecoDataGridViewTextBoxColumn
            // 
            this.idEnderecoDataGridViewTextBoxColumn.DataPropertyName = "idEndereco";
            this.idEnderecoDataGridViewTextBoxColumn.HeaderText = "idEndereco";
            this.idEnderecoDataGridViewTextBoxColumn.Name = "idEnderecoDataGridViewTextBoxColumn";
            this.idEnderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEnderecoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataSource = typeof(ErpSigmaVenda.Conexao.Fornecedores);
            // 
            // aXfornecedoresBindingSource
            // 
            this.aXfornecedoresBindingSource.DataSource = typeof(ErpSigmaVenda.Auxiliares.AXfornecedores);
            // 
            // Fornecedore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 237);
            this.Controls.Add(this.dgFornecedores);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Fornecedore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.Fornecedores_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aXfornecedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btAdicionar;
        private System.Windows.Forms.ToolStripButton btEditar;
        private System.Windows.Forms.ToolStripButton btDeletar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgFornecedores;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEnderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aXfornecedoresBindingSource;
    }
}