using Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjWFAula16052022
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frmClientes = new FrmConsultaClientes();
            frmClientes.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente() 
            { 
                Id =  int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text
            };

            ClienteService clienteService = new ClienteService();

            clienteService.Add(cliente);

            MessageBox.Show("Registro inserido com sucesso!");
        }
    }
}
