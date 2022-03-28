using Concentrador_Scanntech_GUI.Utils;
using Concentrador_Scanntech_Repository.UoW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concentrador_Scanntech_GUI.Sincronizador
{
    public partial class FrmSincronizador : Form
    {
        private readonly IUnitOfWork _uow;
        private int SincronizacaoPromocoes { get; set; }
        private int SincronizacaoVendas { get; set; }
        private int SincronizacaoManual { get; set; }
        private bool PrimeiroLoad { get; set; }
        public FrmSincronizador(IUnitOfWork uow)
        {
            _uow = uow;
            InitializeComponent();
            Load += FrmSincronizador_Load;
        }

        private async void FrmSincronizador_Load(object? sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                
                var definicoes = await _uow.DefinicoesRepository.ObterTodos();
                var definicao = definicoes.FirstOrDefault();

                if (definicao != null)
                {
                    SincronizacaoPromocoes = definicao.SincronizacaoPromocoes;
                    SincronizacaoVendas = definicao.SincronizacaoVendas;
                    SincronizacaoManual = definicao.SincronizacaoManual;
                    PrimeiroLoad = true;
                }

                lblMinutosPromocoes.Text = SincronizacaoPromocoes.ToString();   
                lblMinutosVendas.Text = SincronizacaoVendas.ToString(); 
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblSegundosPromocoes.Text = (Convert.ToInt32(lblSegundosPromocoes.Text) - 1).ToString();
            lblSegundosVendas.Text = (Convert.ToInt32(lblSegundosVendas.Text) - 1).ToString();

            if(lblSegundosVendas.Text == "0" || PrimeiroLoad == true)
            {
                if (lblMinutosVendas.Text == "0")
                {
                    timer1.Stop();
                    lblMinutosVendas.Text = SincronizacaoVendas.ToString();
                    BaixaVendasDoPdv();
                    ExecutaEnvioDeVendasScanntech();
                    lblStatus.Text = Status.EmExecucao;
                }
                if (lblMinutosPromocoes.Text == "0")
                {
                    timer1.Stop();
                    lblMinutosPromocoes.Text = SincronizacaoPromocoes.ToString();
                }
                lblSegundosPromocoes.Text = "59";
                lblSegundosVendas.Text = "59";
                lblMinutosVendas.Text = (Convert.ToInt32(lblMinutosVendas.Text) - 1).ToString();
                lblMinutosPromocoes.Text =(Convert.ToInt32(lblMinutosPromocoes.Text) - 1).ToString();
                PrimeiroLoad = false;
            }
            if(lblSegundosVendas.Text == "0" && lblMinutosVendas.Text == "0")
            {                
                lblMinutosVendas.Text = SincronizacaoVendas.ToString();
            }
            if (lblSegundosPromocoes.Text == "0" && lblMinutosPromocoes.Text == "0")
            {
                lblMinutosPromocoes.Text = SincronizacaoPromocoes.ToString();
            }
        }
        private async void ExecutaEnvioDeVendasScanntech()
        {
            lblStatus.Text = Status.EnviandoVendasScanntech;
            timer1.Start();
        }
        private async void BaixaVendasDoPdv()
        {
            lblStatus.Text = Status.BuscandoVendasPdv;
        }
    }
}
