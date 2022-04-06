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
            if (VerificarSeBancoEstaAtivo() == true)
            {
                var nomeBanco = StringDeConexao.LerTxt();
                lblStatus.Text = $"Status: Conectado - {nomeBanco.BancoDeDados} - {nomeBanco.NomeDoBanco}";
                lblStatus.ForeColor = Color.DarkGreen;

                if (DialogResult.Yes == MessageBox.Show("Deseja iniciar o sincronizador?", "Iniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    AbrirFormSincronizador();
                }
            }
            else
            {
                var nomeBanco = StringDeConexao.LerTxt();
                lblStatus.Text = $"Status: Conectado - {nomeBanco.BancoDeDados} - {nomeBanco.NomeDoBanco} - definições do sincronizador ausentes e/ou inválidas";
                lblStatus.ForeColor = Color.Red;
            }
        }        

        private void definiçõesScanntechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormDefinicoes();
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                AbrirFormConfigBancoDeDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormSincronizador();
        }

        private void promocõesAtivasNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormPromocoes();
        }

        #region Abrir Forms

        private void AbrirFormPromocoes()
        {
            var frm = Program.serviceProvider.GetService<FrmPromocoesAtivasPdv>();
            frm.MdiParent = this;
            frm.Show();
        }

        private void AbrirFormSincronizador()
        {
            var frm = Program.serviceProvider.GetService<FrmSincronizador>();
            frm.Show();
        }

        private void AbrirFormConfigBancoDeDados()
        {
            var frm = Program.serviceProvider.GetService<FrmConfigurarBancoDeDados>();
            frm.Flag = 1;
            frm.ShowDialog();
        }

        private void AbrirFormDefinicoes()
        {
            var frm = Program.serviceProvider.GetService<FrmDefinicoesScanntech>();
            frm.MdiParent = this;
            frm.Show();
        }

        #endregion

        #region Metodos
        private bool VerificarSeBancoEstaAtivo()
        {
            try
            {
                var status = _uow.DefinicoesRepository.ObterTodos();

                if (status.Count() != 0)
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Banco de dados não configurado ou configurações inválidas\nVerifique as configurações de acesso",
                    "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);

                AbrirFormConfigBancoDeDados();
            }
            return false;
        }
        #endregion
    }
}
