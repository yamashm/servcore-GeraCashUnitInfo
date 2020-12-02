using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteGeraCashUnitInfo
{
    public partial class Form1 : Form
    {
        CashUnits _cashUnits;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditar form = new FormEditar(_cashUnits);

            form.ShowDialog();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string conteudo = JsonConvert.SerializeObject(_cashUnits);
            conteudo = conteudo.Replace("\"", "\\\"");
            txbSaida.Text = conteudo;
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            string entrada = txbEntrada.Text;

            _cashUnits = new CashUnits();
            _cashUnits = JsonConvert.DeserializeObject<CashUnits>(entrada);
        }
    }
}
