﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*@Author Alfredo Santiago Alvarado 
 * Fecha : 14/04/2016
 * Actualizaciones 
 * 19/04/2016
 * -Agregada Apartado de validacion de remesa para saber estatus-
 */

namespace HelpdeskTool
{
    public partial class Form1 : Form
    {

        private String remesa;
        private String mensaje;
        private AccesoDatos data;
        DataTable table;
        public Form1()
        {
           
            InitializeComponent();
            operacion.Items.Add("Reverso");
            operacion.Items.Add("Cancelacion");
            operacion.Items.Add("Rechazo");
            operacion.Items.Add("Pago");
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             table = new DataTable();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
             data = new AccesoDatos();
        }

        private void button1_Click(object sender, EventArgs e) // validaciones al momento de presentarte en la interfaz 
        {

            if (claimNumber.Text.ToString() != "" && message.Text.ToString() != "" && operacion.SelectedItem.ToString() != "")
            {
                String infoMessg;  
                
                String value = operacion.SelectedItem.ToString();
                remesa = claimNumber.Text.ToString().Trim();
                mensaje = message.Text.ToString();
                
                if (value.Equals("Reverso"))
                {
                    
                           
                    infoMessg = data.reversa(remesa, mensaje);
                    info.Text = infoMessg;

                }
                if (value.Equals("Cancelacion") || value.Equals("Rechazo") || value.Equals( "Pago"))
                {
                                       
                    infoMessg = data.anulacion(remesa, mensaje, value);
                    info.Text = infoMessg;

                }


                if (ChekBoxMensaje.Checked == false)
                {
                 message.Clear();
                }
                if (checkBoxOoperacion.Checked == false)
                {
                 operacion.SelectedIndex = -1;
                }

                if (checkBoxClaimNumber.Checked == false)
                {
                    gridVista.DataSource = null;
                    gridVista.Rows.Clear();
                     claimNumber.Clear();
                }
                  
               
            }
            else
            {
                info.Text = "No puedes dejar campos vacios";
            }
            

        }

        private void operacion_SelectedIndexChanged(object sender, EventArgs e)
        {

            String value = "" ;
            if (operacion.SelectedItem != null)
            {
            value = operacion.SelectedItem.ToString();
            }
            
            switch (value)      
            {
                case "Cancelacion": message.Text = "Cancel Manually by ";
                    break;
                case "Rechazo": message.Text = "Rejected Manually by  ";
                    break;
                case "Pago": message.Text = "Complete Manually by";
                    break;
                case "Reverso": message.Text = "Reverse Manually by ";
                    break;
                  
            }

        }

        private void verificar_Click(object sender, EventArgs e)
        {
            if (claimNumber.Text.ToString() != "")
            {
                remesa = claimNumber.Text.ToString().Trim();
                table = data.validar(remesa);
                gridVista.DataSource = table;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

       
    }
}
