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
    public partial class FormEditar : Form
    {

        CashUnits _cashUnits;

        public FormEditar(CashUnits cashUnits)
        {
            InitializeComponent();
            _cashUnits = cashUnits;

            rdbREJ.Checked = true;

            carregaLista();

        }

        private void carregaLista()
        {
            ltbCashUnits.Items.Clear();

            foreach (CashUnit c in _cashUnits.cashUnits)
            {
                ltbCashUnits.Items.Add(c);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CashUnit cashUnit = JsonConvert.DeserializeObject<CashUnit>(txbCashUnit.Text);

            //6018_6023 REC
            //6019_6021 REJ
            //6019_6026 RET
            //6017_6023 DEP
            //6019_6029 ESC
            //6019_6019 OUT

            if (rdbREC.Checked)
            {
                cashUnit.kind = 6018;
                cashUnit.type = 6023;
            }

            if (rdbREJ.Checked)
            {
                cashUnit.kind = 6019;
                cashUnit.type = 6021;
            }

            if (rdbRET.Checked)
            {
                cashUnit.kind = 6019;
                cashUnit.type = 6026;
            }

            if(rdbDEP.Checked)
            {
                cashUnit.kind = 6017;
                cashUnit.type = 6023;
            }

            _cashUnits.cashUnits.Add(cashUnit);
            carregaLista();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int index = _cashUnits.cashUnits.FindIndex(x => x.number == ((CashUnit)(ltbCashUnits.SelectedItem)).number);
            _cashUnits.cashUnits.RemoveAt(index);
            carregaLista();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CashUnit cashUnit = JsonConvert.DeserializeObject<CashUnit>(txbCashUnit.Text);

            int index =_cashUnits.cashUnits.FindIndex(x => x.number == ((CashUnit)(ltbCashUnits.SelectedItem)).number);
            _cashUnits.cashUnits.RemoveAt(index);
            _cashUnits.cashUnits.Insert(index, cashUnit);
            carregaLista();
        }

        private void ltbCashUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ltbCashUnits.SelectedIndex != -1)
            {
                txbCashUnit.Text = Utils.JsonPrettify(
                    JsonConvert.SerializeObject(
                        _cashUnits.cashUnits.Find(x => x.number == ((CashUnit)(ltbCashUnits.SelectedItem)).number)));
            }
        }
    }
}
