using Concentrador_Scanntech_Entities.Dtos.Promocoes;
using Concentrador_Scanntech_GUI.Utils;
using Concentrador_Scanntech_Repository.UoW;
using Concentrador_Scanntech_Services.Interfaces;
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
        private readonly IObterPromocoesService _obterPromocoes;
        private int SincronizacaoPromocoes { get; set; }
        private int SincronizacaoVendas { get; set; }
        private int SincronizacaoManual { get; set; }
        private bool PrimeiroLoad { get; set; }

        public FrmSincronizador(IUnitOfWork uow, IObterPromocoesService obterPromocoes)
        {
            _obterPromocoes = obterPromocoes;
            _uow = uow;
            InitializeComponent();
            Load += FrmSincronizador_Load;
        }

        private async void FrmSincronizador_Load(object? sender, EventArgs e)
        {
            try
            {
                timer1.Start();

                var definicao = await _uow.DefinicoesRepository.ObterDefinicao();
                var promocoes = await _uow.PromocoesRepository.ObterTodos();
              
                if (definicao != null)
                {
                    SincronizacaoPromocoes = definicao.SincronizacaoPromocoes;
                    SincronizacaoVendas = definicao.SincronizacaoVendas;
                    SincronizacaoManual = definicao.SincronizacaoManual;
                    PrimeiroLoad = true;
                    lblPromocoesAtivas.Text = $"Promoções enviadas ao PDV: {promocoes.Count()}";
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

            if (lblSegundosVendas.Text == "0" || PrimeiroLoad == true)
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
                lblMinutosPromocoes.Text = (Convert.ToInt32(lblMinutosPromocoes.Text) - 1).ToString();
                PrimeiroLoad = false;
            }
            if (lblSegundosVendas.Text == "0" && lblMinutosVendas.Text == "0")
            {
                lblMinutosVendas.Text = SincronizacaoVendas.ToString();
            }
            if (lblSegundosPromocoes.Text == "0" && lblMinutosPromocoes.Text == "0")
            {
                lblMinutosPromocoes.Text = SincronizacaoPromocoes.ToString();
            }
        }


        #region ACOES
        private void buscarVendasPDVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void baixarPromoçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BaixarPromocoesScanntech();                
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void buscarFechamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void enviarVendasScanntechToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void enviarFechamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region METODOS
        private void ExecutaEnvioDeVendasScanntech()
        {
            lblStatus.Text = Status.EnviandoVendasScanntech;
            timer1.Start();
        }
        private void BaixaVendasDoPdv()
        {
            lblStatus.Text = Status.BuscandoVendasPdv;
        }
        private async Task SalvarVendasNoBanco(IEnumerable<ResultDto> result)
        {
            try
            {
                var promocoes = await _uow.PromocoesRepository.ObterTodos();

                foreach (var item in result)
                {
                    var produtoExiste = _uow.PromocoesRepository.ObterPorApiID(item.ApiId);

                    if (produtoExiste == null) await _uow.PromocoesRepository.SalvarPromocao(item);
                }

                foreach(var item in promocoes)
                {
                    var promocaoRejeitada = result.FirstOrDefault(x => x.ApiId == item.ApiId);

                    if (promocaoRejeitada == null) await _uow.PromocoesRepository.Excluir(item.ApiId);
                }

                lblPromocoesAtivas.Text = $"Promoções enviadas ao PDV: {promocoes.Count()}";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task BaixarPromocoesScanntech()
        {
            try
            {
                var definicao = await _uow.DefinicoesRepository.ObterDefinicao();

                foreach (var item in definicao.uRLs)
                {
                    var response = await _obterPromocoes.ObterPromocoesScanntech(definicao, item.UrlConnection);

                    if (response != null)
                    {
                        await SalvarVendasNoBanco(response.Resultados);
                        break;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }





        #endregion


    }
}
