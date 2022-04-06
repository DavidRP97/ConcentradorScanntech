using Concentrador_Scanntech_Entities.Model.Definicoes;
using Concentrador_Scanntech_GUI.Sincronizador;
using Concentrador_Scanntech_Repository.UoW;
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
using static Concentrador_Scanntech_Entities.Utils.Enums;

namespace Concentrador_Scanntech_GUI.Configuracoes
{
    public partial class FrmDefinicoesScanntech : Form
    {
        private readonly IUnitOfWork _uow;
        public FrmDefinicoesScanntech(IUnitOfWork uow)
        {
            _uow = uow;
            InitializeComponent();
            Load += FrmDefinicoesScanntech_Load;
        }

        private void FrmDefinicoesScanntech_Load(object? sender, EventArgs e)
        {
            try
            {
                var status = Enum.GetValues(typeof(StateEnums)).Cast<StateEnums>().ToList();
                cmbStatus.DataSource = status;
                CarregarTextBox();
            }
            catch (Exception)
            {

                MessageBox.Show("Falha ao carregar as informações", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarTextBox()
        {
            try
            {
                var definicoes = _uow.DefinicoesRepository.ObterTodosInclusoUrl();

                if (definicoes.Count() > 0)
                {
                    var definicao = definicoes.FirstOrDefault();

                    txtUsuario.Text = definicao.Usuario;
                    txtSenha.Text = definicao.Senha;
                    txtCodigoEmpresa.Text = definicao.IdCompanhia.ToString();
                    txtIdLocal.Text = definicao.IdLocal.ToString();
                    mtbDataIntegracao.Text = definicao.DataDeIntegração.ToString();
                    mtbFechamento.Text = definicao.HorarioDeEnvioFechamento;
                    numRequisicoes.Value = definicao.QuantidadeDeEnviosParaScanntech;
                    numPromo.Value = definicao.SincronizacaoPromocoes;
                    numVendas.Value = definicao.SincronizacaoVendas;
                    numManual.Value = definicao.SincronizacaoManual;
                    cmbStatus.SelectedIndex = (int)definicao.EstadoDaPromocao;

                    var flag = 0;

                    foreach (var item in definicao.uRLs)
                    {
                        if (flag == 0)
                        {
                            txtUrl1.Text = item.UrlConnection;
                        }
                        else if (flag == 1)
                        {
                            txtUrl2.Text = item.UrlConnection;
                        }
                        else if (flag == 2)
                        {
                            txtUrl3.Text = item.UrlConnection;
                        }
                        else if (flag == 3)
                        {
                            txtUrl4.Text = item.UrlConnection;
                        }
                        flag++;
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Falha ao carregar as informações", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var definicao = new DefinicoesScanntech();
                var urls = new List<URL>();

                definicao.Usuario = txtUsuario.Text;
                definicao.Senha = txtSenha.Text;
                definicao.IdCompanhia = Convert.ToInt32(txtCodigoEmpresa.Text);
                definicao.IdLocal = Convert.ToInt32(txtIdLocal.Text);
                definicao.DataDeIntegração = Convert.ToDateTime(mtbDataIntegracao.Text).ToUniversalTime();
                definicao.HorarioDeEnvioFechamento = mtbFechamento.Text;
                definicao.QuantidadeDeEnviosParaScanntech = Convert.ToInt32(numRequisicoes.Value);
                definicao.SincronizacaoPromocoes = Convert.ToInt32(numPromo.Value);
                definicao.SincronizacaoVendas = Convert.ToInt32(numVendas.Value);
                definicao.SincronizacaoManual = Convert.ToInt32(numManual.Value);
                definicao.EstadoDaPromocao = (StateEnums)cmbStatus.SelectedValue;

                urls.Add(new URL { UrlConnection = txtUrl1.Text });
                urls.Add(new URL { UrlConnection = txtUrl2.Text });
                urls.Add(new URL { UrlConnection = txtUrl3.Text });
                urls.Add(new URL { UrlConnection = txtUrl4.Text });

                definicao.uRLs = urls;

                var salvo = _uow.DefinicoesRepository.AddOrUpdate(definicao);

                if (salvo == false)
                {
                    MessageBox.Show("Falha ao salvar as informações", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Alterações salvas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Falha ao salvar as informações {ex.Message}", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
