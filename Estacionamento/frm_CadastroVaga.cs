﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class frm_CadastroVaga : Form
    {
        public frm_CadastroVaga()
        {
            InitializeComponent();
        }

        public List<Vaga> vaga = new List<Vaga>();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            vaga.Add(new Vaga(txtIdVaga.Text));

            MessageBox.Show("Vaga Adicionada com sucesso");
        }
    }
}
