﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.ShowDialog();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            CrearUsuario us = new CrearUsuario();
            us.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
