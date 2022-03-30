namespace Concentrador_Scanntech_GUI.Promocoes
{
    partial class FrmPromocoesAtivasPdv
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridPromocao = new System.Windows.Forms.DataGridView();
            this.cargaPdvDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.apiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteDePromocoesPorTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vigenciaDeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vigenciaAteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEnvioPdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promocaoScanntechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridCondicao = new System.Windows.Forms.DataGridView();
            this.condicaoArtigoScanntechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridBeneficio = new System.Windows.Forms.DataGridView();
            this.beneficioArtigoScanntechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apiIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDeBarrasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apiIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDeBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoScanntechBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCondicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicaoArtigoScanntechBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBeneficio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficioArtigoScanntechBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridPromocao);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Promoções";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridPromocao
            // 
            this.gridPromocao.AutoGenerateColumns = false;
            this.gridPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPromocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cargaPdvDataGridViewCheckBoxColumn,
            this.apiIdDataGridViewTextBoxColumn,
            this.limiteDePromocoesPorTicketDataGridViewTextBoxColumn,
            this.tipoPromocaoDataGridViewTextBoxColumn,
            this.vigenciaDeDataGridViewTextBoxColumn,
            this.vigenciaAteDataGridViewTextBoxColumn,
            this.dataEnvioPdvDataGridViewTextBoxColumn});
            this.gridPromocao.DataSource = this.promocaoScanntechBindingSource;
            this.gridPromocao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPromocao.Location = new System.Drawing.Point(3, 3);
            this.gridPromocao.Name = "gridPromocao";
            this.gridPromocao.RowTemplate.Height = 25;
            this.gridPromocao.Size = new System.Drawing.Size(786, 416);
            this.gridPromocao.TabIndex = 0;
            // 
            // cargaPdvDataGridViewCheckBoxColumn
            // 
            this.cargaPdvDataGridViewCheckBoxColumn.DataPropertyName = "CargaPdv";
            this.cargaPdvDataGridViewCheckBoxColumn.HeaderText = "CargaPdv";
            this.cargaPdvDataGridViewCheckBoxColumn.Name = "cargaPdvDataGridViewCheckBoxColumn";
            // 
            // apiIdDataGridViewTextBoxColumn
            // 
            this.apiIdDataGridViewTextBoxColumn.DataPropertyName = "ApiId";
            this.apiIdDataGridViewTextBoxColumn.HeaderText = "ApiId";
            this.apiIdDataGridViewTextBoxColumn.Name = "apiIdDataGridViewTextBoxColumn";
            // 
            // limiteDePromocoesPorTicketDataGridViewTextBoxColumn
            // 
            this.limiteDePromocoesPorTicketDataGridViewTextBoxColumn.DataPropertyName = "LimiteDePromocoesPorTicket";
            this.limiteDePromocoesPorTicketDataGridViewTextBoxColumn.HeaderText = "LimiteDePromocoesPorTicket";
            this.limiteDePromocoesPorTicketDataGridViewTextBoxColumn.Name = "limiteDePromocoesPorTicketDataGridViewTextBoxColumn";
            // 
            // tipoPromocaoDataGridViewTextBoxColumn
            // 
            this.tipoPromocaoDataGridViewTextBoxColumn.DataPropertyName = "TipoPromocao";
            this.tipoPromocaoDataGridViewTextBoxColumn.HeaderText = "TipoPromocao";
            this.tipoPromocaoDataGridViewTextBoxColumn.Name = "tipoPromocaoDataGridViewTextBoxColumn";
            // 
            // vigenciaDeDataGridViewTextBoxColumn
            // 
            this.vigenciaDeDataGridViewTextBoxColumn.DataPropertyName = "VigenciaDe";
            this.vigenciaDeDataGridViewTextBoxColumn.HeaderText = "VigenciaDe";
            this.vigenciaDeDataGridViewTextBoxColumn.Name = "vigenciaDeDataGridViewTextBoxColumn";
            // 
            // vigenciaAteDataGridViewTextBoxColumn
            // 
            this.vigenciaAteDataGridViewTextBoxColumn.DataPropertyName = "VigenciaAte";
            this.vigenciaAteDataGridViewTextBoxColumn.HeaderText = "VigenciaAte";
            this.vigenciaAteDataGridViewTextBoxColumn.Name = "vigenciaAteDataGridViewTextBoxColumn";
            // 
            // dataEnvioPdvDataGridViewTextBoxColumn
            // 
            this.dataEnvioPdvDataGridViewTextBoxColumn.DataPropertyName = "DataEnvioPdv";
            this.dataEnvioPdvDataGridViewTextBoxColumn.HeaderText = "DataEnvioPdv";
            this.dataEnvioPdvDataGridViewTextBoxColumn.Name = "dataEnvioPdvDataGridViewTextBoxColumn";
            // 
            // promocaoScanntechBindingSource
            // 
            this.promocaoScanntechBindingSource.DataSource = typeof(Concentrador_Scanntech_Entities.Model.Promocoes.PromocaoScanntech);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridCondicao);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Itens Condições";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridCondicao
            // 
            this.gridCondicao.AutoGenerateColumns = false;
            this.gridCondicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCondicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apiIdDataGridViewTextBoxColumn2,
            this.quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn1,
            this.codigoDeBarrasDataGridViewTextBoxColumn1});
            this.gridCondicao.DataSource = this.condicaoArtigoScanntechBindingSource;
            this.gridCondicao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCondicao.Location = new System.Drawing.Point(3, 3);
            this.gridCondicao.Name = "gridCondicao";
            this.gridCondicao.RowTemplate.Height = 25;
            this.gridCondicao.Size = new System.Drawing.Size(786, 416);
            this.gridCondicao.TabIndex = 0;
            // 
            // condicaoArtigoScanntechBindingSource
            // 
            this.condicaoArtigoScanntechBindingSource.DataSource = typeof(Concentrador_Scanntech_Entities.Model.Promocoes.CondicaoArtigoScanntech);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridBeneficio);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Itens Benefícios";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridBeneficio
            // 
            this.gridBeneficio.AutoGenerateColumns = false;
            this.gridBeneficio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBeneficio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apiIdDataGridViewTextBoxColumn1,
            this.quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.codigoDeBarrasDataGridViewTextBoxColumn});
            this.gridBeneficio.DataSource = this.beneficioArtigoScanntechBindingSource;
            this.gridBeneficio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBeneficio.Location = new System.Drawing.Point(0, 0);
            this.gridBeneficio.Name = "gridBeneficio";
            this.gridBeneficio.RowTemplate.Height = 25;
            this.gridBeneficio.Size = new System.Drawing.Size(792, 422);
            this.gridBeneficio.TabIndex = 0;
            // 
            // beneficioArtigoScanntechBindingSource
            // 
            this.beneficioArtigoScanntechBindingSource.DataSource = typeof(Concentrador_Scanntech_Entities.Model.Promocoes.BeneficioArtigoScanntech);
            // 
            // apiIdDataGridViewTextBoxColumn2
            // 
            this.apiIdDataGridViewTextBoxColumn2.DataPropertyName = "ApiId";
            this.apiIdDataGridViewTextBoxColumn2.HeaderText = "CodigoPromo";
            this.apiIdDataGridViewTextBoxColumn2.Name = "apiIdDataGridViewTextBoxColumn2";
            // 
            // quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn1
            // 
            this.quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn1.DataPropertyName = "QuantidadeParaAtivarPromocao";
            this.quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn1.HeaderText = "QuantidadeParaAtivarPromocao";
            this.quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn1.Name = "quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn1";
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            // 
            // codigoDeBarrasDataGridViewTextBoxColumn1
            // 
            this.codigoDeBarrasDataGridViewTextBoxColumn1.DataPropertyName = "CodigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn1.HeaderText = "CodigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn1.Name = "codigoDeBarrasDataGridViewTextBoxColumn1";
            // 
            // apiIdDataGridViewTextBoxColumn1
            // 
            this.apiIdDataGridViewTextBoxColumn1.DataPropertyName = "ApiId";
            this.apiIdDataGridViewTextBoxColumn1.HeaderText = "CodigoPromo";
            this.apiIdDataGridViewTextBoxColumn1.Name = "apiIdDataGridViewTextBoxColumn1";
            // 
            // quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn
            // 
            this.quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeParaAtivarPromocao";
            this.quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn.HeaderText = "QuantidadeParaAtivarPromocao";
            this.quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn.Name = "quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // codigoDeBarrasDataGridViewTextBoxColumn
            // 
            this.codigoDeBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn.HeaderText = "CodigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn.Name = "codigoDeBarrasDataGridViewTextBoxColumn";
            // 
            // FrmPromocoesAtivasPdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPromocoesAtivasPdv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPromocoesAtivasPdv";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoScanntechBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCondicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicaoArtigoScanntechBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBeneficio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficioArtigoScanntechBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView gridPromocao;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private BindingSource promocaoScanntechBindingSource;
        private DataGridViewCheckBoxColumn cargaPdvDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn apiIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn limiteDePromocoesPorTicketDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoPromocaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vigenciaDeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vigenciaAteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataEnvioPdvDataGridViewTextBoxColumn;
        private DataGridView gridCondicao;
        private DataGridView gridBeneficio;
        private BindingSource condicaoArtigoScanntechBindingSource;
        private BindingSource beneficioArtigoScanntechBindingSource;
        private DataGridViewTextBoxColumn apiIdDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn codigoDeBarrasDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn apiIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn quantidadeParaAtivarPromocaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDeBarrasDataGridViewTextBoxColumn;
    }
}