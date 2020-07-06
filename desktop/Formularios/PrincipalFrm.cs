﻿using Festival.listagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Festival.desktop.Formularios
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();

            //Maximizar Tela Principal

            WindowState = FormWindowState.Maximized;
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventoFrm eventoFrm = new EventoFrm();
            eventoFrm.Visible = true;
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEvento listar = new ListaEvento();
            listar.Visible = true;
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoriaFrm categoriaFrm = new CategoriaFrm();
            categoriaFrm.Visible = true;
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             ListaCategoria listaCategoria = new ListaCategoria();
             listaCategoria.Visible = true;
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
             JuradoFrm juradoFrm = new JuradoFrm();
             juradoFrm.Visible = true;
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
             ListaJuri listaJuri = new ListaJuri();
             listaJuri.Visible = true;
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CantorFrm cantorFrm = new CantorFrm();
            cantorFrm.Visible = true;
        }
    }
}
