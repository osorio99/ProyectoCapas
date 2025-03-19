﻿using Logica;
using System;
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
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController();
            string resultado = controller.GuardarUsuario(tbNombre.Text, tbDescription.Text);
            lbResultado.Text = resultado;
        }
    }
}
