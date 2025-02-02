﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumindoServico.ServiceReference1;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void brnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente clienteCadastro = new Cliente();
                clienteCadastro.Nome = nome;
                clienteCadastro.CPF = cpf;

                servico.Add(clienteCadastro);

                MessageBox.Show("Cliente cadastrado com sucesso");
            }
            catch (Exception)
            {
                //salvaria no log
                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();

                Cliente resultado = servico.Buscar(nome);

                txtCPF.Text = resultado.CPF;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
