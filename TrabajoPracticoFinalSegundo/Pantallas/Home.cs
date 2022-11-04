﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoFinalSegundo.Clases;

namespace TrabajoPracticoFinalSegundo.Pantallas
{
    public partial class Home : Form
    {
        List<Jugador> jugadores;
        String op;
        int segundos;

        public Home()
        {
            InitializeComponent();

            //Carga de componentes.
            this.segundos = 0;
            this.pantallaWeb1.WebLoad();
            this.pantallaWeb2.WebLoad();
            this.pantallaWeb3.WebLoad();

            int x = (this.Width / 2);
            int y = (this.Height / 2);

            #region CONFIGURACION RESPONSIVA 

            //RECURSOS
            this.recursosDisplay1.LoadRecursos(flowLayoutPanel4.Width, flowLayoutPanel4.Height);

            //BARCO

            this.barco1.loadBarco(this.flowLayoutPanel5.Width,this.flowLayoutPanel5.Height);
            this.BackgroundImage = Image.FromFile(@".\Recursos\Fondos\\FondoHomeDos.jpg");

            //BARRA (INFERIOR)
            x = Convert.ToInt32(this.flowLayoutPanel1.Width / 2);
            y = this.flowLayoutPanel1.Height;

            this.dados1.LoadTablero(x, y);
            this.urna1.Load_Urna(x, y);
            this.turnero1.LoadTurnero(x, y);

            //PROGRESSBAR
            this.progress.Width = this.Width;
            this.progress.Visible = true;
            this.progress.Minimum = 1;
            this.progress.Maximum = 100;
            this.progress.Value = 1;
            this.progress.Step = 1;
            #endregion


            //Creacion Jugadores.
            this.jugadores = new List<Jugador>();

            Capitan X = new Capitan();
            Carpintero Y = new Carpintero();

            jugadores.Add(X);
            jugadores.Add(Y);

            IniciarJuego();


        }

        private void Home_Load(object sender, EventArgs e)
        {

        }


        #region JUEGO

        private void IniciarJuego() 
        {
            this.progress.Visible = true;
            int i = 0;


        }


        private void Update_Tick(object sender, EventArgs e)
        {
            HacerPaso(); 
            segundos++;
        }


        #endregion


        #region FUNCIONES

        #region PROGRES_BAR

        private void HacerPaso() 
        {
            /*
            if () 
            {
                this.progress.PerformStep();
            }
            */
            
        }

        #endregion


        #region CERRAR FORM
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirAlIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }



        #endregion

        #endregion

        private void barco1_Load(object sender, EventArgs e)
        {

        }

        private void dados1_Load(object sender, EventArgs e)
        {
            this.dados1.AsignarTurnero(ref this.turnero1);
        }
    }
}
