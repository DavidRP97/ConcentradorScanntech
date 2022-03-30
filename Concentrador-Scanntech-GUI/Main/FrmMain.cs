using Concentrador_Scanntech_GUI.Configuracoes;
using Concentrador_Scanntech_GUI.Promocoes;
using Concentrador_Scanntech_GUI.Sincronizador;
using Concentrador_Scanntech_Repository.Interfaces;
using Concentrador_Scanntech_Repository.UoW;
using Concentrador_Scanntech_Services.Utils;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concentrador_Scanntech_GUI.Main
{
    public partial class FrmMain : Form
    {
        private readonly IUnitOfWork _uow;
        public FrmMain(IUnitOfWork uow)
        {
            _uow = uow;

            InitializeComponent();
            Load += FrmMain_Load;
        }

        private void FrmMain_Load(object? sender, EventArgs e)
        {
            if (VerificarSeBancoEstaAtivo().Result == true)
            {
                var nomeBanco = StringDeConexao.LerTxt();
                lblStatus.Text = $"Status: Conectado - {nomeBanco.NomeDoBanco}";
                lblStatus.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblStatus.Text = $"Status: Não conectado.";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private async Task<bool> VerificarSeBancoEstaAtivo()
        {
            var status = await _uow.StatusBancoRepository.ObterTodos();
            var ativo = status.FirstOrDefault();

            if (status.Count() != 0 && ativo.StatusDoBanco == true)
            {
                return true;
            }

            return false;
        }

        private void definiçõesScanntechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = Program.serviceProvider.GetService<FrmDefinicoesScanntech>();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                var frm = Program.serviceProvider.GetService<FrmConfigurarBancoDeDados>();
                frm.Flag = 1;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = Program.serviceProvider.GetService<FrmSincronizador>();
            frm.Show();
        }

        private void promocõesAtivasNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = Program.serviceProvider.GetService<FrmPromocoesAtivasPdv>();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
