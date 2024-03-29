﻿using Concentrador_Scanntech_Entities.Dtos.Promocoes;
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
        private int ContarSegundos { get; set; }
        private bool PrimeiroLoad { get; set; }

        public FrmSincronizador(IUnitOfWork uow, IObterPromocoesService obterPromocoes)
        {
            _obterPromocoes = obterPromocoes;
            _uow = uow;
            InitializeComponent();
            Load += FrmSincronizador_Load;
        }

        private void FrmSincronizador_Load(object? sender, EventArgs e)
        {
            try
            {
                timer1.Start();

                var definicao = _uow.DefinicoesRepository.ObterDefinicao();
                lblPromocoesAtivas.Text = $"Promoções enviadas ao PDV: {_uow.PromocoesRepository.ContarPromocoes()}";
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

                MessageBox.Show("Falha ao carregar definições\nReiniciando Aplicação", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ContarSegundos++;

            if (ContarSegundos == 15)
            {
                lblPromocoesAtivas.Text = $"Promoções enviadas ao PDV: {_uow.PromocoesRepository.ContarPromocoes()}";
                ContarSegundos = 0;
            }

            lblSegundosPromocoes.Text = (Convert.ToInt32(lblSegundosPromocoes.Text) - 1).ToString();
            lblSegundosVendas.Text = (Convert.ToInt32(lblSegundosVendas.Text) - 1).ToString();

            if (PrimeiroLoad == true)
            {
                lblSegundosPromocoes.Text = "59";
                lblSegundosVendas.Text = "59";
                lblMinutosVendas.Text = (Convert.ToInt32(lblMinutosVendas.Text) - 1).ToString();
                lblMinutosPromocoes.Text = (Convert.ToInt32(lblMinutosPromocoes.Text) - 1).ToString();
                PrimeiroLoad = false;
            }
            if (lblSegundosVendas.Text == "0" && lblMinutosVendas.Text == "0")
            {
                BaixaVendasDoPdv();
                ExecutaEnvioDeVendasScanntech();
                ReiniciarCronometroVendas();
            }
            if (lblSegundosPromocoes.Text == "0" && lblMinutosPromocoes.Text == "0")
            {
                BaixarPromocoesScanntech();
                ReiniciarCronometroPromocoes();
            }
            if (lblSegundosPromocoes.Text == "0")
            {
                lblSegundosPromocoes.Text = "59";
                lblMinutosPromocoes.Text = (Convert.ToInt32(lblMinutosPromocoes.Text) - 1).ToString();
            }
            if (lblSegundosVendas.Text == "0")
            {
                lblSegundosVendas.Text = "59";
                lblMinutosVendas.Text = (Convert.ToInt32(lblMinutosVendas.Text) - 1).ToString();
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
                lblStatus.Text = Status.BaixandoPromocoes;
                BaixarPromocoesScanntech();
                lblStatus.Text = Status.EmExecucao;

                ReiniciarCronometroPromocoes();
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
            ReiniciarCronometroVendas();
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
        private void SalvarPromocoes(IEnumerable<ResultDto> result)
        {
            try
            {
                var promocoes = _uow.PromocoesRepository.ObterTodos();

                if (result != null)
                {
                    foreach (var item in result)
                    {
                        var produtoExiste = _uow.PromocoesRepository.ObterPorApiID(item.ApiId);

                        if (produtoExiste == null) _uow.PromocoesRepository.SalvarPromocao(item);
                    }
                }
                else
                {
                    foreach (var item in promocoes)
                    {
                        _uow.PromocoesRepository.DeleteCascade(item.PromocaoId);
                    }
                }

                if (promocoes != null && result != null)
                {
                    foreach (var item in promocoes)
                    {
                        var promocaoRejeitada = result.FirstOrDefault(x => x.ApiId == item.ApiId);

                        if (promocaoRejeitada == null) _uow.PromocoesRepository.DeleteCascade(item.PromocaoId);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Falha ao salvar promoções Scanntech\nReiniciando Aplicação", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReiniciarCronometroPromocoes()
        {
            lblMinutosPromocoes.Text = SincronizacaoPromocoes.ToString();
            lblSegundosPromocoes.Text = "59";
            lblMinutosPromocoes.Text = (Convert.ToInt32(lblMinutosPromocoes.Text) - 1).ToString();
        }

        private void ReiniciarCronometroVendas()
        {
            lblMinutosVendas.Text = SincronizacaoVendas.ToString();
            lblSegundosVendas.Text = "59";
            lblMinutosVendas.Text = (Convert.ToInt32(lblMinutosVendas.Text) - 1).ToString();
        }
        private void BaixarPromocoesScanntech()
        {
            try
            {
                var definicao = _uow.DefinicoesRepository.ObterDefinicao();

                foreach (var item in definicao.uRLs)
                {
                    var response = _obterPromocoes.ObterPromocoesScanntech(definicao, item.UrlConnection);

                    if(response.Item2 == true)
                    {
                        SalvarPromocoes(response.Item1.Resultados);
                        break;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Falha ao baixar promoções Scanntech\nReiniciando Aplicação", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}
