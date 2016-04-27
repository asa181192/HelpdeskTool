using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Threading;
/*@Author Alfredo Santiago Alvarado 
 * Fecha : 14/04/2016
 * Actualizaciones 
 * 19/04/2016 mayor
 * -Agregada Apartado de validacion de remesa para saber estatus-
 * 25/04/2016 minimo 
 * -Agregado validacion para tomar TransferId en las busquedas de remesas .
 * 27/04/2016 Medio 
 * -Agregado hilos para relizar concurrencia entre las operaciones , asi como pantalla de carga .
 */

namespace HelpdeskTool
{
    public partial class Eraser : Form
    {
        private short op;
        private String value;
        private String remesa;
        private String mensaje;
        private AccesoDatos data;
        DataTable table;
      
        public Eraser()
        {
           
            InitializeComponent();
            operacion.Items.Add("Reverso (Disponible)");
            operacion.Items.Add("Cancelacion (Cash)");
            operacion.Items.Add("Rechazo (Deposit)");
            operacion.Items.Add("Pago");
            

        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            
            
            table = new DataTable();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            data = new AccesoDatos();
            loadingGif.Visible = false;

                     
        }

        private void button1_Click(object sender, EventArgs e) // validaciones al momento de presentarte en la interfaz 
        {
            
           //Ejecucion de operacion sobre las remesas Reverso , Cancelaciones , etc .. 

            if (claimNumber.Text.ToString() != "" && message.Text.ToString() != "" && operacion.SelectedItem.ToString() != "")
            {

                op = 1; 
                value = operacion.SelectedItem.ToString();
                remesa = claimNumber.Text.ToString().Trim();
                mensaje = message.Text.ToString();

                if (value.Equals("Reverso (Disponible)"))
                {
                    hideItems(true);
                    data.reversa(remesa, mensaje);                 
                    backgroundWorker1.RunWorkerAsync();        
  
                }
                if (value.Equals("Cancelacion (Cash)") || value.Equals("Rechazo (Deposit)") || value.Equals("Pago"))
                {
                    hideItems(true);                    
                    data.anulacion(remesa, mensaje, value);
                    backgroundWorker1.RunWorkerAsync();    
                                     

                }

              clear();                 
               
            }
            else
            {
                info.Text = "No puedes dejar campos vacios";
            }

          

        }

        private void operacion_SelectedIndexChanged(object sender, EventArgs e)
        { // autollenado de nota dependiendo de la operacion 

            String value = "" ;
            if (operacion.SelectedItem != null)
            {
                   
                    value = operacion.SelectedItem.ToString();
                   
            }
            
            switch (value)      
            {
                case "Cancelacion (Cash)": message.Text = "Cancel Manually by ";
                    break;
                case "Rechazo (Deposit)": message.Text = "Rejected Manually by  ";
                    break;
                case "Pago": message.Text = "Complete Manually by";
                    break;
                case "Reverso (Disponible)": message.Text = "Reverse Manually by ";
                    break;
                  
            }

        }

        private void verificar_Click(object sender, EventArgs e) // Metodo para validaar los estatus de las remesas . 
        {
           
            op = 2;
            if (!claimNumber.Text.ToString().Equals(""))
            {
                hideItems(true);
                remesa = claimNumber.Text.ToString().Trim();            
                data.validar(remesa);   
                backgroundWorker1.RunWorkerAsync();                         
            
                 
            }
        }

        #region
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        #endregion 

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
                     
        } // limpia los campos de la pantalla 

        private void clear() // metodo para limpiar pantalla . 
        {
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
            info.Clear();
           
        }

        private void hideItems(bool op)
        {
            if (op.Equals(true))
            {             

                foreach(Control c in this.Controls) 
                {
                    if (c.Name.Equals(loadingGif.Name))
                    {
                        loadingGif.Visible = true;
                    }
                    else
                    {
                         c.Visible = false;
                    }
                   
                }

            }
            else
            {
                foreach (Control c in this.Controls)
                {
                    if (c.Name.Equals(loadingGif.Name))
                    {
                        loadingGif.Visible = false;
                    }
                    else
                    {
                        c.Visible = true;
                    }
                }
            }
          
        } //metodo para ocultar elementos de la pantalla , funciona para realizar un loading de screen 

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            switch (op)
            {
                case 1:
                    while (true)
                    {
                        if (data.th.IsAlive.Equals(false))
                        {
                            backgroundWorker1.ReportProgress(1);
                            break;
                        }
                    }
                    break;             
                case 2 : 
                      while(true)
                      {
                         if(data.th.IsAlive.Equals(false))
                           {
                            backgroundWorker1.ReportProgress(2);
                            break;
                            }            
                      }
                    break; 
            }


          
            
        } // Metodo que realiza trabajo en un hilo separado de la UI 

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)// Permite actualizar los formularios del Main Thread .
        {
            switch (e.ProgressPercentage) 
            {
                case 2 :
                     hideItems(false);
                     gridVista.DataSource = data.Table;
                    break; 
                case 1 :
                     hideItems(false);
                     info.Text = data.Message;
                    break;                

            }

           
        }

        
        

       
       
    }
}
