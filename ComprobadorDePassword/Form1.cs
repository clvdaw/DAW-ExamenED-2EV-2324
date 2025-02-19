﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprobadorDePassword
{
    public partial class ExamenCLV2324 : Form
    {
        public ExamenCLV2324()
        {
            InitializeComponent();
        }

        private void btnComprobar_click(object sender, EventArgs e)
        {
            comprobadorDePasswordCLV2324 miComprobador = new comprobadorDePasswordCLV2324();
            int resultado = miComprobador.test(txtPassword.Text);
            if (resultado < 0)
                MessageBox.Show("La contraseña no puede estar vacía");
            if (resultado == 0)
                MessageBox.Show("Contraseña demasiado corta");
            if (resultado == 1)
                MessageBox.Show("Contraseña débil");
            if (resultado == 2)
                MessageBox.Show("Contraseña normal");
            if (resultado == 3)
                MessageBox.Show("Contraseña fuerte");
            if (resultado == 4)
                MessageBox.Show("Contraseña muy fuerte");
        }
    }
}
