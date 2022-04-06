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

        private void FrmPromocoesAtivasPdv_Load(object? sender, EventArgs e)
        {
            var promocoes = _uow.PromocoesRepository.ObterTodos();

            gridPromocao.DataSource = promocoes;
            gridBeneficio.DataSource = _uow.PromocoesRepository.ArtigosBeneficios();
            gridCondicao.DataSource = _uow.PromocoesRepository.ArtigosCondicao();
        }
    }
}
