namespace Concentrador_Scanntech_GUI.Sincronizador
{
    partial class FrmSincronizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSincronizador));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.açõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVendasPDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baixarPromoçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFechamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarVendasScanntechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarFechamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSegundosPromocoes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMinutosPromocoes = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSegundosVendas = new System.Windows.Forms.Label();
            this.lblMinutosVendas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridVendasPendentes = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPromocoesAtivas = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gridFechamentosPendentes = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVendasPendentes)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFechamentosPendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // açõesToolStripMenuItem
            // 
            this.açõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarVendasPDVToolStripMenuItem,
            this.baixarPromoçõesToolStripMenuItem,
            this.buscarFechamentosToolStripMenuItem,
            this.enviarVendasScanntechToolStripMenuItem,
            this.enviarFechamentosToolStripMenuItem});
            this.açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
            this.açõesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.açõesToolStripMenuItem.Text = "Ações";
            // 
            // buscarVendasPDVToolStripMenuItem
            // 
            this.buscarVendasPDVToolStripMenuItem.Name = "buscarVendasPDVToolStripMenuItem";
            this.buscarVendasPDVToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.buscarVendasPDVToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.buscarVendasPDVToolStripMenuItem.Text = "Buscar Vendas PDV";
            this.buscarVendasPDVToolStripMenuItem.Click += new System.EventHandler(this.buscarVendasPDVToolStripMenuItem_Click);
            // 
            // baixarPromoçõesToolStripMenuItem
            // 
            this.baixarPromoçõesToolStripMenuItem.Name = "baixarPromoçõesToolStripMenuItem";
            this.baixarPromoçõesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.baixarPromoçõesToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.baixarPromoçõesToolStripMenuItem.Text = "Baixar Promoções";
            this.baixarPromoçõesToolStripMenuItem.Click += new System.EventHandler(this.baixarPromoçõesToolStripMenuItem_Click);
            // 
            // buscarFechamentosToolStripMenuItem
            // 
            this.buscarFechamentosToolStripMenuItem.Name = "buscarFechamentosToolStripMenuItem";
            this.buscarFechamentosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.buscarFechamentosToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.buscarFechamentosToolStripMenuItem.Text = "Buscar Fechamentos";
            this.buscarFechamentosToolStripMenuItem.Click += new System.EventHandler(this.buscarFechamentosToolStripMenuItem_Click);
            // 
            // enviarVendasScanntechToolStripMenuItem
            // 
            this.enviarVendasScanntechToolStripMenuItem.Name = "enviarVendasScanntechToolStripMenuItem";
            this.enviarVendasScanntechToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F6)));
            this.enviarVendasScanntechToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.enviarVendasScanntechToolStripMenuItem.Text = "Enviar Vendas Scanntech";
            this.enviarVendasScanntechToolStripMenuItem.Click += new System.EventHandler(this.enviarVendasScanntechToolStripMenuItem_Click);
            // 
            // enviarFechamentosToolStripMenuItem
            // 
            this.enviarFechamentosToolStripMenuItem.Name = "enviarFechamentosToolStripMenuItem";
            this.enviarFechamentosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F7)));
            this.enviarFechamentosToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.enviarFechamentosToolStripMenuItem.Text = "Enviar Fechamentos";
            this.enviarFechamentosToolStripMenuItem.Click += new System.EventHandler(this.enviarFechamentosToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(829, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 420);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cronômetro";
            // 
            // button2
            // 
            this.button2.Image = global::Concentrador_Scanntech_GUI.Properties.Resources.Button_Pause_icon;
            this.button2.Location = new System.Drawing.Point(103, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 50);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Concentrador_Scanntech_GUI.Properties.Resources.Button_Play_icon;
            this.button1.Location = new System.Drawing.Point(3, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 50);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSegundosPromocoes);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lblMinutosPromocoes);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 128);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Promoções";
            // 
            // lblSegundosPromocoes
            // 
            this.lblSegundosPromocoes.AutoSize = true;
            this.lblSegundosPromocoes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundosPromocoes.Location = new System.Drawing.Point(96, 56);
            this.lblSegundosPromocoes.Name = "lblSegundosPromocoes";
            this.lblSegundosPromocoes.Size = new System.Drawing.Size(42, 32);
            this.lblSegundosPromocoes.TabIndex = 2;
            this.lblSegundosPromocoes.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(81, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // lblMinutosPromocoes
            // 
            this.lblMinutosPromocoes.AutoSize = true;
            this.lblMinutosPromocoes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinutosPromocoes.Location = new System.Drawing.Point(43, 56);
            this.lblMinutosPromocoes.Name = "lblMinutosPromocoes";
            this.lblMinutosPromocoes.Size = new System.Drawing.Size(42, 32);
            this.lblMinutosPromocoes.TabIndex = 0;
            this.lblMinutosPromocoes.Text = "00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSegundosVendas);
            this.groupBox3.Controls.Add(this.lblMinutosVendas);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 128);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendas";
            // 
            // lblSegundosVendas
            // 
            this.lblSegundosVendas.AutoSize = true;
            this.lblSegundosVendas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundosVendas.Location = new System.Drawing.Point(96, 50);
            this.lblSegundosVendas.Name = "lblSegundosVendas";
            this.lblSegundosVendas.Size = new System.Drawing.Size(42, 32);
            this.lblSegundosVendas.TabIndex = 5;
            this.lblSegundosVendas.Text = "00";
            // 
            // lblMinutosVendas
            // 
            this.lblMinutosVendas.AutoSize = true;
            this.lblMinutosVendas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinutosVendas.Location = new System.Drawing.Point(43, 50);
            this.lblMinutosVendas.Name = "lblMinutosVendas";
            this.lblMinutosVendas.Size = new System.Drawing.Size(42, 32);
            this.lblMinutosVendas.TabIndex = 3;
            this.lblMinutosVendas.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(81, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridVendasPendentes);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 200);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendas Pendentes";
            // 
            // gridVendasPendentes
            // 
            this.gridVendasPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVendasPendentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVendasPendentes.Location = new System.Drawing.Point(3, 19);
            this.gridVendasPendentes.Name = "gridVendasPendentes";
            this.gridVendasPendentes.RowTemplate.Height = 25;
            this.gridVendasPendentes.Size = new System.Drawing.Size(823, 178);
            this.gridVendasPendentes.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripStatusLabel1,
            this.lblPromocoesAtivas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(829, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(115, 17);
            this.lblStatus.Text = "Status: Em execução";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // lblPromocoesAtivas
            // 
            this.lblPromocoesAtivas.Name = "lblPromocoesAtivas";
            this.lblPromocoesAtivas.Size = new System.Drawing.Size(169, 17);
            this.lblPromocoesAtivas.Text = "Promoções enviadas ao PDV: 0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gridFechamentosPendentes);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(829, 198);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fechamentos Pendentes";
            // 
            // gridFechamentosPendentes
            // 
            this.gridFechamentosPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFechamentosPendentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFechamentosPendentes.Location = new System.Drawing.Point(3, 19);
            this.gridFechamentosPendentes.Name = "gridFechamentosPendentes";
            this.gridFechamentosPendentes.RowTemplate.Height = 25;
            this.gridFechamentosPendentes.Size = new System.Drawing.Size(823, 176);
            this.gridFechamentosPendentes.TabIndex = 0;
            // 
            // FrmSincronizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 444);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmSincronizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sincronizador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVendasPendentes)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFechamentosPendentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem açõesToolStripMenuItem;
        private ToolStripMenuItem baixarPromoçõesToolStripMenuItem;
        private ToolStripMenuItem buscarVendasPDVToolStripMenuItem;
        private ToolStripMenuItem buscarFechamentosToolStripMenuItem;
        private ToolStripMenuItem enviarVendasScanntechToolStripMenuItem;
        private ToolStripMenuItem enviarFechamentosToolStripMenuItem;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private GroupBox groupBox4;
        private Label lblSegundosPromocoes;
        private Label label2;
        private Label lblMinutosPromocoes;
        private GroupBox groupBox3;
        private Label lblSegundosVendas;
        private Label lblMinutosVendas;
        private Label label5;
        private GroupBox groupBox2;
        private DataGridView gridVendasPendentes;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private GroupBox groupBox5;
        private DataGridView gridFechamentosPendentes;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblPromocoesAtivas;
    }
}