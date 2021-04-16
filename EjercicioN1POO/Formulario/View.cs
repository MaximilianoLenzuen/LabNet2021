﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class View : Form
    {
        List<Transporte> listaDeVehiculos = new List<Transporte>();
        int t = 1;
        int j = 1;
        public View()
        {
            InitializeComponent();
        }

        private void MostrarDatos(object sender, EventArgs e)
        {
            this.txtDatos.Text = this.DevolverInformacion();
        }

        private void View_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                this.listaDeVehiculos.Add(new Avion(random.Next(1, 300)));
                this.listaDeVehiculos.Add(new Automovil(random.Next(1, 5)));
            }
        }

        private string DevolverInformacion()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var transporte in listaDeVehiculos)
            {
                if (transporte is Avion)
                {
                    sb.AppendLine(transporte.MostrarDatos(t));
                    t++;
                }
            }

            foreach (var transporte in listaDeVehiculos)
            {
                if (transporte is Automovil)
                {
                    sb.AppendLine(transporte.MostrarDatos(j));
                    j++;
                }
            }
            return sb.ToString();
        }
    }
}
