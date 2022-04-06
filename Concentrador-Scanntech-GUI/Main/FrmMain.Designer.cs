namespace Concentrador_Scanntech_GUI.Main
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definiçõesScanntechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sincronizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promocõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promocõesAtivasNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promoçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasEnviadasScanntechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sincronizadorToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.promocõesToolStripMenuItem,
            this.vendasToolStripMenuItem2,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definiçõesScanntechToolStripMenuItem,
            this.bancoDeDadosToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // definiçõesScanntechToolStripMenuItem
            // 
            this.definiçõesScanntechToolStripMenuItem.Name = "definiçõesScanntechToolStripMenuItem";
            this.definiçõesScanntechToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.definiçõesScanntechToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.definiçõesScanntechToolStripMenuItem.Text = "Definições Scanntech";
            this.definiçõesScanntechToolStripMenuItem.Click += new System.EventHandler(this.definiçõesScanntechToolStripMenuItem_Click);
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // sincronizadorToolStripMenuItem
            // 
            this.sincronizadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.sincronizadorToolStripMenuItem.Name = "sincronizadorToolStripMenuItem";
            this.sincronizadorToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.sincronizadorToolStripMenuItem.Text = "Sincronizador";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // promocõesToolStripMenuItem
            // 
            this.promocõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promocõesAtivasNoToolStripMenuItem});
            this.promocõesToolStripMenuItem.Name = "promocõesToolStripMenuItem";
            this.promocõesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.promocõesToolStripMenuItem.Text = "Promocões";
            // 
            // promocõesAtivasNoToolStripMenuItem
            // 
            this.promocõesAtivasNoToolStripMenuItem.Name = "promocõesAtivasNoToolStripMenuItem";
            this.promocõesAtivasNoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.promocõesAtivasNoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.promocõesAtivasNoToolStripMenuItem.Text = "Promocões Ativas no PDV";
            this.promocõesAtivasNoToolStripMenuItem.Click += new System.EventHandler(this.promocõesAtivasNoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 17);
            this.lblStatus.Text = "Status:";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.promoçõesToolStripMenuItem,
            this.vendasToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.vendasToolStripMenuItem.Text = "Fechamentos";
            // 
            // promoçõesToolStripMenuItem
            // 
            this.promoçõesToolStripMenuItem.Name = "promoçõesToolStripMenuItem";
            this.promoçõesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.promoçõesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.promoçõesToolStripMenuItem.Text = "Promoções";
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.V)));
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            // 
            // vendasToolStripMenuItem2
            // 
            this.vendasToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasEnviadasScanntechToolStripMenuItem,
            this.vendasToolStripMenuItem3});
            this.vendasToolStripMenuItem2.Name = "vendasToolStripMenuItem2";
            this.vendasToolStripMenuItem2.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem2.Text = "Vendas";
            // 
            // vendasEnviadasScanntechToolStripMenuItem
            // 
            this.vendasEnviadasScanntechToolStripMenuItem.Name = "vendasEnviadasScanntechToolStripMenuItem";
            this.vendasEnviadasScanntechToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.vendasEnviadasScanntechToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.vendasEnviadasScanntechToolStripMenuItem.Text = "Vendas enviadas Scanntech";            
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concentrador - Scanntech";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem definiçõesScanntechToolStripMenuItem;
        private StatusStrip statusStrip1;
        public ToolStripStatusLabel lblStatus;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private ToolStripMenuItem sincronizadorToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem promocõesToolStripMenuItem;
        private ToolStripMenuItem promocõesAtivasNoToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem2;
        private ToolStripMenuItem vendasEnviadasScanntechToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem3;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem promoçõesToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem1;
    }
}