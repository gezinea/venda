namespace ErpSigmaVenda.Navegacao
{
    partial class FrmVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgVendas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQntVenda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDtVenda = new System.Windows.Forms.DateTimePicker();
            this.btCadVenda = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btBuscaCli = new System.Windows.Forms.Button();
            this.btCadCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCPFc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomecli = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btAlterarProd = new System.Windows.Forms.ToolStripButton();
            this.btRemover = new System.Windows.Forms.ToolStripButton();
            this.QtdVendaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precocollunm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdutoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntEstoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aXprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aXclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aXprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aXclienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVendas
            // 
            this.dgVendas.AllowUserToAddRows = false;
            this.dgVendas.AllowUserToDeleteRows = false;
            this.dgVendas.AutoGenerateColumns = false;
            this.dgVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoColumn,
            this.qntEstoqueDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.QtdVendaColumn,
            this.precocollunm,
            this.ValorTotaColumn});
            this.dgVendas.DataSource = this.aXprodutoBindingSource;
            this.dgVendas.Location = new System.Drawing.Point(16, 59);
            this.dgVendas.Name = "dgVendas";
            this.dgVendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgVendas.RowHeadersVisible = false;
            this.dgVendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVendas.Size = new System.Drawing.Size(525, 144);
            this.dgVendas.TabIndex = 1;
            this.dgVendas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVendas_CellEndEdit);
            this.dgVendas.SelectionChanged += new System.EventHandler(this.dgVendas_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastro nova venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data da Venda";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtQntVenda
            // 
            this.txtQntVenda.Location = new System.Drawing.Point(4, 89);
            this.txtQntVenda.Name = "txtQntVenda";
            this.txtQntVenda.ReadOnly = true;
            this.txtQntVenda.Size = new System.Drawing.Size(144, 20);
            this.txtQntVenda.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDtVenda);
            this.groupBox1.Controls.Add(this.btCadVenda);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtQntVenda);
            this.groupBox1.Location = new System.Drawing.Point(16, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 139);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtDtVenda
            // 
            this.txtDtVenda.Enabled = false;
            this.txtDtVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtVenda.Location = new System.Drawing.Point(6, 50);
            this.txtDtVenda.Name = "txtDtVenda";
            this.txtDtVenda.Size = new System.Drawing.Size(142, 20);
            this.txtDtVenda.TabIndex = 14;
            // 
            // btCadVenda
            // 
            this.btCadVenda.Location = new System.Drawing.Point(164, 89);
            this.btCadVenda.Name = "btCadVenda";
            this.btCadVenda.Size = new System.Drawing.Size(138, 23);
            this.btCadVenda.TabIndex = 12;
            this.btCadVenda.Text = "Fechar Venda";
            this.btCadVenda.UseVisualStyleBackColor = true;
            this.btCadVenda.Click += new System.EventHandler(this.btCadVenda_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(164, 50);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(138, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Venda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantidade Total Venda";
            // 
            // btBuscaCli
            // 
            this.btBuscaCli.Location = new System.Drawing.Point(580, 95);
            this.btBuscaCli.Name = "btBuscaCli";
            this.btBuscaCli.Size = new System.Drawing.Size(149, 38);
            this.btBuscaCli.TabIndex = 11;
            this.btBuscaCli.Text = "Buscar Cliente";
            this.btBuscaCli.UseVisualStyleBackColor = true;
            this.btBuscaCli.Click += new System.EventHandler(this.btBuscaCli_Click);
            // 
            // btCadCliente
            // 
            this.btCadCliente.Location = new System.Drawing.Point(580, 165);
            this.btCadCliente.Name = "btCadCliente";
            this.btCadCliente.Size = new System.Drawing.Size(149, 38);
            this.btCadCliente.TabIndex = 12;
            this.btCadCliente.Text = "Cadastre Novo Cliente";
            this.btCadCliente.UseVisualStyleBackColor = true;
            this.btCadCliente.Click += new System.EventHandler(this.btCadCliente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtIdCliente);
            this.groupBox2.Controls.Add(this.txtNum);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCEP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCPFc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNomecli);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 138);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Cliente";
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(166, 89);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(128, 20);
            this.txtNum.TabIndex = 22;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(163, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Número";
            // 
            // txtCEP
            // 
            this.txtCEP.Enabled = false;
            this.txtCEP.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(166, 46);
            this.txtCEP.Multiline = true;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.ReadOnly = true;
            this.txtCEP.Size = new System.Drawing.Size(128, 20);
            this.txtCEP.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "CEP";
            // 
            // txtCPFc
            // 
            this.txtCPFc.Enabled = false;
            this.txtCPFc.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFc.Location = new System.Drawing.Point(6, 89);
            this.txtCPFc.Multiline = true;
            this.txtCPFc.Name = "txtCPFc";
            this.txtCPFc.ReadOnly = true;
            this.txtCPFc.Size = new System.Drawing.Size(128, 20);
            this.txtCPFc.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "CPF";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nome";
            // 
            // txtNomecli
            // 
            this.txtNomecli.Enabled = false;
            this.txtNomecli.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomecli.Location = new System.Drawing.Point(6, 46);
            this.txtNomecli.Multiline = true;
            this.txtNomecli.Name = "txtNomecli";
            this.txtNomecli.ReadOnly = true;
            this.txtNomecli.Size = new System.Drawing.Size(128, 20);
            this.txtNomecli.TabIndex = 15;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdicionar,
            this.btAlterarProd,
            this.btRemover});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(759, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Image = global::ErpSigmaVenda.Properties.Resources.catalog;
            this.btAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(124, 22);
            this.btAdicionar.Text = "Adicionar Produto";
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btAlterarProd
            // 
            this.btAlterarProd.Image = global::ErpSigmaVenda.Properties.Resources.edit__1_;
            this.btAlterarProd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAlterarProd.Name = "btAlterarProd";
            this.btAlterarProd.Size = new System.Drawing.Size(175, 22);
            this.btAlterarProd.Text = "Alterar Produto Selecionado";
            this.btAlterarProd.Click += new System.EventHandler(this.btAlterarProd_Click);
            // 
            // btRemover
            // 
            this.btRemover.Image = global::ErpSigmaVenda.Properties.Resources.trash__1_;
            this.btRemover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(123, 22);
            this.btRemover.Text = "Remover Produto ";
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // QtdVendaColumn
            // 
            this.QtdVendaColumn.HeaderText = "Quantidade";
            this.QtdVendaColumn.Name = "QtdVendaColumn";
            // 
            // precocollunm
            // 
            this.precocollunm.DataPropertyName = "Preco";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.precocollunm.DefaultCellStyle = dataGridViewCellStyle1;
            this.precocollunm.HeaderText = "Preço";
            this.precocollunm.Name = "precocollunm";
            this.precocollunm.ReadOnly = true;
            // 
            // ValorTotaColumn
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ValorTotaColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ValorTotaColumn.HeaderText = "Total Produto";
            this.ValorTotaColumn.Name = "ValorTotaColumn";
            this.ValorTotaColumn.ReadOnly = true;
            // 
            // idProdutoColumn
            // 
            this.idProdutoColumn.DataPropertyName = "idProduto";
            this.idProdutoColumn.HeaderText = "idProduto";
            this.idProdutoColumn.Name = "idProdutoColumn";
            this.idProdutoColumn.ReadOnly = true;
            this.idProdutoColumn.Visible = false;
            // 
            // qntEstoqueDataGridViewTextBoxColumn
            // 
            this.qntEstoqueDataGridViewTextBoxColumn.DataPropertyName = "QntEstoque";
            this.qntEstoqueDataGridViewTextBoxColumn.HeaderText = "QntEstoque";
            this.qntEstoqueDataGridViewTextBoxColumn.Name = "qntEstoqueDataGridViewTextBoxColumn";
            this.qntEstoqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.qntEstoqueDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aXprodutoBindingSource
            // 
            this.aXprodutoBindingSource.DataSource = typeof(ErpSigmaVenda.Auxiliares.AXproduto);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(ErpSigmaVenda.Conexao.Produto);
            // 
            // aXclienteBindingSource
            // 
            this.aXclienteBindingSource.DataSource = typeof(ErpSigmaVenda.Auxiliares.AXcliente);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(334, 46);
            this.txtIdCliente.Multiline = true;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(128, 20);
            this.txtIdCliente.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(331, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "ID Cliente";
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 531);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btCadCliente);
            this.Controls.Add(this.btBuscaCli);
            this.Controls.Add(this.dgVendas);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aXprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aXclienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgVendas;
        private System.Windows.Forms.BindingSource aXclienteBindingSource;
        private System.Windows.Forms.BindingSource aXprodutoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQntVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCadVenda;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBuscaCli;
        private System.Windows.Forms.Button btCadCliente;
        private System.Windows.Forms.DateTimePicker txtDtVenda;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCPFc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomecli;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btAdicionar;
        private System.Windows.Forms.ToolStripButton btAlterarProd;
        private System.Windows.Forms.ToolStripButton btRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntEstoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdVendaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precocollunm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotaColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdCliente;
    }
}