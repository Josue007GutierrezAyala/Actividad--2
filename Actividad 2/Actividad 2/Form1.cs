﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void TextNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textcontraseña_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {

            if (textNombre.Text.ToString() == "juancho")
            {
                if (textcontraseña.Text.ToString() == "123tamarindo")
                {
                    MessageBox.Show("inciando sesion");
                }
                else
                    MessageBox.Show("Contraseña incorrecta.");
            }
            else
            {
                MessageBox.Show("Usuario -" + textNombre.Text + "- no encontrado.");
                textNombre.Text = "";
                textcontraseña.Text = "";
                textNombre.Focus();

            }
        }

        private void Fuera_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
