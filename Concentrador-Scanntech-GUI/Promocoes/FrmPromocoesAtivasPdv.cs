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

namespace Concentrador_Scanntech_GUI.Promocoes
{
    public partial class FrmPromocoesAtivasPdv : Form
    {
        private readonly IUnitOfWork _uow;
        public FrmPromocoesAtivasPdv(IUnitOfWork uow)
        {
            _uow = uow;
            InitializeComponent();
            Load += FrmPromocoesAtivasPdv_Load;
        }

        private async void FrmPromocoesAtivasPdv_Load(object? sender, EventArgs e)
        {
            var promocoes = await _uow.PromocoesRepository.ObterTodos();

            gridPromocao.DataSource = promocoes;
            gridBeneficio.DataSource = await _uow.PromocoesRepository.ArtigosBeneficios();
            gridCondicao.DataSource = await _uow.PromocoesRepository.ArtigosCondicao();
        }
    }
}
