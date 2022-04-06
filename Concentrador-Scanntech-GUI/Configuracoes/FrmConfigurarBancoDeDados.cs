using Concentrador_Scanntech_Entities.Dtos;
using Concentrador_Scanntech_GUI.Main;
using Concentrador_Scanntech_Repository.Context;
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

namespace Concentrador_Scanntech_GUI.Configuracoes
{
    public partial class FrmConfigurarBancoDeDados : Form
    {
        public int Flag { get; set; }
        public FrmConfigurarBancoDeDados(IUnitOfWork uow)
        {
            InitializeComponent();
            Load += FrmConfigurarBancoDeDados_Load;
        }

        private void FrmConfigurarBancoDeDados_Load(object? sender, EventArgs e)
        {
            try
            {
                foreach (var item in BancosDisponiveis.ListaDeBancos())
                {
                    cmbBanco.Items.Add(item);
                }


                if (Flag == 1)
                {
                    var itens = StringDeConexao.LerTxt();

                    if (itens != null)
                    {
                        txtIpLocal.Text = itens.IpLocal;
                        numPorta.Value = Convert.ToDecimal(itens.Porta);
                        txtBanco.Text = itens.NomeDoBanco;
                        txtUsuario.Text = itens.Usuario;
                        txtSenha.Text = itens.Senha;
                        cmbBanco.SelectedItem = itens.BancoDeDados;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCriarBanco_Click(object sender, EventArgs e)
        {

            var montarString = new GerarStringDeConexaoDto
            {
                IpLocal = txtIpLocal.Text,
                Porta = numPorta.Value.ToString(),
                NomeDoBanco = txtBanco.Text,
                Usuario = txtUsuario.Text,
                Senha = txtSenha.Text,
                BancoDeDados = cmbBanco.SelectedItem.ToString(),
            };
            try
            {
                StringDeConexao.GerarTxt(montarString);

                DbContextMigration.EfMigration(new AppDbContext());

                Application.Restart();

            }
            catch
            {

                MessageBox.Show($"String de conexão inválida\nEncerrando aplicação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
        }
    }
}
