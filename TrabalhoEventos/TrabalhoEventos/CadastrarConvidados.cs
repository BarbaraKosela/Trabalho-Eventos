﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoEventos
{
    public partial class CadastrarConvidados : Form
    {
        public CadastrarConvidados()
        {
            InitializeComponent();
        }

        private void btnCadastrarConvidado_Click(object sender, EventArgs e)
        {
            SistemaCadastrarConvidados sistemaCadastrarConvidados = new SistemaCadastrarConvidados();
            sistemaCadastrarConvidados.Show();
        }
    }
}
